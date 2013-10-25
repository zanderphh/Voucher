﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace VoucherExpense
{
    public partial class FormBillList : Form
    {
        public FormBillList()
        {
            InitializeComponent();
        }

        Image image;
        HardwareConfig Config = new HardwareConfig();
        string Apartmentname="";
       // bool  StateIsEndit = false;//状态是否编辑
        private void FormBillList_Load(object sender, EventArgs e)
        {

            // TODO: 這行程式碼會將資料載入 'vEDataSet.Requests' 資料表。您可以視需要進行移動或移除。
            this.requestsTableAdapter.Fill(this.vEDataSet.Requests);
            this.requestsBindingSource.Sort = "requestsid desc";
            this.apartmentTableAdapter1.Fill(this.vEDataSet.Apartment);
            var apartment=vEDataSet.Apartment[0];
            Apartmentname= apartment.ApartmentAllName;
            textBox1.Text = Apartmentname;
            //设定打印机
            Config.Load();
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = Config.DotPrinterName;
            pD.PrinterSettings = ps;
                  
        }
        VEDataSet.RequestsRow Addrow;
        string intToint6(int num, int numlength)
        {
            string number = num.ToString();
            int len = number.Length;
            if (len < numlength)
            {
                for (int i = 0; i < numlength - len; i++)
                {
                    number = "0" + number;
                }
            }
            return number;
        }
        public List<TextBox> GetCTextBoxes(Control control)
        {
            List<TextBox> ctxts = new List<TextBox>();
            foreach (Control con in control.Controls)
            {
                if (con.GetType() == typeof(TextBox))
                {
                    ctxts.Add((TextBox)con);
                }
                if (con.GetType() == typeof(GroupBox))
                {
                    this.GetCTextBoxes(con);
                }
                if (con.GetType() == typeof(SplitContainer))
                {
                    this.GetCTextBoxes(con);
                }
                if (con.GetType() == typeof(SplitterPanel))
                {
                    this.GetCTextBoxes(con);
                }
            }
            return ctxts;
        }
        //public List<DateTimePicker> GetCDateTimePicker(Control control)
        //{
        //    List<DateTimePicker> ctxts = new List<DateTimePicker>();
        //    foreach (Control con in control.Controls)
        //    {
        //        if (con.GetType() == typeof(DateTimePicker))
        //        {
        //            ctxts.Add((DateTimePicker)con);
        //        }
        //        if (con.GetType() == typeof(GroupBox))
        //        {
        //            this.GetCDateTimePicker(con);
        //        }
        //        if (con.GetType() == typeof(SplitContainer))
        //        {
        //            this.GetCDateTimePicker(con);
        //        }
        //        if (con.GetType() == typeof(SplitterPanel))
        //        {
        //            this.GetCDateTimePicker(con);
        //        }
        //    }
        //    return ctxts;
        //}

        private void requestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        { 
            IsEnabled(false);//资料设置为不可编辑
            //if(StateIsEndit){
            this.requestsBindingSource.EndEdit();
            this.requestsTableAdapter.Update(vEDataSet.Requests);
           // StateIsEndit = false;
            //}
            //else
            //{
                //int maxID = 0;
                //int maxCode = 0;
                //this.requestsTableAdapter.Fill(this.vEDataSet.Requests);
                //foreach (VEDataSet.RequestsRow item in vEDataSet.Requests)
                //{
                //    if (item.RequestsID > maxID)
                //    {
                //        maxID = item.RequestsID;
                //    }
                //    if (Convert.ToInt32(item.ListNumber) > maxCode)
                //    {
                //        maxCode = Convert.ToInt32(item.ListNumber);
                //    }
                //}
                //Addrow = vEDataSet.Requests.NewRequestsRow();
                //Addrow.RequestsID = CurrentId;
                //Addrow.ListNumber = CurrentList;
                //Addrow.EndEdit();
                //if (CurrentId <= maxID)//和数据库数据比较确认id是否大于数据库id最大值，如果小于数据库最大id重新获取id和编号在存储
                //{
                //    string datetime = DateTime.Now.ToString("yyMM");
                //    string maxcode = "0";
                //    if (maxCode > 0)
                //        maxcode = maxCode.ToString().Remove(4);
                //    if (Convert.ToInt32(datetime) > Convert.ToInt32(maxcode))
                //    {
                //        maxCode = Convert.ToInt32(datetime + "000");
                //    }
                //    Addrow.RequestsID = maxID + 1;
                //    Addrow.ListNumber = (maxCode + 1).ToString();
                //}
                //else
                //{
                //    Addrow.RequestsID = CurrentId;
                //    Addrow.ListNumber = CurrentList;
                //}
            //    Addrow.OperatorID = MyFunction.OperatorID;
            //    Addrow.Department = departmentTextBox.Text;
            //    Addrow.Applicant = applicantTextBox.Text;
            //    Addrow.RequestsUse = requestsUseTextBox.Text;
            //    Addrow.UintName = uintNameTextBox.Text;
            //    Addrow.BankOfDeposit = bankOfDepositTextBox.Text;
            //    Addrow.Account = accountTextBox.Text;
            //    Addrow.MoneyA = moneyATextBox.Text;
            //    if (moneyAaTextBox.Text != "")
            //        Addrow.MoneyAa = Convert.ToDecimal(moneyAaTextBox.Text);
            //    else
            //    {
            //        Addrow.MoneyAa = 0;
            //    }
            //    Addrow.PaymenMethods = paymenMethodsTextBox.Text;
            //    Addrow.HandoverPoeple = "";
            //    Addrow.DateOfPayment = dateOfPaymentDateTimePicker.Value.Date;
            //    Addrow.BillingDate = billingDateDateTimePicker.Value.Date;
            //    Addrow.CreateTime = DateTime.Now;
            //    Addrow.IsCancel = false;
            //    Addrow.IsLock = false;
            //    Addrow.EndEdit();
            //    vEDataSet.Requests.Rows.Add(Addrow);
            //    //this.requestsTableAdapter.Insert(Addrow.RequestsID, Addrow.ListNumber, Addrow.OperatorID, Addrow.Department, Addrow.Applicant,
            //    //    Addrow.RequestsUse, Addrow.UintName, Addrow.BankOfDeposit, Addrow.Account, Addrow.MoneyA, Addrow.MoneyAa, Addrow.PaymenMethods,
            //    //    Addrow.HandoverPoeple, Addrow.BillingDate, Addrow.DateOfPayment, Addrow.IsLock, Addrow.IsCancel, Addrow.CreateTime);
            //    this.requestsTableAdapter.Update(vEDataSet.Requests);
            //}
            this.bindingNavigatorAddNewItem.Enabled = true;
            this.requestsBindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.requestsTableAdapter.Fill(this.vEDataSet.Requests);
            this.requestsDataGridView.Enabled = true;
            this.isCancelCheckBox.Enabled = true;
        }
        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            IsEnabled(true);//资料设置为可编辑
            this.isCancelCheckBox.Enabled = false;
            this.bindingNavigatorAddNewItem.Enabled = false; 
            this.bindingNavigatorDeleteItem.Enabled = true;
            this.requestsBindingNavigatorSaveItem.Enabled = true;
            this.bindingNavigatorMovePreviousItem.Enabled = false;
            this.bindingNavigatorMoveFirstItem.Enabled = false;
            this.requestsDataGridView.Enabled = false;
            dateTimetoolStripCbB.SelectedIndex = -1;
            departmentTextBox.Focus();
            newRequests();
        }
        int CurrentId=0;
        string CurrentList;
        void newRequests()//创建新单数据
        {
            
            int maxID = 0;
            int maxCode = 0;
            this.requestsTableAdapter.Fill(this.vEDataSet.Requests);
            foreach (VEDataSet.RequestsRow item in vEDataSet.Requests)
            {
                if (item.RequestsID > maxID)
                {
                    maxID = item.RequestsID;
                }
                if (Convert.ToInt32(item.ListNumber) > maxCode)
                {
                    maxCode = Convert.ToInt32(item.ListNumber);
                }
            }
            string datetime = DateTime.Now.ToString("yyMM");
             string maxcode ="0";
            if(maxCode>0)
            maxcode = maxCode.ToString().Remove(4);
            if (Convert.ToInt32(datetime)>Convert.ToInt32(maxcode))
            {
                maxCode = Convert.ToInt32(datetime + "000");
            }
            Addrow = vEDataSet.Requests.NewRequestsRow();
            Addrow.RequestsID = maxID + 1;
            CurrentId = maxID + 1;
            Addrow.ListNumber = (maxCode + 1).ToString();
            CurrentList = (maxCode + 1).ToString();
            listNumberTextBox.Text = (maxCode + 1).ToString();
            listNumberTextBox.Text = Addrow.ListNumber;
            Addrow.SetAccountNull();
            Addrow.OperatorID = MyFunction.OperatorID;
            Addrow.SetDepartmentNull();
            Addrow.SetApplicantNull();
            Addrow.SetRequestsUseNull();
            Addrow.SetUintNameNull();
            Addrow.SetBankOfDepositNull();
            Addrow.SetMoneyAaNull();
            Addrow.SetMoneyANull();
            Addrow.SetPaymenMethodsNull();
            Addrow.SetHandoverPoepleNull();
            Addrow.SetBillingDateNull();
            Addrow.SetDateOfPaymentNull();
            Addrow.IsLock = false;
            Addrow.IsCancel = false;
            Addrow.CreateTime = DateTime.Now;
            Addrow.EndEdit();
             vEDataSet.Requests.Rows.Add(Addrow);
              this.requestsTableAdapter.Update(vEDataSet.Requests);
            this.requestsTableAdapter.Fill(this.vEDataSet.Requests);
            
        }
        bool isEmpty=false;
        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           image =  global::VoucherExpense.Properties.Resources.Requests;
            //image = Image.FromFile(Application.StartupPath+"\\BillBackground\\Requests.png");//D:\VoucherExpense10\VoucherExpense\
            // 获取Graphics
            Graphics g = e.Graphics;
            //DrawImage(g);
            //fDpiX = g.DpiX;
            //fDpiY = g.DpiY;
            Font font = new Font("新宋体", 30, GraphicsUnit.Pixel);
            Brush brush = new SolidBrush(Color.Black);
            Graphics g1 = Graphics.FromImage(image);
            if (isEmpty)//打印空单
            {
                g1.DrawString(listNumberTextBox.Text, font, brush, 2 * listNumberTextBox.Location.X, 2 * listNumberTextBox.Location.Y + 10);
            }
            else
            {
                List<TextBox> ctxts = GetCTextBoxes(this.panel1);
             //   List<DateTimePicker> cDateTimePicker = GetCDateTimePicker(this.panel1);
                foreach (TextBox ctxt in ctxts)
                {
                    g1.DrawString(ctxt.Text, font, brush, 2 * ctxt.Location.X, 2 * ctxt.Location.Y + 10);
                }
                //foreach (var ctxt in cDateTimePicker)
                //{
                //    g1.DrawString(ctxt.Text, font, brush, 2 * ctxt.Location.X, 2 * ctxt.Location.Y + 10);
                //}
            }
            g.DrawImage(image, new Point(0, 0));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //if (isLockCheckBox.Checked)
            //{
            //    MessageBox.Show("已经锁定无法打印");
            //    return;
            //}
            if (listNumberTextBox.Text == "")
            {
                MessageBox.Show("无单打印！");
                return;
            }
            if (!this.bindingNavigatorAddNewItem.Enabled )
            {
                MessageBox.Show("请先保存，在打印！");
                return;
            }
            //设置<打印文档>的纸张大小
            //PaperSize pageSize = new PaperSize("打印", Convert.ToInt32(MillimetersToPixel(image.Width, fDpiX)), Convert.ToInt32(MillimetersToPixel(image.Height, fDpiY)));
            //pD.DefaultPageSettings.PaperSize = pageSize;
            try
            {
                pD.Print();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.ToString());
                return;
            }
        }




        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            IsEnabled(false);//资料设置为不可编辑
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Enabled = true;
            this.requestsBindingNavigatorSaveItem.Enabled = false;
            this.requestsDataGridView.Enabled = true;
            requestsDataGridView.Rows.Remove(requestsDataGridView.CurrentRow);

        }

        private void moneyAaTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !MyFunction.DecimalValidate(((TextBox)sender).Text);
        }

//        private void toolStripButton1_Click_1(object sender, EventArgs e)
//        {
//            if (!this.bindingNavigatorAddNewItem.Enabled)
//            {
//                MessageBox.Show("单子正在编辑！");
//                return;
//            }
//            isEmpty = true;//打印空单
//            newRequests();
//            try
//            {

//                pD.Print();
//                int maxID = 0;
//                int maxCode = 0;
//                this.requestsTableAdapter.Fill(this.vEDataSet.Requests);
//                foreach (VEDataSet.RequestsRow item in vEDataSet.Requests)
//                {
//                    if (item.RequestsID > maxID)
//                    {
//                        maxID = item.RequestsID;
//                    }
//                    if (Convert.ToInt32(item.ListNumber) > maxCode)
//                    {
//                        maxCode = Convert.ToInt32(item.ListNumber);
//                    }
//                }
//                Addrow = vEDataSet.Requests.NewRequestsRow();
//                //Addrow.RequestsID = CurrentId;
//                //Addrow.ListNumber = CurrentList;
//                //Addrow.EndEdit();
//                if (CurrentId <= maxID)//和数据库数据比较确认id是否大于数据库id最大值，如果小于数据库最大id重新获取id和编号在存储
//                {
//                    string datetime = DateTime.Now.ToString("yyMM");
//                    string maxcode = "0";
//                    if (maxCode > 0)
//                        maxcode = maxCode.ToString().Remove(4);
//                    if (Convert.ToInt32(datetime) > Convert.ToInt32(maxcode))
//                    {
//                        maxCode = Convert.ToInt32(datetime + "000");
//                    }
//                    Addrow.RequestsID = maxID + 1;
//                    Addrow.ListNumber = (maxCode + 1).ToString();
//                }
//                else
//                {
//                    Addrow.RequestsID = CurrentId;
//                    Addrow.ListNumber = CurrentList;
//                }
//                Addrow.OperatorID = MyFunction.OperatorID;
//                //Addrow.Department = departmentTextBox.Text;
//                //Addrow.Applicant = applicantTextBox.Text;
//                //Addrow.RequestsUse = requestsUseTextBox.Text;
//                //Addrow.UintName = uintNameTextBox.Text;
//                //Addrow.BankOfDeposit = bankOfDepositTextBox.Text;
//                //Addrow.Account = accountTextBox.Text;
//                //Addrow.MoneyA = moneyATextBox.Text;
//                //if (moneyAaTextBox.Text != "")
//                //    Addrow.MoneyAa = Convert.ToDecimal(moneyAaTextBox.Text);
//                //else
//                //{
//                //    Addrow.MoneyAa = 0;
//                //}
//                //Addrow.PaymenMethods = paymenMethodsTextBox.Text;
//                //Addrow.HandoverPoeple = handoverPoepleTextBox.Text;
//                //Addrow.DateOfPayment = dateOfPaymentDateTimePicker.Value.Date;
//                //Addrow.BillingDate = billingDateDateTimePicker.Value.Date;
//                Addrow.CreateTime = DateTime.Now;
//                Addrow.IsCancel = false;
//                Addrow.IsLock = false;
//                Addrow.EndEdit();
//                //保存数据并重新加载
//                vEDataSet.Requests.Rows.Add(Addrow);
//                this.requestsTableAdapter.Update(vEDataSet.Requests);
//                this.requestsTableAdapter.Fill(this.vEDataSet.Requests);
//                isEmpty = false;//空单打印后isEmpty重置为false
//            }
//            catch (Exception ex)
//            {
//                isEmpty = false;//空单打印失败isEmpty也重置为false
//                MessageBox.Show(ex.ToString());
//                return;
//            }
////
//        }

        private void dateTimetoolStripCbB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = dateTimetoolStripCbB.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            if (!this.bindingNavigatorAddNewItem.Enabled)
            {
                MessageBox.Show("单子正在编辑！");
                return;
            }  
            string y = "#" + MyFunction.HeaderYear + "/";
            string m1, m2;

            if (i == 0)
                requestsBindingSource.Filter = "";
            else
                if (i < 12)
                {
                    m1 = y + i.ToString("d2") + "/01#";
                    m2 = y + (i + 1).ToString("d2") + "/01#";
                    requestsBindingSource.Filter = "(CreateTime>=" + m1 + ") AND (CreateTime<" + m2 + ")";
                }
                else if (i == 12)
                {
                    m1 = y + "12/01#";
                    m2 = y + "12/31#";
                    requestsBindingSource.Filter = "(CreateTime>=" + m1 + ") AND (CreateTime<=" + m2 + ")";
                }
            this.requestsDataGridView.Focus();
        }

        private void isCancelCheckBox_Click(object sender, EventArgs e)
        {
            this.requestsBindingSource.EndEdit();
            this.requestsTableAdapter.Update(vEDataSet.Requests);
            // this.requestsTableAdapter.Fill(this.vEDataSet.Requests);

        }
        private void requestsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //DataGridView view = (DataGridView)sender;
            //DataGridViewRow row = view.Rows[e.RowIndex];
            //DataGridViewCell cell = row.Cells["IsCancel"];
            //if (cell.ValueType != typeof(bool)) return;    // 不應該
            //bool removed = false;
            //if (cell.Value != null && cell.Value != DBNull.Value)
            //    removed = (bool)cell.Value;
            //Color color;
            //if (removed)
            //    color = Color.DarkCyan;
            //else if ((e.RowIndex % 2) != 0)
            //    color = Color.Azure;
            //else
            //    color = Color.White;
            //row.DefaultCellStyle.BackColor = color;
        }

        private void requestsDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells["IsCancel"];
            if (cell.ValueType != typeof(bool)) return;    // 不應該
            bool removed = false;
            if (cell.Value != null && cell.Value != DBNull.Value)
                removed = (bool)cell.Value;
            Color color;
            if (removed)
                color = Color.LightSteelBlue;
            else if ((e.RowIndex % 2) != 0)
                color = Color.OldLace;
            else
                color = Color.FloralWhite;
            row.DefaultCellStyle.BackColor = color;
        }
        private void IsEnabled(bool b)
        {
            this.departmentTextBox.Enabled= b;
            this.applicantTextBox.Enabled = b;
            this.requestsUseTextBox.Enabled = b;
            this.uintNameTextBox.Enabled = b;
            this.bankOfDepositTextBox.Enabled = b;
            this.accountTextBox.Enabled = b;
            this.moneyAaTextBox.Enabled = b;
            this.moneyATextBox.Enabled = b;
            this.paymenMethodsTextBox.Enabled = b;
            this.billingDateDateTimePicker.Enabled = b;
            this.dateOfPaymentDateTimePicker.Enabled = b;
            this.billingDateTextBox.Enabled = b;
            this.dateOfPaymentTextBox.Enabled = b;
        }

        private void tSBtEndit_Click(object sender, EventArgs e)
        {
            if (this.requestsDataGridView.CurrentRow.Cells["dgvColOperatorID"].Value.ToString() == MyFunction.OperatorID.ToString()) {
            if (!this.bindingNavigatorAddNewItem.Enabled)
            {
                MessageBox.Show("单子正在编辑！");
                return;
            }  
          //  StateIsEndit = true;
            IsEnabled(true);  
            this.requestsBindingNavigatorSaveItem.Enabled = true;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorMovePreviousItem.Enabled = false;
            this.bindingNavigatorMoveFirstItem.Enabled = false;
            this.requestsDataGridView.Enabled = false;
            this.bindingNavigatorMoveNextItem.Enabled = false;
            this.bindingNavigatorMoveLastItem.Enabled = false;
            this.isCancelCheckBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("此单不是您建立的无权编辑！");
            }
        }

        private void billingDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.billingDateTextBox.Text = billingDateDateTimePicker.Text;
        }

        private void dateOfPaymentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.dateOfPaymentTextBox.Text = dateOfPaymentDateTimePicker.Text;
        }


        private void requestsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            MessageBox.Show("第" + row.ToString() + "行,第" + col.ToString() + "欄資料" + e.Exception.Message);
            e.Cancel = true;

        }


    }
}