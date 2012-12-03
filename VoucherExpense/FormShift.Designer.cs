﻿namespace VoucherExpense
{
    partial class FormShift
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShift));
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.columnShiftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTableMonth = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cMonthForComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Locked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KeyinID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEDataSet = new VoucherExpense.VEDataSet();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftTableTableAdapter = new VoucherExpense.VEDataSetTableAdapters.ShiftTableTableAdapter();
            this.shiftTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.儲存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.shiftDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftDetailTableAdapter = new VoucherExpense.VEDataSetTableAdapters.ShiftDetailTableAdapter();
            this.operatorTableAdapter = new VoucherExpense.VEDataSetTableAdapters.OperatorTableAdapter();
            this.btnModify = new System.Windows.Forms.Button();
            this.shiftTableShiftDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRTableAdapter = new VoucherExpense.VEDataSetTableAdapters.HRTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSaveCodeConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.dgvConfigShiftCode = new System.Windows.Forms.DataGridView();
            this.columnCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cCodeForComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.columnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHour = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cHourForComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cShiftCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMonthForComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTableBindingNavigator)).BeginInit();
            this.shiftTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTableShiftDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigShiftCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCodeForComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHourForComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cShiftCodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AllowUserToDeleteRows = false;
            this.dgvShift.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            this.dgvShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvShift.AutoGenerateColumns = false;
            this.dgvShift.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnShiftID,
            this.tableNameDataGridViewTextBoxColumn,
            this.ColumnTableMonth,
            this.Locked,
            this.KeyinID,
            this.lastUpdatedDataGridViewTextBoxColumn});
            this.dgvShift.DataSource = this.shiftTableBindingSource;
            this.dgvShift.Location = new System.Drawing.Point(0, 33);
            this.dgvShift.MultiSelect = false;
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.RowHeadersVisible = false;
            this.dgvShift.RowTemplate.Height = 24;
            this.dgvShift.Size = new System.Drawing.Size(458, 642);
            this.dgvShift.TabIndex = 56;
            this.dgvShift.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvShift_DataError);
            // 
            // columnShiftID
            // 
            this.columnShiftID.DataPropertyName = "ShiftID";
            this.columnShiftID.HeaderText = "ShiftID";
            this.columnShiftID.Name = "columnShiftID";
            this.columnShiftID.Visible = false;
            // 
            // tableNameDataGridViewTextBoxColumn
            // 
            this.tableNameDataGridViewTextBoxColumn.DataPropertyName = "TableName";
            this.tableNameDataGridViewTextBoxColumn.HeaderText = "名稱";
            this.tableNameDataGridViewTextBoxColumn.Name = "tableNameDataGridViewTextBoxColumn";
            this.tableNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // ColumnTableMonth
            // 
            this.ColumnTableMonth.DataPropertyName = "TableMonth";
            this.ColumnTableMonth.DataSource = this.cMonthForComboBindingSource;
            this.ColumnTableMonth.DisplayMember = "Name";
            this.ColumnTableMonth.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ColumnTableMonth.HeaderText = "月份";
            this.ColumnTableMonth.Name = "ColumnTableMonth";
            this.ColumnTableMonth.ValueMember = "Index";
            this.ColumnTableMonth.Width = 64;
            // 
            // cMonthForComboBindingSource
            // 
            this.cMonthForComboBindingSource.DataSource = typeof(VoucherExpense.FormShift.CMonthForCombo);
            // 
            // Locked
            // 
            this.Locked.DataPropertyName = "Locked";
            this.Locked.HeaderText = "核";
            this.Locked.Name = "Locked";
            this.Locked.Width = 32;
            // 
            // KeyinID
            // 
            this.KeyinID.DataPropertyName = "KeyinID";
            this.KeyinID.DataSource = this.operatorBindingSource;
            this.KeyinID.DisplayMember = "Name";
            this.KeyinID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.KeyinID.HeaderText = "制表";
            this.KeyinID.Name = "KeyinID";
            this.KeyinID.ReadOnly = true;
            this.KeyinID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KeyinID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.KeyinID.ValueMember = "OperatorID";
            this.KeyinID.Width = 80;
            // 
            // operatorBindingSource
            // 
            this.operatorBindingSource.DataMember = "Operator";
            this.operatorBindingSource.DataSource = this.vEDataSet;
            // 
            // vEDataSet
            // 
            this.vEDataSet.DataSetName = "VEDataSet";
            this.vEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            dataGridViewCellStyle6.Format = "MM-dd HH:mm";
            this.lastUpdatedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "更新";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftTableBindingSource
            // 
            this.shiftTableBindingSource.DataMember = "ShiftTable";
            this.shiftTableBindingSource.DataSource = this.vEDataSet;
            // 
            // shiftTableTableAdapter
            // 
            this.shiftTableTableAdapter.ClearBeforeFill = true;
            // 
            // shiftTableBindingNavigator
            // 
            this.shiftTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shiftTableBindingNavigator.BindingSource = this.shiftTableBindingSource;
            this.shiftTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shiftTableBindingNavigator.CountItemFormat = "{0}";
            this.shiftTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shiftTableBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.shiftTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.儲存SToolStripButton,
            this.toolStripSeparator1,
            this.bindingNavigatorCountItem});
            this.shiftTableBindingNavigator.Location = new System.Drawing.Point(0, 4);
            this.shiftTableBindingNavigator.MoveFirstItem = null;
            this.shiftTableBindingNavigator.MoveLastItem = null;
            this.shiftTableBindingNavigator.MoveNextItem = null;
            this.shiftTableBindingNavigator.MovePreviousItem = null;
            this.shiftTableBindingNavigator.Name = "shiftTableBindingNavigator";
            this.shiftTableBindingNavigator.PositionItem = null;
            this.shiftTableBindingNavigator.Size = new System.Drawing.Size(111, 25);
            this.shiftTableBindingNavigator.TabIndex = 58;
            this.shiftTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorCountItem.Text = "{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // 儲存SToolStripButton
            // 
            this.儲存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.儲存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripButton.Image")));
            this.儲存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripButton.Name = "儲存SToolStripButton";
            this.儲存SToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.儲存SToolStripButton.Text = "儲存(&S)";
            this.儲存SToolStripButton.Click += new System.EventHandler(this.儲存SToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // shiftDetailBindingSource
            // 
            this.shiftDetailBindingSource.DataMember = "ShiftTableShiftDetail";
            // 
            // shiftDetailTableAdapter
            // 
            this.shiftDetailTableAdapter.ClearBeforeFill = true;
            // 
            // operatorTableAdapter
            // 
            this.operatorTableAdapter.ClearBeforeFill = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(259, 1);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(83, 31);
            this.btnModify.TabIndex = 60;
            this.btnModify.Text = "編排班表";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // shiftTableShiftDetailBindingSource
            // 
            this.shiftTableShiftDetailBindingSource.DataMember = "ShiftTableShiftDetail";
            this.shiftTableShiftDetailBindingSource.DataSource = this.shiftTableBindingSource;
            // 
            // hRBindingSource
            // 
            this.hRBindingSource.DataMember = "HR";
            this.hRBindingSource.DataSource = this.vEDataSet;
            // 
            // hRTableAdapter
            // 
            this.hRTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox1.Location = new System.Drawing.Point(146, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 24);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.Text = "M";
            this.comboBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 24);
            this.textBox1.TabIndex = 62;
            this.textBox1.Text = "早班";
            this.textBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 16;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox2.Location = new System.Drawing.Point(287, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(40, 24);
            this.comboBox2.TabIndex = 63;
            this.comboBox2.Text = "8";
            this.comboBox2.Visible = false;
            // 
            // btnSaveCodeConfig
            // 
            this.btnSaveCodeConfig.Location = new System.Drawing.Point(639, 1);
            this.btnSaveCodeConfig.Name = "btnSaveCodeConfig";
            this.btnSaveCodeConfig.Size = new System.Drawing.Size(83, 31);
            this.btnSaveCodeConfig.TabIndex = 64;
            this.btnSaveCodeConfig.Text = "代号存檔";
            this.btnSaveCodeConfig.UseVisualStyleBackColor = true;
            this.btnSaveCodeConfig.Click += new System.EventHandler(this.btnSaveCodeConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "代号";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "意義";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "時數";
            this.label3.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 16;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox3.Location = new System.Drawing.Point(287, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(40, 24);
            this.comboBox3.TabIndex = 70;
            this.comboBox3.Text = "8";
            this.comboBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 155);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 24);
            this.textBox2.TabIndex = 69;
            this.textBox2.Text = "正班";
            this.textBox2.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox4.Location = new System.Drawing.Point(146, 155);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(42, 24);
            this.comboBox4.TabIndex = 68;
            this.comboBox4.Text = "N";
            this.comboBox4.Visible = false;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.ItemHeight = 16;
            this.comboBox5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox5.Location = new System.Drawing.Point(287, 185);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(40, 24);
            this.comboBox5.TabIndex = 73;
            this.comboBox5.Text = "8";
            this.comboBox5.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 185);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 24);
            this.textBox3.TabIndex = 72;
            this.textBox3.Text = "晚班";
            this.textBox3.Visible = false;
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox6.Location = new System.Drawing.Point(146, 185);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(42, 24);
            this.comboBox6.TabIndex = 71;
            this.comboBox6.Text = "P";
            this.comboBox6.Visible = false;
            // 
            // comboBox7
            // 
            this.comboBox7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.ItemHeight = 16;
            this.comboBox7.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox7.Location = new System.Drawing.Point(287, 215);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(40, 24);
            this.comboBox7.TabIndex = 76;
            this.comboBox7.Text = "10";
            this.comboBox7.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 215);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 24);
            this.textBox4.TabIndex = 75;
            this.textBox4.Visible = false;
            // 
            // comboBox8
            // 
            this.comboBox8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox8.Location = new System.Drawing.Point(146, 215);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(42, 24);
            this.comboBox8.TabIndex = 74;
            this.comboBox8.Text = "A";
            this.comboBox8.Visible = false;
            // 
            // comboBox9
            // 
            this.comboBox9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.ItemHeight = 16;
            this.comboBox9.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox9.Location = new System.Drawing.Point(287, 245);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(40, 24);
            this.comboBox9.TabIndex = 79;
            this.comboBox9.Text = "11";
            this.comboBox9.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(194, 245);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 24);
            this.textBox5.TabIndex = 78;
            this.textBox5.Visible = false;
            // 
            // comboBox10
            // 
            this.comboBox10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox10.Location = new System.Drawing.Point(146, 245);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(42, 24);
            this.comboBox10.TabIndex = 77;
            this.comboBox10.Text = "B";
            this.comboBox10.Visible = false;
            // 
            // comboBox11
            // 
            this.comboBox11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.ItemHeight = 16;
            this.comboBox11.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox11.Location = new System.Drawing.Point(287, 275);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(40, 24);
            this.comboBox11.TabIndex = 82;
            this.comboBox11.Text = "12";
            this.comboBox11.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(194, 275);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 24);
            this.textBox6.TabIndex = 81;
            this.textBox6.Text = "拉通班";
            this.textBox6.Visible = false;
            // 
            // comboBox12
            // 
            this.comboBox12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox12.Location = new System.Drawing.Point(146, 275);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(42, 24);
            this.comboBox12.TabIndex = 80;
            this.comboBox12.Text = "C";
            this.comboBox12.Visible = false;
            // 
            // comboBox13
            // 
            this.comboBox13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.ItemHeight = 16;
            this.comboBox13.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox13.Location = new System.Drawing.Point(287, 305);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(40, 24);
            this.comboBox13.TabIndex = 85;
            this.comboBox13.Text = "13";
            this.comboBox13.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(194, 305);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(80, 24);
            this.textBox7.TabIndex = 84;
            this.textBox7.Visible = false;
            // 
            // comboBox14
            // 
            this.comboBox14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox14.Location = new System.Drawing.Point(146, 305);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(42, 24);
            this.comboBox14.TabIndex = 83;
            this.comboBox14.Text = "D";
            this.comboBox14.Visible = false;
            // 
            // comboBox15
            // 
            this.comboBox15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.ItemHeight = 16;
            this.comboBox15.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox15.Location = new System.Drawing.Point(287, 335);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(40, 24);
            this.comboBox15.TabIndex = 88;
            this.comboBox15.Text = "14";
            this.comboBox15.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(194, 335);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(80, 24);
            this.textBox8.TabIndex = 87;
            this.textBox8.Visible = false;
            // 
            // comboBox16
            // 
            this.comboBox16.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox16.Location = new System.Drawing.Point(146, 335);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(42, 24);
            this.comboBox16.TabIndex = 86;
            this.comboBox16.Text = "E";
            this.comboBox16.Visible = false;
            // 
            // comboBox17
            // 
            this.comboBox17.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.ItemHeight = 16;
            this.comboBox17.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox17.Location = new System.Drawing.Point(287, 365);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(40, 24);
            this.comboBox17.TabIndex = 91;
            this.comboBox17.Text = "15";
            this.comboBox17.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(194, 365);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(80, 24);
            this.textBox9.TabIndex = 90;
            this.textBox9.Visible = false;
            // 
            // comboBox18
            // 
            this.comboBox18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox18.Location = new System.Drawing.Point(146, 365);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(42, 24);
            this.comboBox18.TabIndex = 89;
            this.comboBox18.Text = "F";
            this.comboBox18.Visible = false;
            // 
            // comboBox19
            // 
            this.comboBox19.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.ItemHeight = 16;
            this.comboBox19.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox19.Location = new System.Drawing.Point(286, 395);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(40, 24);
            this.comboBox19.TabIndex = 94;
            this.comboBox19.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(193, 395);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(80, 24);
            this.textBox10.TabIndex = 93;
            this.textBox10.Text = "請假";
            this.textBox10.Visible = false;
            // 
            // comboBox20
            // 
            this.comboBox20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox20.Location = new System.Drawing.Point(145, 395);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(42, 24);
            this.comboBox20.TabIndex = 92;
            this.comboBox20.Text = "Q";
            this.comboBox20.Visible = false;
            // 
            // comboBox21
            // 
            this.comboBox21.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.ItemHeight = 16;
            this.comboBox21.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox21.Location = new System.Drawing.Point(286, 425);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(40, 24);
            this.comboBox21.TabIndex = 97;
            this.comboBox21.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(193, 425);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(80, 24);
            this.textBox11.TabIndex = 96;
            this.textBox11.Text = "輪休";
            this.textBox11.Visible = false;
            // 
            // comboBox22
            // 
            this.comboBox22.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox22.Location = new System.Drawing.Point(145, 425);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(42, 24);
            this.comboBox22.TabIndex = 95;
            this.comboBox22.Text = "K";
            this.comboBox22.Visible = false;
            // 
            // comboBox23
            // 
            this.comboBox23.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.ItemHeight = 16;
            this.comboBox23.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox23.Location = new System.Drawing.Point(286, 455);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(40, 24);
            this.comboBox23.TabIndex = 100;
            this.comboBox23.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(193, 455);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(80, 24);
            this.textBox12.TabIndex = 99;
            this.textBox12.Visible = false;
            // 
            // comboBox24
            // 
            this.comboBox24.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox24.Location = new System.Drawing.Point(145, 455);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(42, 24);
            this.comboBox24.TabIndex = 98;
            this.comboBox24.Visible = false;
            // 
            // comboBox25
            // 
            this.comboBox25.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.ItemHeight = 16;
            this.comboBox25.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox25.Location = new System.Drawing.Point(286, 485);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(40, 24);
            this.comboBox25.TabIndex = 103;
            this.comboBox25.Visible = false;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(193, 485);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(80, 24);
            this.textBox13.TabIndex = 102;
            this.textBox13.Visible = false;
            // 
            // comboBox26
            // 
            this.comboBox26.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox26.Location = new System.Drawing.Point(145, 485);
            this.comboBox26.Name = "comboBox26";
            this.comboBox26.Size = new System.Drawing.Size(42, 24);
            this.comboBox26.TabIndex = 101;
            this.comboBox26.Visible = false;
            // 
            // dgvConfigShiftCode
            // 
            this.dgvConfigShiftCode.AutoGenerateColumns = false;
            this.dgvConfigShiftCode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.dgvConfigShiftCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfigShiftCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCode,
            this.columnNote,
            this.columnHour});
            this.dgvConfigShiftCode.DataSource = this.cShiftCodeBindingSource;
            this.dgvConfigShiftCode.Location = new System.Drawing.Point(464, 33);
            this.dgvConfigShiftCode.Name = "dgvConfigShiftCode";
            this.dgvConfigShiftCode.RowHeadersWidth = 25;
            this.dgvConfigShiftCode.RowTemplate.Height = 24;
            this.dgvConfigShiftCode.Size = new System.Drawing.Size(431, 642);
            this.dgvConfigShiftCode.TabIndex = 104;
            this.dgvConfigShiftCode.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvConfigShiftCode_DefaultValuesNeeded);
            // 
            // columnCode
            // 
            this.columnCode.DataPropertyName = "Code";
            this.columnCode.DataSource = this.cCodeForComboBindingSource;
            this.columnCode.DisplayMember = "Code";
            this.columnCode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.columnCode.HeaderText = "代号";
            this.columnCode.Name = "columnCode";
            this.columnCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnCode.ValueMember = "Code";
            this.columnCode.Width = 64;
            // 
            // cCodeForComboBindingSource
            // 
            this.cCodeForComboBindingSource.DataSource = typeof(VoucherExpense.FormShift.CCodeForCombo);
            // 
            // columnNote
            // 
            this.columnNote.DataPropertyName = "Note";
            this.columnNote.HeaderText = "意義";
            this.columnNote.Name = "columnNote";
            this.columnNote.Width = 160;
            // 
            // columnHour
            // 
            this.columnHour.DataPropertyName = "Hour";
            this.columnHour.DataSource = this.cHourForComboBindingSource;
            this.columnHour.DisplayMember = "Hour";
            this.columnHour.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.columnHour.HeaderText = "換算工時";
            this.columnHour.Name = "columnHour";
            this.columnHour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnHour.ValueMember = "Hour";
            // 
            // cHourForComboBindingSource
            // 
            this.cHourForComboBindingSource.DataSource = typeof(VoucherExpense.FormShift.CHourForCombo);
            // 
            // cShiftCodeBindingSource
            // 
            this.cShiftCodeBindingSource.DataSource = typeof(VoucherExpense.FormShift.CShiftCode);
            // 
            // FormShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(896, 675);
            this.Controls.Add(this.dgvConfigShiftCode);
            this.Controls.Add(this.comboBox25);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.comboBox26);
            this.Controls.Add(this.comboBox23);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.comboBox24);
            this.Controls.Add(this.comboBox21);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.comboBox22);
            this.Controls.Add(this.comboBox19);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.comboBox20);
            this.Controls.Add(this.comboBox17);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.comboBox18);
            this.Controls.Add(this.comboBox15);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.comboBox16);
            this.Controls.Add(this.comboBox13);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.comboBox14);
            this.Controls.Add(this.comboBox11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox12);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveCodeConfig);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.shiftTableBindingNavigator);
            this.Controls.Add(this.dgvShift);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormShift";
            this.ShowIcon = false;
            this.Text = "排班表";
            this.Load += new System.EventHandler(this.FormShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMonthForComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTableBindingNavigator)).EndInit();
            this.shiftTableBindingNavigator.ResumeLayout(false);
            this.shiftTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTableShiftDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigShiftCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCodeForComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHourForComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cShiftCodeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShift;
        private VEDataSet vEDataSet;
        private VEDataSetTableAdapters.ShiftTableTableAdapter shiftTableTableAdapter;
        private System.Windows.Forms.BindingNavigator shiftTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 儲存SToolStripButton;
        private System.Windows.Forms.BindingSource shiftDetailBindingSource;
        private VEDataSetTableAdapters.ShiftDetailTableAdapter shiftDetailTableAdapter;
        private System.Windows.Forms.BindingSource operatorBindingSource;
        private VEDataSetTableAdapters.OperatorTableAdapter operatorTableAdapter;
        private System.Windows.Forms.BindingSource cMonthForComboBindingSource;
        private System.Windows.Forms.BindingSource shiftTableBindingSource;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShiftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnTableMonth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Locked;
        private System.Windows.Forms.DataGridViewComboBoxColumn KeyinID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shiftTableShiftDetailBindingSource;
        private System.Windows.Forms.BindingSource hRBindingSource;
        private VEDataSetTableAdapters.HRTableAdapter hRTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSaveCodeConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.ComboBox comboBox23;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ComboBox comboBox24;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ComboBox comboBox26;
        private System.Windows.Forms.DataGridView dgvConfigShiftCode;
        private System.Windows.Forms.BindingSource cCodeForComboBindingSource;
        private System.Windows.Forms.BindingSource cHourForComboBindingSource;
        private System.Windows.Forms.BindingSource cShiftCodeBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNote;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnHour;
    }
}