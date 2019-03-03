namespace Lab02
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxTypeOfComputer = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.buttonInfoProcessor = new System.Windows.Forms.Button();
            this.buttonInfoGraphicsCard = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelGraphicsCard = new System.Windows.Forms.Label();
            this.labelPurchaseDate = new System.Windows.Forms.Label();
            this.trackBarSizeRAM = new System.Windows.Forms.TrackBar();
            this.trackBarSizeHardDrive = new System.Windows.Forms.TrackBar();
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.comboBoxHardDrive = new System.Windows.Forms.ComboBox();
            this.comboBoxRAM = new System.Windows.Forms.ComboBox();
            this.labelSizeRAM = new System.Windows.Forms.Label();
            this.labelTypeOfRAM = new System.Windows.Forms.Label();
            this.labelSizeHardDrive = new System.Windows.Forms.Label();
            this.labelTypeOfHardDrive = new System.Windows.Forms.Label();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.buttonShowXML = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSort1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSort2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.поЧастотеРаботыПроцессораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBoxTypeOfComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeHardDrive)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeOfComputer
            // 
            this.groupBoxTypeOfComputer.Controls.Add(this.radioButton4);
            this.groupBoxTypeOfComputer.Controls.Add(this.radioButton3);
            this.groupBoxTypeOfComputer.Controls.Add(this.radioButton2);
            this.groupBoxTypeOfComputer.Controls.Add(this.radioButton1);
            this.groupBoxTypeOfComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTypeOfComputer.Location = new System.Drawing.Point(40, 59);
            this.groupBoxTypeOfComputer.Name = "groupBoxTypeOfComputer";
            this.groupBoxTypeOfComputer.Size = new System.Drawing.Size(136, 117);
            this.groupBoxTypeOfComputer.TabIndex = 0;
            this.groupBoxTypeOfComputer.TabStop = false;
            this.groupBoxTypeOfComputer.Text = "Тип компьютера:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(7, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "планшет";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButtonTypeOfComputer_Changed);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "ноутбук";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtonTypeOfComputer_Changed);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "рабочая станция";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtonTypeOfComputer_Changed);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "сервер";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonTypeOfComputer_Changed);
            // 
            // labelProcessor
            // 
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessor.Location = new System.Drawing.Point(48, 188);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(70, 15);
            this.labelProcessor.TabIndex = 1;
            this.labelProcessor.Text = "Процессор";
            // 
            // buttonInfoProcessor
            // 
            this.buttonInfoProcessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoProcessor.Location = new System.Drawing.Point(40, 206);
            this.buttonInfoProcessor.Name = "buttonInfoProcessor";
            this.buttonInfoProcessor.Size = new System.Drawing.Size(136, 36);
            this.buttonInfoProcessor.TabIndex = 2;
            this.buttonInfoProcessor.Text = "Добавить информацию";
            this.buttonInfoProcessor.UseVisualStyleBackColor = true;
            this.buttonInfoProcessor.Click += new System.EventHandler(this.buttonInfoProcessor_Click);
            this.buttonInfoProcessor.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonInfoProcessor.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // buttonInfoGraphicsCard
            // 
            this.buttonInfoGraphicsCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfoGraphicsCard.Location = new System.Drawing.Point(40, 282);
            this.buttonInfoGraphicsCard.Name = "buttonInfoGraphicsCard";
            this.buttonInfoGraphicsCard.Size = new System.Drawing.Size(136, 35);
            this.buttonInfoGraphicsCard.TabIndex = 3;
            this.buttonInfoGraphicsCard.Text = "Добавить информацию";
            this.buttonInfoGraphicsCard.UseVisualStyleBackColor = true;
            this.buttonInfoGraphicsCard.Click += new System.EventHandler(this.buttonInfoGraphicsCard_Click);
            this.buttonInfoGraphicsCard.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonInfoGraphicsCard.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(232, 480);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2019, 2, 18, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelGraphicsCard
            // 
            this.labelGraphicsCard.AutoSize = true;
            this.labelGraphicsCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraphicsCard.Location = new System.Drawing.Point(48, 264);
            this.labelGraphicsCard.Name = "labelGraphicsCard";
            this.labelGraphicsCard.Size = new System.Drawing.Size(77, 15);
            this.labelGraphicsCard.TabIndex = 5;
            this.labelGraphicsCard.Text = "Видеокарта";
            // 
            // labelPurchaseDate
            // 
            this.labelPurchaseDate.AutoSize = true;
            this.labelPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPurchaseDate.Location = new System.Drawing.Point(232, 457);
            this.labelPurchaseDate.Name = "labelPurchaseDate";
            this.labelPurchaseDate.Size = new System.Drawing.Size(127, 15);
            this.labelPurchaseDate.TabIndex = 6;
            this.labelPurchaseDate.Text = "Дата приобретения:";
            // 
            // trackBarSizeRAM
            // 
            this.trackBarSizeRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSizeRAM.LargeChange = 4;
            this.trackBarSizeRAM.Location = new System.Drawing.Point(6, 38);
            this.trackBarSizeRAM.Maximum = 32;
            this.trackBarSizeRAM.Name = "trackBarSizeRAM";
            this.trackBarSizeRAM.Size = new System.Drawing.Size(121, 45);
            this.trackBarSizeRAM.SmallChange = 2;
            this.trackBarSizeRAM.TabIndex = 9;
            this.trackBarSizeRAM.TickFrequency = 4;
            this.trackBarSizeRAM.Value = 16;
            this.trackBarSizeRAM.Scroll += new System.EventHandler(this.trackBarSizeRAM_Scroll);
            // 
            // trackBarSizeHardDrive
            // 
            this.trackBarSizeHardDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSizeHardDrive.LargeChange = 1;
            this.trackBarSizeHardDrive.Location = new System.Drawing.Point(6, 38);
            this.trackBarSizeHardDrive.Maximum = 6;
            this.trackBarSizeHardDrive.Name = "trackBarSizeHardDrive";
            this.trackBarSizeHardDrive.Size = new System.Drawing.Size(122, 45);
            this.trackBarSizeHardDrive.TabIndex = 10;
            this.trackBarSizeHardDrive.Value = 3;
            this.trackBarSizeHardDrive.Scroll += new System.EventHandler(this.trackBarSizeHardDrive_Scroll);
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Location = new System.Drawing.Point(235, 79);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.ReadOnly = true;
            this.textBoxInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInformation.Size = new System.Drawing.Size(254, 367);
            this.textBoxInformation.TabIndex = 11;
            // 
            // comboBoxHardDrive
            // 
            this.comboBoxHardDrive.FormattingEnabled = true;
            this.comboBoxHardDrive.Location = new System.Drawing.Point(6, 103);
            this.comboBoxHardDrive.Name = "comboBoxHardDrive";
            this.comboBoxHardDrive.Size = new System.Drawing.Size(121, 23);
            this.comboBoxHardDrive.TabIndex = 12;
            this.comboBoxHardDrive.SelectedIndexChanged += new System.EventHandler(this.comboBoxHardDrive_SelectedIndexChanged);
            // 
            // comboBoxRAM
            // 
            this.comboBoxRAM.FormattingEnabled = true;
            this.comboBoxRAM.Location = new System.Drawing.Point(6, 103);
            this.comboBoxRAM.Name = "comboBoxRAM";
            this.comboBoxRAM.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRAM.TabIndex = 13;
            this.comboBoxRAM.SelectedIndexChanged += new System.EventHandler(this.comboBoxRAM_SelectedIndexChanged);
            // 
            // labelSizeRAM
            // 
            this.labelSizeRAM.AutoSize = true;
            this.labelSizeRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSizeRAM.Location = new System.Drawing.Point(7, 19);
            this.labelSizeRAM.Name = "labelSizeRAM";
            this.labelSizeRAM.Size = new System.Drawing.Size(49, 13);
            this.labelSizeRAM.TabIndex = 14;
            this.labelSizeRAM.Text = "Размер:";
            // 
            // labelTypeOfRAM
            // 
            this.labelTypeOfRAM.AutoSize = true;
            this.labelTypeOfRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeOfRAM.Location = new System.Drawing.Point(7, 86);
            this.labelTypeOfRAM.Name = "labelTypeOfRAM";
            this.labelTypeOfRAM.Size = new System.Drawing.Size(29, 13);
            this.labelTypeOfRAM.TabIndex = 15;
            this.labelTypeOfRAM.Text = "Тип:";
            // 
            // labelSizeHardDrive
            // 
            this.labelSizeHardDrive.AutoSize = true;
            this.labelSizeHardDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSizeHardDrive.Location = new System.Drawing.Point(8, 19);
            this.labelSizeHardDrive.Name = "labelSizeHardDrive";
            this.labelSizeHardDrive.Size = new System.Drawing.Size(49, 13);
            this.labelSizeHardDrive.TabIndex = 16;
            this.labelSizeHardDrive.Text = "Размер:";
            // 
            // labelTypeOfHardDrive
            // 
            this.labelTypeOfHardDrive.AutoSize = true;
            this.labelTypeOfHardDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeOfHardDrive.Location = new System.Drawing.Point(8, 86);
            this.labelTypeOfHardDrive.Name = "labelTypeOfHardDrive";
            this.labelTypeOfHardDrive.Size = new System.Drawing.Size(26, 13);
            this.labelTypeOfHardDrive.TabIndex = 17;
            this.labelTypeOfHardDrive.Text = "Тип";
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveXML.Location = new System.Drawing.Point(379, 550);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(125, 36);
            this.buttonSaveXML.TabIndex = 18;
            this.buttonSaveXML.Text = "Сохранить информацию в XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click);
            this.buttonSaveXML.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonSaveXML.MouseHover += new System.EventHandler(this.buttonSaveXML_MouseHover);
            // 
            // buttonShowXML
            // 
            this.buttonShowXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowXML.Location = new System.Drawing.Point(379, 592);
            this.buttonShowXML.Name = "buttonShowXML";
            this.buttonShowXML.Size = new System.Drawing.Size(125, 36);
            this.buttonShowXML.TabIndex = 19;
            this.buttonShowXML.Text = "Вывести информацию из XML";
            this.buttonShowXML.UseVisualStyleBackColor = true;
            this.buttonShowXML.Click += new System.EventHandler(this.buttonShowXML_Click);
            this.buttonShowXML.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonShowXML.MouseHover += new System.EventHandler(this.buttonShowXML_MouseHover);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation.Location = new System.Drawing.Point(235, 60);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(88, 15);
            this.labelInformation.TabIndex = 20;
            this.labelInformation.Text = "Информация:";
            // 
            // buttonShow
            // 
            this.buttonShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShow.Location = new System.Drawing.Point(379, 466);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(125, 36);
            this.buttonShow.TabIndex = 21;
            this.buttonShow.Text = "Вывод";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            this.buttonShow.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonShow.MouseHover += new System.EventHandler(this.buttonShow_MouseHover);
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Location = new System.Drawing.Point(379, 508);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 36);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonClear.MouseHover += new System.EventHandler(this.buttonClear_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxHardDrive);
            this.groupBox1.Controls.Add(this.trackBarSizeHardDrive);
            this.groupBox1.Controls.Add(this.labelSizeHardDrive);
            this.groupBox1.Controls.Add(this.labelTypeOfHardDrive);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(40, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 139);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Жесткий диск";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSizeRAM);
            this.groupBox2.Controls.Add(this.comboBoxRAM);
            this.groupBox2.Controls.Add(this.labelTypeOfRAM);
            this.groupBox2.Controls.Add(this.trackBarSizeRAM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(40, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 139);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ОЗУ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSearch,
            this.toolStripMenuItemSort,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemAboutProgramm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemSearch
            // 
            this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
            this.toolStripMenuItemSearch.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemSearch.Text = "&Поиск";
            this.toolStripMenuItemSearch.Click += new System.EventHandler(this.toolStripMenuItemSearch_Click);
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSort1,
            this.ToolStripMenuItemSort2});
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(85, 20);
            this.toolStripMenuItemSort.Text = "&Сортировка";
            // 
            // ToolStripMenuItemSort1
            // 
            this.ToolStripMenuItemSort1.Name = "ToolStripMenuItemSort1";
            this.ToolStripMenuItemSort1.Size = new System.Drawing.Size(248, 22);
            this.ToolStripMenuItemSort1.Text = "По частоте работы процессора";
            this.ToolStripMenuItemSort1.Click += new System.EventHandler(this.ToolStripMenuItemSort1_Click);
            // 
            // ToolStripMenuItemSort2
            // 
            this.ToolStripMenuItemSort2.Name = "ToolStripMenuItemSort2";
            this.ToolStripMenuItemSort2.Size = new System.Drawing.Size(248, 22);
            this.ToolStripMenuItemSort2.Text = "По размеру ОЗУ";
            this.ToolStripMenuItemSort2.Click += new System.EventHandler(this.ToolStripMenuItemSort2_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSaveSearch,
            this.toolStripMenuItemSaveSort});
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItemSave.Text = "&Сохранить";
            // 
            // toolStripMenuItemSaveSearch
            // 
            this.toolStripMenuItemSaveSearch.Name = "toolStripMenuItemSaveSearch";
            this.toolStripMenuItemSaveSearch.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemSaveSearch.Text = "Результат поиска";
            this.toolStripMenuItemSaveSearch.Click += new System.EventHandler(this.toolStripMenuItemSaveSearch_Click);
            // 
            // toolStripMenuItemSaveSort
            // 
            this.toolStripMenuItemSaveSort.Name = "toolStripMenuItemSaveSort";
            this.toolStripMenuItemSaveSort.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemSaveSort.Text = "Результат сортировок";
            this.toolStripMenuItemSaveSort.Click += new System.EventHandler(this.toolStripMenuItemSaveSort_Click);
            // 
            // toolStripMenuItemAboutProgramm
            // 
            this.toolStripMenuItemAboutProgramm.Name = "toolStripMenuItemAboutProgramm";
            this.toolStripMenuItemAboutProgramm.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItemAboutProgramm.Text = "&О программе";
            this.toolStripMenuItemAboutProgramm.Click += new System.EventHandler(this.toolStripMenuItemAboutProgramm_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 629);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(531, 22);
            this.statusStrip.TabIndex = 26;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoSize = false;
            this.toolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(400, 17);
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.AutoSize = false;
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(531, 576);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 27);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(531, 601);
            this.toolStripContainer1.TabIndex = 28;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSearch,
            this.toolStripButtonSort,
            this.toolStripButtonSave,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(501, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 576);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonSearch.Text = "поиск";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripMenuItemSearch_Click);
            // 
            // toolStripButtonSort
            // 
            this.toolStripButtonSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЧастотеРаботыПроцессораToolStripMenuItem,
            this.поToolStripMenuItem});
            this.toolStripButtonSort.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSort.Image")));
            this.toolStripButtonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSort.Name = "toolStripButtonSort";
            this.toolStripButtonSort.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonSort.Text = "сортировка";
            // 
            // поЧастотеРаботыПроцессораToolStripMenuItem
            // 
            this.поЧастотеРаботыПроцессораToolStripMenuItem.Name = "поЧастотеРаботыПроцессораToolStripMenuItem";
            this.поЧастотеРаботыПроцессораToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.поЧастотеРаботыПроцессораToolStripMenuItem.Text = "По частоте работы процессора";
            this.поЧастотеРаботыПроцессораToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemSort1_Click);
            // 
            // поToolStripMenuItem
            // 
            this.поToolStripMenuItem.Name = "поToolStripMenuItem";
            this.поToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.поToolStripMenuItem.Text = "По размеру ОЗУ";
            this.поToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemSort2_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonSave.Text = "сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.buttonSaveXML_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonDelete.Text = "очистить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 651);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonShowXML);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.textBoxInformation);
            this.Controls.Add(this.labelPurchaseDate);
            this.Controls.Add(this.labelGraphicsCard);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonInfoGraphicsCard);
            this.Controls.Add(this.buttonInfoProcessor);
            this.Controls.Add(this.labelProcessor);
            this.Controls.Add(this.groupBoxTypeOfComputer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компьютер";
            this.groupBoxTypeOfComputer.ResumeLayout(false);
            this.groupBoxTypeOfComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeHardDrive)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTypeOfComputer;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.Button buttonInfoProcessor;
        private System.Windows.Forms.Button buttonInfoGraphicsCard;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelGraphicsCard;
        private System.Windows.Forms.Label labelPurchaseDate;
        private System.Windows.Forms.TrackBar trackBarSizeRAM;
        private System.Windows.Forms.TrackBar trackBarSizeHardDrive;
        private System.Windows.Forms.TextBox textBoxInformation;
        private System.Windows.Forms.ComboBox comboBoxHardDrive;
        private System.Windows.Forms.ComboBox comboBoxRAM;
        private System.Windows.Forms.Label labelSizeRAM;
        private System.Windows.Forms.Label labelTypeOfRAM;
        private System.Windows.Forms.Label labelSizeHardDrive;
        private System.Windows.Forms.Label labelTypeOfHardDrive;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.Button buttonShowXML;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAboutProgramm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveSort;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSort1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSort2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSort;
        private System.Windows.Forms.ToolStripMenuItem поЧастотеРаботыПроцессораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timer;
    }
}

