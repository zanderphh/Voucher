﻿namespace VoucherExpense
{
    partial class AccountingTitle
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingTitle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accountingTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEDataSet = new VoucherExpense.VEDataSet();
            this.accountingTitleDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountingTitleTableAdapter = new VoucherExpense.VEDataSetTableAdapters.AccountingTitleTableAdapter();
            this.dgvLedgerTable = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bankAccountTableAdapter = new VoucherExpense.VEDataSetTableAdapters.BankAccountTableAdapter();
            this.expenseTableAdapter = new VoucherExpense.VEDataSetTableAdapters.ExpenseTableAdapter();
            this.voucherTableAdapter = new VoucherExpense.VEDataSetTableAdapters.VoucherTableAdapter();
            this.voucherDetailTableAdapter = new VoucherExpense.VEDataSetTableAdapters.VoucherDetailTableAdapter();
            this.bankDetailTableAdapter = new VoucherExpense.VEDataSetTableAdapters.BankDetailTableAdapter();
            this.accVoucherTableAdapter = new VoucherExpense.VEDataSetTableAdapters.AccVoucherTableAdapter();
            this.vendorTableAdapter = new VoucherExpense.VEDataSetTableAdapters.VendorTableAdapter();
            this.ingredientTableAdapter = new VoucherExpense.VEDataSetTableAdapters.IngredientTableAdapter();
            this.accountingTitleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.accountingTitleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.DeletetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelMessage = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othersideAccTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLedgerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountingTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingTitleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingTitleBindingNavigator)).BeginInit();
            this.accountingTitleBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLedgerTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accountingTitleBindingSource
            // 
            this.accountingTitleBindingSource.DataMember = "AccountingTitle";
            this.accountingTitleBindingSource.DataSource = this.vEDataSet;
            this.accountingTitleBindingSource.Sort = "TitleCode";
            // 
            // vEDataSet
            // 
            this.vEDataSet.DataSetName = "VEDataSet";
            this.vEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingTitleDataGridView
            // 
            this.accountingTitleDataGridView.AllowUserToAddRows = false;
            this.accountingTitleDataGridView.AllowUserToDeleteRows = false;
            this.accountingTitleDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.accountingTitleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.accountingTitleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.accountingTitleDataGridView.AutoGenerateColumns = false;
            this.accountingTitleDataGridView.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountingTitleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.accountingTitleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleCode,
            this.columnTitleName,
            this.InitialValue,
            this.dataGridViewTextBoxColumn4});
            this.accountingTitleDataGridView.DataSource = this.accountingTitleBindingSource;
            this.accountingTitleDataGridView.EnableHeadersVisualStyles = false;
            this.accountingTitleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.accountingTitleDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.accountingTitleDataGridView.Name = "accountingTitleDataGridView";
            this.accountingTitleDataGridView.RowHeadersWidth = 25;
            this.accountingTitleDataGridView.RowTemplate.Height = 24;
            this.accountingTitleDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.accountingTitleDataGridView.Size = new System.Drawing.Size(448, 514);
            this.accountingTitleDataGridView.TabIndex = 1;
            this.accountingTitleDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.accountingTitleDataGridView_CellValidating);
            this.accountingTitleDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.accountingTitleDataGridView_RowValidating);
            // 
            // TitleCode
            // 
            this.TitleCode.DataPropertyName = "TitleCode";
            dataGridViewCellStyle3.NullValue = null;
            this.TitleCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.TitleCode.HeaderText = "科目編號";
            this.TitleCode.Name = "TitleCode";
            this.TitleCode.Width = 80;
            // 
            // columnTitleName
            // 
            this.columnTitleName.DataPropertyName = "Name";
            this.columnTitleName.HeaderText = "科目名稱";
            this.columnTitleName.Name = "columnTitleName";
            this.columnTitleName.Width = 120;
            // 
            // InitialValue
            // 
            this.InitialValue.DataPropertyName = "InitialValue";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.InitialValue.DefaultCellStyle = dataGridViewCellStyle4;
            this.InitialValue.HeaderText = "期初值";
            this.InitialValue.Name = "InitialValue";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastUpdated";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "更新日";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // accountingTitleTableAdapter
            // 
            this.accountingTitleTableAdapter.ClearBeforeFill = true;
            // 
            // dgvLedgerTable
            // 
            this.dgvLedgerTable.AllowUserToAddRows = false;
            this.dgvLedgerTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaShell;
            this.dgvLedgerTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLedgerTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLedgerTable.AutoGenerateColumns = false;
            this.dgvLedgerTable.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvLedgerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLedgerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.othersideAccTitleDataGridViewTextBoxColumn});
            this.dgvLedgerTable.DataSource = this.cLedgerTableBindingSource;
            this.dgvLedgerTable.Location = new System.Drawing.Point(0, 142);
            this.dgvLedgerTable.Name = "dgvLedgerTable";
            this.dgvLedgerTable.ReadOnly = true;
            this.dgvLedgerTable.RowHeadersWidth = 25;
            this.dgvLedgerTable.RowTemplate.Height = 24;
            this.dgvLedgerTable.Size = new System.Drawing.Size(885, 372);
            this.dgvLedgerTable.TabIndex = 3;
            this.dgvLedgerTable.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 490);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(885, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // bankAccountTableAdapter
            // 
            this.bankAccountTableAdapter.ClearBeforeFill = true;
            // 
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // voucherTableAdapter
            // 
            this.voucherTableAdapter.ClearBeforeFill = true;
            // 
            // voucherDetailTableAdapter
            // 
            this.voucherDetailTableAdapter.ClearBeforeFill = true;
            // 
            // bankDetailTableAdapter
            // 
            this.bankDetailTableAdapter.ClearBeforeFill = true;
            // 
            // accVoucherTableAdapter
            // 
            this.accVoucherTableAdapter.ClearBeforeFill = true;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // accountingTitleBindingNavigator
            // 
            this.accountingTitleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountingTitleBindingNavigator.BackgroundImage = global::VoucherExpense.Properties.Resources.NavBar_Back;
            this.accountingTitleBindingNavigator.BindingSource = this.accountingTitleBindingSource;
            this.accountingTitleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountingTitleBindingNavigator.DeleteItem = null;
            this.accountingTitleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.accountingTitleBindingNavigatorSaveItem,
            this.DeletetoolStripButton});
            this.accountingTitleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountingTitleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountingTitleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountingTitleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountingTitleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountingTitleBindingNavigator.Name = "accountingTitleBindingNavigator";
            this.accountingTitleBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.accountingTitleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountingTitleBindingNavigator.Size = new System.Drawing.Size(437, 27);
            this.accountingTitleBindingNavigator.TabIndex = 0;
            this.accountingTitleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // accountingTitleBindingNavigatorSaveItem
            // 
            this.accountingTitleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountingTitleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountingTitleBindingNavigatorSaveItem.Image")));
            this.accountingTitleBindingNavigatorSaveItem.Name = "accountingTitleBindingNavigatorSaveItem";
            this.accountingTitleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.accountingTitleBindingNavigatorSaveItem.Text = "儲存資料";
            this.accountingTitleBindingNavigatorSaveItem.Click += new System.EventHandler(this.accountingTitleBindingNavigatorSaveItem_Click);
            // 
            // DeletetoolStripButton
            // 
            this.DeletetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeletetoolStripButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DeletetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeletetoolStripButton.Image")));
            this.DeletetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeletetoolStripButton.Name = "DeletetoolStripButton";
            this.DeletetoolStripButton.Size = new System.Drawing.Size(23, 24);
            this.DeletetoolStripButton.Text = "刪除";
            this.DeletetoolStripButton.Click += new System.EventHandler(this.DeletetoolStripButton_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(141, 95);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(136, 16);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "會計科目類別說明";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "科目編號的第一碼代表大類",
            "第二三碼為小類",
            "",
            "",
            "1  資產",
            "2  負債",
            "3  業主權益",
            "4  營業收入",
            "5  營業成本",
            "6  營業費用",
            "",
            "以下對應之科目請至",
            "功能<傳票設定> 去設置",
            "---------------------------------",
            "不明的資產,不明的負債",
            "未標的成本,未標的費用",
            "所有進貨的貸方  ",
            "現金收入 刷卡收入",
            "---------------------------------"});
            this.listBox1.Location = new System.Drawing.Point(34, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 324);
            this.listBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.Controls.Add(this.accountingTitleBindingNavigator);
            this.panel1.Location = new System.Drawing.Point(448, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 514);
            this.panel1.TabIndex = 2;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 92;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "摘要";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 308;
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "Debt";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.debtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.debtDataGridViewTextBoxColumn.HeaderText = "借方";
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.creditDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.creditDataGridViewTextBoxColumn.HeaderText = "貸方";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.sumDataGridViewTextBoxColumn.HeaderText = "餘額";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // othersideAccTitleDataGridViewTextBoxColumn
            // 
            this.othersideAccTitleDataGridViewTextBoxColumn.DataPropertyName = "OthersideAccTitle";
            this.othersideAccTitleDataGridViewTextBoxColumn.HeaderText = "對沖科目";
            this.othersideAccTitleDataGridViewTextBoxColumn.Name = "othersideAccTitleDataGridViewTextBoxColumn";
            this.othersideAccTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.othersideAccTitleDataGridViewTextBoxColumn.Width = 200;
            // 
            // cLedgerTableBindingSource
            // 
            this.cLedgerTableBindingSource.DataSource = typeof(VoucherExpense.CLedgerRow);
            // 
            // AccountingTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 514);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dgvLedgerTable);
            this.Controls.Add(this.accountingTitleDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountingTitle";
            this.Text = "會計科目";
            this.Load += new System.EventHandler(this.FormAccountingTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingTitleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingTitleBindingNavigator)).EndInit();
            this.accountingTitleBindingNavigator.ResumeLayout(false);
            this.accountingTitleBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLedgerTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VEDataSet vEDataSet;
        private System.Windows.Forms.BindingSource accountingTitleBindingSource;
        private VoucherExpense.VEDataSetTableAdapters.AccountingTitleTableAdapter accountingTitleTableAdapter;
        private System.Windows.Forms.DataGridView accountingTitleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTitleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvLedgerTable;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.BindingSource cLedgerTableBindingSource;
        private VEDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        private VEDataSetTableAdapters.ExpenseTableAdapter expenseTableAdapter;
        private VEDataSetTableAdapters.VoucherTableAdapter voucherTableAdapter;
        private VEDataSetTableAdapters.VoucherDetailTableAdapter voucherDetailTableAdapter;
        private VEDataSetTableAdapters.BankDetailTableAdapter bankDetailTableAdapter;
        private VEDataSetTableAdapters.AccVoucherTableAdapter accVoucherTableAdapter;
        private VEDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private VEDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private System.Windows.Forms.BindingNavigator accountingTitleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton accountingTitleBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton DeletetoolStripButton;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othersideAccTitleDataGridViewTextBoxColumn;

    }
}