﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Lab04_5
{
    public partial class MainWindow : Window
    {
        private static int coutOfWin = 0;
        public int count = 0;
        string curFileName = "editor1.txt";

        public MainWindow()
        {
            InitializeComponent();
            if (coutOfWin != 0)
            {
                this.Title += " (" + coutOfWin++ + ") ";
            }
            else
            {
                coutOfWin++;
            }
            Uri icon = new Uri("../../resources/editor.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(icon);
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            this.rtbEditor.AddHandler(RichTextBox.DragOverEvent, new DragEventHandler(this.DragItem), true);
            this.rtbEditor.AddHandler(RichTextBox.DropEvent, new DragEventHandler(this.DropItem), true);

            List<string> styles = new List<string> { "Light", "Dark", "Coral" };
            Theme.SelectionChanged += SelectTheme;
            Theme.ItemsSource = styles;
            Theme.SelectedItem = "Light";

            RefreshRecentFilesListInMenu();
        }
        
        private void SelectTheme(object sender, SelectionChangedEventArgs e)
        {
            string style = Theme.SelectedItem as string;
            var uri = new Uri("resources/"+style + "Theme.xaml", UriKind.Relative);
            if (style == "Dark" || style == "Coral")
            {
                Folder.Source = new BitmapImage(new Uri("resources/folder1.png", UriKind.Relative));
                Save.Source = new BitmapImage(new Uri("resources/disk1.png", UriKind.Relative));
                Undo.Source = new BitmapImage(new Uri("resources/undo1.png", UriKind.Relative));
                Redo.Source = new BitmapImage(new Uri("resources/redo1.png", UriKind.Relative));
                Bold.Source = new BitmapImage(new Uri("resources/text_bold1.png", UriKind.Relative));
                Italic.Source = new BitmapImage(new Uri("resources/text_italic1.png", UriKind.Relative));
                Underline.Source = new BitmapImage(new Uri("resources/text_underline1.png", UriKind.Relative));
            }
            else
            {
                Folder.Source = new BitmapImage(new Uri("resources/folder.png", UriKind.Relative));
                Save.Source = new BitmapImage(new Uri("resources/disk.png", UriKind.Relative));
                Undo.Source = new BitmapImage(new Uri("resources/undo.png", UriKind.Relative));
                Redo.Source = new BitmapImage(new Uri("resources/redo.png", UriKind.Relative));
                Bold.Source = new BitmapImage(new Uri("resources/text_bold.png", UriKind.Relative));
                Italic.Source = new BitmapImage(new Uri("resources/text_italic.png", UriKind.Relative));
                Underline.Source = new BitmapImage(new Uri("resources/text_underline.png", UriKind.Relative));
            }
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e) {
            object temp = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
            sldFontSize.Value = Convert.ToInt32(temp);
        }

        private void Color_Executed(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Windows.Forms.ColorDialog cd = new System.Windows.Forms.ColorDialog();
                var result = cd.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    rtbEditor.Selection.ApplyPropertyValue(Inline.ForegroundProperty,
                        new SolidColorBrush(Color.FromArgb(cd.Color.A, cd.Color.R, cd.Color.G, cd.Color.B)));
                }
            }
            catch { }
        }

        private void Font_Executed(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Windows.Forms.FontDialog fd = new System.Windows.Forms.FontDialog();
                var result = fd.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Debug.WriteLine(fd.Font);
                    rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, new FontFamily(fd.Font.Name));
                    rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, fd.Font.Size * 96.0 / 72.0);
                    rtbEditor.Selection.ApplyPropertyValue(Inline.FontWeightProperty, fd.Font.Bold ? FontWeights.Bold : FontWeights.Regular);
                    rtbEditor.Selection.ApplyPropertyValue(Inline.FontStyleProperty, fd.Font.Italic ? FontStyles.Italic : FontStyles.Normal);

                    TextDecorationCollection tdc = new TextDecorationCollection();
                    if (fd.Font.Underline) tdc.Add(TextDecorations.Underline);
                    if (fd.Font.Strikeout) tdc.Add(TextDecorations.Strikethrough);
                    rtbEditor.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, tdc);
                }
            }
            catch { }
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog
                {
                    FileName = "text.txt",
                    InitialDirectory = @"D:\Учеба\2 курс\4 семестр\ООП\лабы\Lab04-5"
                };
                dlg.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
                if (dlg.ShowDialog() == true)
                {
                    TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                    using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
                    {
                        switch (System.IO.Path.GetExtension(dlg.FileName).ToLower())
                        {
                            case ".rtf":
                                range.Load(fs, DataFormats.Rtf);
                                break;
                            case ".txt":
                                range.Load(fs, DataFormats.Text);
                                break;
                            default:
                                range.Load(fs, DataFormats.Xaml);
                                break;
                        }
                    }
                    RefreshRecentFilesList(dlg.FileName);
                    RefreshRecentFilesListInMenu();
                }
                else
                {
                    throw new Exception("Invalid extension");
                }
                this.Title = "TextEditor (" + dlg.FileName + ")";
            }

            catch (Exception ex)
            {
                MessageBox.Show("OPEN: " + ex.Message);
            }
        }

        private void LoadFile(string fileName)
        {
            try
            {
                TextRange doc = new TextRange(this.rtbEditor.Document.ContentStart, this.rtbEditor.Document.ContentEnd);
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    if (System.IO.Path.GetExtension(fileName) == ".txt")
                    {
                        doc.Load(fs, DataFormats.Text);
                    }
                    else
                    {
                        doc.Load(fs, DataFormats.Rtf);
                    }
                }

                Title = fileName;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void RefreshRecentFilesList(string fileName)       // обновить список последних файлов в файле cur
        {
            List<string> files = GetRecentFilesList();
            try
            {
                if (!files.Contains(fileName))      // если это новый файл
                {
                    using (StreamWriter sw = new StreamWriter(curFileName, true, Encoding.UTF8))
                    {
                        sw.WriteLine(fileName);
                    }
                }
                else
                {
                    files.Add(fileName);
                    using (StreamWriter sw = new StreamWriter(curFileName, false, Encoding.UTF8))
                    {
                        foreach (string i in files)
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private List<string> GetRecentFilesList()       // считать из файла cur имена последних файлов
        {
            List<string> files = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(curFileName, Encoding.UTF8))
                {
                    string fileName;
                    for (int i = 0; (fileName = sr.ReadLine()) != null; i++)
                    {
                        if (!files.Contains(fileName))
                        {
                            files.Add(fileName);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            return files;
        }

        private void RefreshRecentFilesListInMenu()
        {
            if (!System.IO.File.Exists(curFileName))
            {
                FileStream fs = System.IO.File.Create(curFileName);
                fs.Close();
            }

            List<string> files = GetRecentFilesList();
            files.Reverse();

            recentFiles.Items.Clear();
            for (int i = 0; i < files.Count; i++)
            {
                MenuItem newItem = new MenuItem();
                newItem.Header = files[i];
                newItem.Click += LoadRecentFile;
                if (!recentFiles.Items.Contains(newItem))
                {
                    recentFiles.Items.Add(newItem);
                }
            }
        }

        private void LoadRecentFile(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            string res = item.Header.ToString();
            LoadFile(res);
            RefreshRecentFilesList(res);
            RefreshRecentFilesListInMenu();
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog
                {
                    FileName = "text.txt",
                    InitialDirectory = @"D:\Учеба\2 курс\4 семестр\ООП\лабы\Lab04-5"
                };
                dlg.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
                if (dlg.ShowDialog() == true)
                {
                    TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                    using (FileStream fs = new FileStream(dlg.FileName, FileMode.Create))
                    {
                        switch (System.IO.Path.GetExtension(dlg.FileName).ToLower())
                        {
                            case ".rtf":
                                range.Save(fs, DataFormats.Rtf);
                                break;
                            case ".txt":
                                range.Save(fs, DataFormats.Text);
                                break;
                            default:
                                range.Save(fs, DataFormats.Xaml);
                                break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Invalid extension");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("SAVE: " + ex.Message);
            }
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void Delete_Executed(object sender, ExecutedRoutedEventArgs e) {
            rtbEditor.Selection.Text = "";
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e) {
            this.Close();
        }

        private void Clear_Ex(object sender, RoutedEventArgs e)
        {
            rtbEditor.Document.Blocks.Clear();
        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
        }

        private void sldFontSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                if (this.sldFontSize.IsFocused && this.sldFontSize.Value > 0)
                {
                    Change_sldFontSize();
                    ((Slider)sender).SelectionEnd = e.NewValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FONT: " + ex.Message);
            }
        }
        private void zoom_ValueChanged(object sender, RoutedEventArgs e)
        {
            zoom.Value = zoom.Ticks.Select(x => (double?)x)
                .FirstOrDefault(x => x > zoom.Value) ?? zoom.Value;
        }
        private void Change_sldFontSize()
        {
            TextRange range;
            if (!this.rtbEditor.Selection.IsEmpty)
            {
                range = new TextRange(this.rtbEditor.Selection.Start, this.rtbEditor.Selection.End);
            }
            else
            {
                range = new TextRange(this.rtbEditor.CaretPosition, this.rtbEditor.Document.ContentEnd);
            }
            range.ApplyPropertyValue(FontSizeProperty, this.sldFontSize.Value);
        }

        private void DragItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = false;
        }

        private void DropItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (System.IO.File.Exists(docPath[0]))
                {
                    try
                    {
                        TextRange range = new TextRange(this.rtbEditor.Document.ContentStart, this.rtbEditor.Document.ContentEnd);
                        FileStream fStream = new FileStream(docPath[0], FileMode.OpenOrCreate);
                        range.Load(fStream, DataFormats.Rtf);
                        fStream.Close();
                        this.Title = "Text Editor (" + docPath[0] + ") ";
                        RefreshRecentFilesList(docPath[0]);
                        RefreshRecentFilesListInMenu();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("File could not be opened. Make sure the file is a text file.");
                    }
                }
            }
        }

        private void SetRussian(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Resources = new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/resources/lang.ru-RU.xaml")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("RU: " + ex.Message);
            }
        }

        private void SetEnglish(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Resources = new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/resources/lang.xaml")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("EN: " + ex.Message);
            }
        }

        private string GetLength1(RichTextBox rtb)
        {
            int count_of_symbols = 0;
            var textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            foreach (char c in textRange.Text)
            {
                if (!c.Equals('\n') && (int)c != 13)
                {
                    count_of_symbols++;
                }
            }
            return ""+count_of_symbols;
        }

        private string GetLength2(RichTextBox rtb)
        {
            int count_of_lines = 0;
            var textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            foreach (char c in textRange.Text)
            {
                if (c.Equals('\n'))
                {
                    count_of_lines++;
                }
            }
            return ""+count_of_lines;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            this.status1.Text = GetLength1(this.rtbEditor);
            this.status2.Text = GetLength2(this.rtbEditor);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(this.curFileName);
            fileInfo.Delete();
            fileInfo.Create();
        }
        
    }
}
