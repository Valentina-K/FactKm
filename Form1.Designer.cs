namespace Пробег_по_депо
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.lblReportHalf = new System.Windows.Forms.Label();
            this.lblReportMonth = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelTypeCars = new System.Windows.Forms.Button();
            this.lsbTypeCars = new System.Windows.Forms.ListBox();
            this.txtTypeCar = new System.Windows.Forms.TextBox();
            this.lblNameType = new System.Windows.Forms.Label();
            this.btnAddTypeCars = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPE = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbRepairOrTypePe = new System.Windows.Forms.ComboBox();
            this.cmbPE = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.cmbDepo = new System.Windows.Forms.ComboBox();
            this.tabPageTyre = new System.Windows.Forms.TabPage();
            this.lblMoving = new System.Windows.Forms.Label();
            this.lblBinding = new System.Windows.Forms.Label();
            this.lblReportRace = new System.Windows.Forms.Label();
            this.grbTypeTyres = new System.Windows.Forms.GroupBox();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combTypeTeres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBTypeTyres = new System.Windows.Forms.ListBox();
            this.grbTyre = new System.Windows.Forms.GroupBox();
            this.lblnameTyre = new System.Windows.Forms.Label();
            this.txtTyre = new System.Windows.Forms.TextBox();
            this.txtBindTyre = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnNoTyres = new System.Windows.Forms.Button();
            this.btnYesTyres = new System.Windows.Forms.Button();
            this.cmbBind = new System.Windows.Forms.ComboBox();
            this.cmbTypeTyres = new System.Windows.Forms.ComboBox();
            this.cmbTyres = new System.Windows.Forms.ComboBox();
            this.btnReportBar = new System.Windows.Forms.Button();
            this.btnMoveBar = new System.Windows.Forms.Button();
            this.btnDeleteBar = new System.Windows.Forms.Button();
            this.btnEnterBar = new System.Windows.Forms.Button();
            this.btnTypeBar = new System.Windows.Forms.Button();
            this.cmbDepoBars = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageService.SuspendLayout();
            this.tabPageCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageTyre.SuspendLayout();
            this.grbTypeTyres.SuspendLayout();
            this.grbTyre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1145, 11);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(947, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageService);
            this.tabControl1.Controls.Add(this.tabPageCars);
            this.tabControl1.Controls.Add(this.tabPageTyre);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(4, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 572);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageService
            // 
            this.tabPageService.BackgroundImage = global::Пробег_по_депо.Properties.Resources.complex_lech_form_8;
            this.tabPageService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageService.Controls.Add(this.lblWarning);
            this.tabPageService.Controls.Add(this.lblUpdate);
            this.tabPageService.Controls.Add(this.label2);
            this.tabPageService.Controls.Add(this.cmbYear);
            this.tabPageService.Controls.Add(this.cmbMonth);
            this.tabPageService.Controls.Add(this.lblWorker);
            this.tabPageService.Controls.Add(this.btnLoadData);
            this.tabPageService.Location = new System.Drawing.Point(4, 25);
            this.tabPageService.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageService.Size = new System.Drawing.Size(1192, 543);
            this.tabPageService.TabIndex = 2;
            this.tabPageService.Text = "Обслуживание";
            this.tabPageService.UseVisualStyleBackColor = true;
            this.tabPageService.Enter += new System.EventHandler(this.tabPageService_Enter);
            this.tabPageService.Leave += new System.EventHandler(this.tabPageService_Leave);
            // 
            // lblWarning
            // 
            this.lblWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarning.Image = global::Пробег_по_депо.Properties.Resources.Предупреждение;
            this.lblWarning.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWarning.Location = new System.Drawing.Point(947, 4);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(238, 125);
            this.lblWarning.TabIndex = 6;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdate.Location = new System.Drawing.Point(815, 21);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(0, 18);
            this.lblUpdate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Рабочие таблицы обновлены данными за ";
            // 
            // cmbYear
            // 
            this.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbYear.Location = new System.Drawing.Point(299, 18);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(82, 24);
            this.cmbYear.TabIndex = 3;
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август",
            "сентябрь",
            "октябрь",
            "ноябрь",
            "декабрь"});
            this.cmbMonth.Location = new System.Drawing.Point(172, 18);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(112, 24);
            this.cmbMonth.TabIndex = 2;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(39, 26);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(119, 16);
            this.lblWorker.TabIndex = 1;
            this.lblWorker.Text = "Рабочий период:";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(42, 68);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(163, 27);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Подгрузить данные";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // tabPageCars
            // 
            this.tabPageCars.BackgroundImage = global::Пробег_по_депо.Properties.Resources.Троллейбус;
            this.tabPageCars.Controls.Add(this.dataGV);
            this.tabPageCars.Controls.Add(this.lblReportHalf);
            this.tabPageCars.Controls.Add(this.lblReportMonth);
            this.tabPageCars.Controls.Add(this.groupBox2);
            this.tabPageCars.Controls.Add(this.groupBox1);
            this.tabPageCars.Controls.Add(this.btnReport);
            this.tabPageCars.Controls.Add(this.btnRepair);
            this.tabPageCars.Controls.Add(this.btnDelete);
            this.tabPageCars.Controls.Add(this.btnEnter);
            this.tabPageCars.Controls.Add(this.btnType);
            this.tabPageCars.Controls.Add(this.cmbDepo);
            this.tabPageCars.Location = new System.Drawing.Point(4, 25);
            this.tabPageCars.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCars.Size = new System.Drawing.Size(1192, 543);
            this.tabPageCars.TabIndex = 0;
            this.tabPageCars.Text = "Машины";
            this.tabPageCars.UseVisualStyleBackColor = true;
            this.tabPageCars.Leave += new System.EventHandler(this.tabPageCars_Leave);
            // 
            // dataGV
            // 
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(7, 215);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(1178, 321);
            this.dataGV.TabIndex = 14;
            // 
            // lblReportHalf
            // 
            this.lblReportHalf.AutoSize = true;
            this.lblReportHalf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReportHalf.Location = new System.Drawing.Point(131, 196);
            this.lblReportHalf.Name = "lblReportHalf";
            this.lblReportHalf.Size = new System.Drawing.Size(104, 16);
            this.lblReportHalf.TabIndex = 13;
            this.lblReportHalf.Text = "- за полугодие";
            this.lblReportHalf.Click += new System.EventHandler(this.lblReportHalf_Click);
            // 
            // lblReportMonth
            // 
            this.lblReportMonth.AutoSize = true;
            this.lblReportMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReportMonth.Location = new System.Drawing.Point(131, 170);
            this.lblReportMonth.Name = "lblReportMonth";
            this.lblReportMonth.Size = new System.Drawing.Size(73, 16);
            this.lblReportMonth.TabIndex = 12;
            this.lblReportMonth.Text = "- за месяц";
            this.lblReportMonth.Click += new System.EventHandler(this.lblReportMonth_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelTypeCars);
            this.groupBox2.Controls.Add(this.lsbTypeCars);
            this.groupBox2.Controls.Add(this.txtTypeCar);
            this.groupBox2.Controls.Add(this.lblNameType);
            this.groupBox2.Controls.Add(this.btnAddTypeCars);
            this.groupBox2.Location = new System.Drawing.Point(258, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 191);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Типы машин";
            // 
            // btnDelTypeCars
            // 
            this.btnDelTypeCars.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTypeCars.Image")));
            this.btnDelTypeCars.Location = new System.Drawing.Point(445, 22);
            this.btnDelTypeCars.Name = "btnDelTypeCars";
            this.btnDelTypeCars.Size = new System.Drawing.Size(30, 30);
            this.btnDelTypeCars.TabIndex = 12;
            this.btnDelTypeCars.UseVisualStyleBackColor = true;
            this.btnDelTypeCars.Click += new System.EventHandler(this.btnDelTypeCars_Click);
            // 
            // lsbTypeCars
            // 
            this.lsbTypeCars.FormattingEnabled = true;
            this.lsbTypeCars.ItemHeight = 16;
            this.lsbTypeCars.Location = new System.Drawing.Point(7, 22);
            this.lsbTypeCars.Name = "lsbTypeCars";
            this.lsbTypeCars.Size = new System.Drawing.Size(142, 164);
            this.lsbTypeCars.TabIndex = 11;
            this.lsbTypeCars.SelectedIndexChanged += new System.EventHandler(this.lsbTypeCars_SelectedIndexChanged);
            // 
            // txtTypeCar
            // 
            this.txtTypeCar.Location = new System.Drawing.Point(190, 41);
            this.txtTypeCar.Name = "txtTypeCar";
            this.txtTypeCar.Size = new System.Drawing.Size(132, 22);
            this.txtTypeCar.TabIndex = 9;
            this.txtTypeCar.TextChanged += new System.EventHandler(this.txtTypeCar_TextChanged);
            // 
            // lblNameType
            // 
            this.lblNameType.AutoSize = true;
            this.lblNameType.Location = new System.Drawing.Point(200, 22);
            this.lblNameType.Name = "lblNameType";
            this.lblNameType.Size = new System.Drawing.Size(107, 16);
            this.lblNameType.TabIndex = 8;
            this.lblNameType.Text = "Наименование";
            // 
            // btnAddTypeCars
            // 
            this.btnAddTypeCars.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTypeCars.Image")));
            this.btnAddTypeCars.Location = new System.Drawing.Point(409, 22);
            this.btnAddTypeCars.Name = "btnAddTypeCars";
            this.btnAddTypeCars.Size = new System.Drawing.Size(30, 30);
            this.btnAddTypeCars.TabIndex = 10;
            this.btnAddTypeCars.UseVisualStyleBackColor = true;
            this.btnAddTypeCars.Click += new System.EventHandler(this.btnAddTypeCars_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPE);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnYes);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.cmbRepairOrTypePe);
            this.groupBox1.Controls.Add(this.cmbPE);
            this.groupBox1.Location = new System.Drawing.Point(258, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtPE
            // 
            this.txtPE.Location = new System.Drawing.Point(17, 30);
            this.txtPE.Name = "txtPE";
            this.txtPE.Size = new System.Drawing.Size(121, 22);
            this.txtPE.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Location = new System.Drawing.Point(400, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.GreenYellow;
            this.btnYes.Location = new System.Drawing.Point(263, 96);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(117, 26);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Подтвердить";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(300, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // cmbRepairOrTypePe
            // 
            this.cmbRepairOrTypePe.FormattingEnabled = true;
            this.cmbRepairOrTypePe.Items.AddRange(new object[] {
            "ТО-2",
            "Капитальный",
            "Средний"});
            this.cmbRepairOrTypePe.Location = new System.Drawing.Point(159, 28);
            this.cmbRepairOrTypePe.Name = "cmbRepairOrTypePe";
            this.cmbRepairOrTypePe.Size = new System.Drawing.Size(121, 24);
            this.cmbRepairOrTypePe.TabIndex = 1;
            // 
            // cmbPE
            // 
            this.cmbPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPE.FormattingEnabled = true;
            this.cmbPE.Location = new System.Drawing.Point(17, 30);
            this.cmbPE.Name = "cmbPE";
            this.cmbPE.Size = new System.Drawing.Size(121, 24);
            this.cmbPE.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(8, 167);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(117, 23);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Отчеты";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRepair
            // 
            this.btnRepair.Location = new System.Drawing.Point(8, 138);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(117, 23);
            this.btnRepair.TabIndex = 4;
            this.btnRepair.Text = "Ремонты";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Списание";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(8, 80);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(117, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Ввод";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(8, 51);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(117, 23);
            this.btnType.TabIndex = 1;
            this.btnType.Text = "Типы машин";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // cmbDepo
            // 
            this.cmbDepo.FormattingEnabled = true;
            this.cmbDepo.Items.AddRange(new object[] {
            "Троллейбусное депо №2",
            "Троллейбусное депо №3"});
            this.cmbDepo.Location = new System.Drawing.Point(7, 20);
            this.cmbDepo.Name = "cmbDepo";
            this.cmbDepo.Size = new System.Drawing.Size(211, 24);
            this.cmbDepo.TabIndex = 0;
            this.cmbDepo.SelectedIndexChanged += new System.EventHandler(this.cmbDepo_SelectedIndexChanged);
            // 
            // tabPageTyre
            // 
            this.tabPageTyre.BackgroundImage = global::Пробег_по_депо.Properties.Resources.Колеса;
            this.tabPageTyre.Controls.Add(this.lblMoving);
            this.tabPageTyre.Controls.Add(this.lblBinding);
            this.tabPageTyre.Controls.Add(this.lblReportRace);
            this.tabPageTyre.Controls.Add(this.grbTypeTyres);
            this.tabPageTyre.Controls.Add(this.grbTyre);
            this.tabPageTyre.Controls.Add(this.btnReportBar);
            this.tabPageTyre.Controls.Add(this.btnMoveBar);
            this.tabPageTyre.Controls.Add(this.btnDeleteBar);
            this.tabPageTyre.Controls.Add(this.btnEnterBar);
            this.tabPageTyre.Controls.Add(this.btnTypeBar);
            this.tabPageTyre.Controls.Add(this.cmbDepoBars);
            this.tabPageTyre.Location = new System.Drawing.Point(4, 25);
            this.tabPageTyre.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTyre.Name = "tabPageTyre";
            this.tabPageTyre.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTyre.Size = new System.Drawing.Size(1192, 543);
            this.tabPageTyre.TabIndex = 1;
            this.tabPageTyre.Text = "Шины";
            this.tabPageTyre.UseVisualStyleBackColor = true;
            this.tabPageTyre.Leave += new System.EventHandler(this.tabPageTyre_Leave);
            // 
            // lblMoving
            // 
            this.lblMoving.AutoSize = true;
            this.lblMoving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMoving.Location = new System.Drawing.Point(159, 219);
            this.lblMoving.Name = "lblMoving";
            this.lblMoving.Size = new System.Drawing.Size(107, 16);
            this.lblMoving.TabIndex = 16;
            this.lblMoving.Text = "- Перемещение";
            this.lblMoving.Click += new System.EventHandler(this.lblMoving_Click);
            // 
            // lblBinding
            // 
            this.lblBinding.AutoSize = true;
            this.lblBinding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBinding.Location = new System.Drawing.Point(159, 193);
            this.lblBinding.Name = "lblBinding";
            this.lblBinding.Size = new System.Drawing.Size(103, 16);
            this.lblBinding.TabIndex = 15;
            this.lblBinding.Text = "- Закрепление";
            this.lblBinding.Click += new System.EventHandler(this.lblBinding_Click);
            // 
            // lblReportRace
            // 
            this.lblReportRace.AutoSize = true;
            this.lblReportRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReportRace.Location = new System.Drawing.Point(159, 165);
            this.lblReportRace.Name = "lblReportRace";
            this.lblReportRace.Size = new System.Drawing.Size(63, 16);
            this.lblReportRace.TabIndex = 14;
            this.lblReportRace.Text = "- Пробег";
            this.lblReportRace.Click += new System.EventHandler(this.lblReportRace_Click);
            // 
            // grbTypeTyres
            // 
            this.grbTypeTyres.Controls.Add(this.btnUpd);
            this.grbTypeTyres.Controls.Add(this.btnMinus);
            this.grbTypeTyres.Controls.Add(this.btnPlus);
            this.grbTypeTyres.Controls.Add(this.textBox2);
            this.grbTypeTyres.Controls.Add(this.label5);
            this.grbTypeTyres.Controls.Add(this.textBox1);
            this.grbTypeTyres.Controls.Add(this.label3);
            this.grbTypeTyres.Controls.Add(this.combTypeTeres);
            this.grbTypeTyres.Controls.Add(this.label1);
            this.grbTypeTyres.Controls.Add(this.listBTypeTyres);
            this.grbTypeTyres.Location = new System.Drawing.Point(250, 219);
            this.grbTypeTyres.Name = "grbTypeTyres";
            this.grbTypeTyres.Size = new System.Drawing.Size(495, 291);
            this.grbTypeTyres.TabIndex = 13;
            this.grbTypeTyres.TabStop = false;
            this.grbTypeTyres.Text = "Типы шин";
            // 
            // btnUpd
            // 
            this.btnUpd.Image = ((System.Drawing.Image)(resources.GetObject("btnUpd.Image")));
            this.btnUpd.Location = new System.Drawing.Point(386, 16);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(30, 30);
            this.btnUpd.TabIndex = 10;
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Image = global::Пробег_по_депо.Properties.Resources.erase;
            this.btnMinus.Location = new System.Drawing.Point(456, 16);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Image = global::Пробег_по_депо.Properties.Resources.add;
            this.btnPlus.Location = new System.Drawing.Point(422, 16);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 30);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Норма пробега";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 48);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Наименование";
            // 
            // combTypeTeres
            // 
            this.combTypeTeres.FormattingEnabled = true;
            this.combTypeTeres.Location = new System.Drawing.Point(236, 53);
            this.combTypeTeres.Name = "combTypeTeres";
            this.combTypeTeres.Size = new System.Drawing.Size(95, 24);
            this.combTypeTeres.TabIndex = 2;
            this.combTypeTeres.SelectionChangeCommitted += new System.EventHandler(this.combTypeTeres_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Доступен вид";
            // 
            // listBTypeTyres
            // 
            this.listBTypeTyres.FormattingEnabled = true;
            this.listBTypeTyres.ItemHeight = 16;
            this.listBTypeTyres.Location = new System.Drawing.Point(7, 22);
            this.listBTypeTyres.Name = "listBTypeTyres";
            this.listBTypeTyres.Size = new System.Drawing.Size(219, 260);
            this.listBTypeTyres.TabIndex = 0;
            this.listBTypeTyres.SelectedIndexChanged += new System.EventHandler(this.listBTypeTyres_SelectedIndexChanged);
            this.listBTypeTyres.DoubleClick += new System.EventHandler(this.listBTypeTyres_DoubleClick);
            // 
            // grbTyre
            // 
            this.grbTyre.Controls.Add(this.lblnameTyre);
            this.grbTyre.Controls.Add(this.txtTyre);
            this.grbTyre.Controls.Add(this.txtBindTyre);
            this.grbTyre.Controls.Add(this.dateTimePicker3);
            this.grbTyre.Controls.Add(this.btnNoTyres);
            this.grbTyre.Controls.Add(this.btnYesTyres);
            this.grbTyre.Controls.Add(this.cmbBind);
            this.grbTyre.Controls.Add(this.cmbTypeTyres);
            this.grbTyre.Controls.Add(this.cmbTyres);
            this.grbTyre.Location = new System.Drawing.Point(250, 40);
            this.grbTyre.Name = "grbTyre";
            this.grbTyre.Size = new System.Drawing.Size(495, 152);
            this.grbTyre.TabIndex = 12;
            this.grbTyre.TabStop = false;
            this.grbTyre.Text = "groupBox3";
            // 
            // lblnameTyre
            // 
            this.lblnameTyre.AutoSize = true;
            this.lblnameTyre.Location = new System.Drawing.Point(10, 110);
            this.lblnameTyre.Name = "lblnameTyre";
            this.lblnameTyre.Size = new System.Drawing.Size(0, 16);
            this.lblnameTyre.TabIndex = 8;
            // 
            // txtTyre
            // 
            this.txtTyre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTyre.Location = new System.Drawing.Point(7, 26);
            this.txtTyre.Name = "txtTyre";
            this.txtTyre.Size = new System.Drawing.Size(121, 24);
            this.txtTyre.TabIndex = 7;
            // 
            // txtBindTyre
            // 
            this.txtBindTyre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBindTyre.Location = new System.Drawing.Point(144, 28);
            this.txtBindTyre.Name = "txtBindTyre";
            this.txtBindTyre.Size = new System.Drawing.Size(121, 24);
            this.txtBindTyre.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(284, 27);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // btnNoTyres
            // 
            this.btnNoTyres.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNoTyres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNoTyres.Location = new System.Drawing.Point(405, 109);
            this.btnNoTyres.Name = "btnNoTyres";
            this.btnNoTyres.Size = new System.Drawing.Size(79, 30);
            this.btnNoTyres.TabIndex = 4;
            this.btnNoTyres.Text = "Отмена";
            this.btnNoTyres.UseVisualStyleBackColor = false;
            this.btnNoTyres.Click += new System.EventHandler(this.btnNoTyres_Click);
            // 
            // btnYesTyres
            // 
            this.btnYesTyres.BackColor = System.Drawing.Color.GreenYellow;
            this.btnYesTyres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYesTyres.Location = new System.Drawing.Point(284, 109);
            this.btnYesTyres.Name = "btnYesTyres";
            this.btnYesTyres.Size = new System.Drawing.Size(112, 30);
            this.btnYesTyres.TabIndex = 3;
            this.btnYesTyres.Text = "Подтвердить";
            this.btnYesTyres.UseVisualStyleBackColor = false;
            this.btnYesTyres.Click += new System.EventHandler(this.btnYesTyres_Click);
            // 
            // cmbBind
            // 
            this.cmbBind.FormattingEnabled = true;
            this.cmbBind.Location = new System.Drawing.Point(144, 72);
            this.cmbBind.Name = "cmbBind";
            this.cmbBind.Size = new System.Drawing.Size(121, 24);
            this.cmbBind.TabIndex = 2;
            // 
            // cmbTypeTyres
            // 
            this.cmbTypeTyres.FormattingEnabled = true;
            this.cmbTypeTyres.Location = new System.Drawing.Point(144, 26);
            this.cmbTypeTyres.Name = "cmbTypeTyres";
            this.cmbTypeTyres.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeTyres.TabIndex = 1;
            this.cmbTypeTyres.SelectionChangeCommitted += new System.EventHandler(this.cmbTypeTyres_SelectionChangeCommitted);
            // 
            // cmbTyres
            // 
            this.cmbTyres.FormattingEnabled = true;
            this.cmbTyres.Location = new System.Drawing.Point(6, 25);
            this.cmbTyres.Name = "cmbTyres";
            this.cmbTyres.Size = new System.Drawing.Size(121, 24);
            this.cmbTyres.TabIndex = 0;
            this.cmbTyres.SelectionChangeCommitted += new System.EventHandler(this.cmbTyres_SelectionChangeCommitted);
            // 
            // btnReportBar
            // 
            this.btnReportBar.Location = new System.Drawing.Point(7, 156);
            this.btnReportBar.Name = "btnReportBar";
            this.btnReportBar.Size = new System.Drawing.Size(117, 23);
            this.btnReportBar.TabIndex = 11;
            this.btnReportBar.Text = "Отчеты";
            this.btnReportBar.UseVisualStyleBackColor = true;
            this.btnReportBar.Click += new System.EventHandler(this.btnReportBar_Click);
            // 
            // btnMoveBar
            // 
            this.btnMoveBar.Location = new System.Drawing.Point(7, 127);
            this.btnMoveBar.Name = "btnMoveBar";
            this.btnMoveBar.Size = new System.Drawing.Size(117, 23);
            this.btnMoveBar.TabIndex = 10;
            this.btnMoveBar.Text = "Перемещения";
            this.btnMoveBar.UseVisualStyleBackColor = true;
            this.btnMoveBar.Click += new System.EventHandler(this.btnMoveBar_Click);
            // 
            // btnDeleteBar
            // 
            this.btnDeleteBar.Location = new System.Drawing.Point(7, 98);
            this.btnDeleteBar.Name = "btnDeleteBar";
            this.btnDeleteBar.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteBar.TabIndex = 9;
            this.btnDeleteBar.Text = "Списание";
            this.btnDeleteBar.UseVisualStyleBackColor = true;
            this.btnDeleteBar.Click += new System.EventHandler(this.btnDeleteBar_Click);
            // 
            // btnEnterBar
            // 
            this.btnEnterBar.Location = new System.Drawing.Point(7, 69);
            this.btnEnterBar.Name = "btnEnterBar";
            this.btnEnterBar.Size = new System.Drawing.Size(117, 23);
            this.btnEnterBar.TabIndex = 8;
            this.btnEnterBar.Text = "Ввод";
            this.btnEnterBar.UseVisualStyleBackColor = true;
            this.btnEnterBar.Click += new System.EventHandler(this.btnEnterBar_Click);
            // 
            // btnTypeBar
            // 
            this.btnTypeBar.Location = new System.Drawing.Point(7, 40);
            this.btnTypeBar.Name = "btnTypeBar";
            this.btnTypeBar.Size = new System.Drawing.Size(117, 23);
            this.btnTypeBar.TabIndex = 7;
            this.btnTypeBar.Text = "Типы шин";
            this.btnTypeBar.UseVisualStyleBackColor = true;
            this.btnTypeBar.Click += new System.EventHandler(this.btnTypeBar_Click);
            // 
            // cmbDepoBars
            // 
            this.cmbDepoBars.FormattingEnabled = true;
            this.cmbDepoBars.Items.AddRange(new object[] {
            "Троллейбусное депо №2",
            "Троллейбусное депо №3"});
            this.cmbDepoBars.Location = new System.Drawing.Point(6, 9);
            this.cmbDepoBars.Name = "cmbDepoBars";
            this.cmbDepoBars.Size = new System.Drawing.Size(211, 24);
            this.cmbDepoBars.TabIndex = 6;
            this.cmbDepoBars.SelectedIndexChanged += new System.EventHandler(this.cmbDepoBars_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 622);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пробег по депо";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageService.ResumeLayout(false);
            this.tabPageService.PerformLayout();
            this.tabPageCars.ResumeLayout(false);
            this.tabPageCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageTyre.ResumeLayout(false);
            this.tabPageTyre.PerformLayout();
            this.grbTypeTyres.ResumeLayout(false);
            this.grbTypeTyres.PerformLayout();
            this.grbTyre.ResumeLayout(false);
            this.grbTyre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCars;
        private System.Windows.Forms.TabPage tabPageTyre;
        private System.Windows.Forms.TabPage tabPageService;
        private System.Windows.Forms.ComboBox cmbDepo;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbRepairOrTypePe;
        private System.Windows.Forms.ComboBox cmbPE;
        private System.Windows.Forms.TextBox txtPE;
        private System.Windows.Forms.Button btnAddTypeCars;
        private System.Windows.Forms.TextBox txtTypeCar;
        private System.Windows.Forms.Label lblNameType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbTypeCars;
        private System.Windows.Forms.Button btnDelTypeCars;
        private System.Windows.Forms.Button btnReportBar;
        private System.Windows.Forms.Button btnMoveBar;
        private System.Windows.Forms.Button btnDeleteBar;
        private System.Windows.Forms.Button btnEnterBar;
        private System.Windows.Forms.Button btnTypeBar;
        private System.Windows.Forms.ComboBox cmbDepoBars;
        private System.Windows.Forms.GroupBox grbTyre;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbMonth;
        internal System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblReportHalf;
        private System.Windows.Forms.Label lblReportMonth;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnNoTyres;
        private System.Windows.Forms.Button btnYesTyres;
        private System.Windows.Forms.ComboBox cmbBind;
        private System.Windows.Forms.ComboBox cmbTypeTyres;
        private System.Windows.Forms.ComboBox cmbTyres;
        private System.Windows.Forms.TextBox txtTyre;
        private System.Windows.Forms.TextBox txtBindTyre;
        private System.Windows.Forms.GroupBox grbTypeTyres;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combTypeTeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBTypeTyres;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblMoving;
        private System.Windows.Forms.Label lblBinding;
        private System.Windows.Forms.Label lblReportRace;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Label lblnameTyre;
    }
}

