using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private List<Student> collection;

        private void buttonGenerateCollection_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOne.Text = "";
                textBoxTwo.Text = "";
                if (textBoxSizeOfCollection.Text == "" || textBoxSizeOfCollection.Text == "0")
                {
                    this.collection = null;
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    int countOfStudent = int.Parse(textBoxSizeOfCollection.Text);
                    collection = new List<Student>(countOfStudent);
                    Student student;
                    for(int i = 0; i < countOfStudent; i++)
                    {
                        student = new Student();
                        collection.Add(student);
                    }
                    foreach(Student s in collection)
                    {
                        textBoxOne.Text += $"{s.name}, {s.course} course, {s.group} group;   ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSortAscending_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTwo.Clear();
                if(collection==null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    collection.Sort();
                    foreach (Student s in collection)
                    {
                        textBoxTwo.Text += $"{s.name}, {s.course} course, {s.group} group;   ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSortDescending_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTwo.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    collection.Sort();
                    collection.Reverse();
                    foreach (Student s in collection)
                    {
                        textBoxTwo.Text += $"{s.name}, {s.course} course, {s.group} group; ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQuery1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTwo.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    var query = collection
                        .Where(p => p.course == 1)
                        .Select(p => p);
                    foreach (var s in query)
                    {
                        textBoxTwo.Text += $"{s.name}, {s.course} course, {s.group} group; ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQuery2_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTwo.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    var query = collection
                        .Where(p => p.course == 4)
                        .Select(p => p);
                    foreach (var s in query)
                    {
                        textBoxTwo.Text += $"{s.name}, {s.course} course, {s.group} group; ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQuery3_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTwo.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    var query = collection
                .Where(p => p.course == 2)
                .Take(2)
                .Select(p => p);
                    foreach (var s in query)
                    {
                        textBoxTwo.Text += $"{s.name}, {s.course} course, {s.group} group; ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}
