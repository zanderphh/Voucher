﻿ using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VoucherExpense
{
    public partial class FormShipment : Form
    {
        public FormShipment()
        {
            InitializeComponent();
        }


        bool ischecked = false;
        private void shipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MyFunction.LockAll)
            {
                MessageBox.Show("鎖定中,不能存檔");
                return;
            }
            if (!this.Validate())
            {
                MessageBox.Show("有資料錯誤, 請改好再存!");
                return;
            }
            this.shipmentBindingSource.EndEdit();
            this.shipmentDetailBindingSource.EndEdit();

            SQLVEDataSet.ShipmentDataTable table = (SQLVEDataSet.ShipmentDataTable)sQLVEDataSet.Shipment.GetChanges();
            SQLVEDataSet.ShipmentDetailDataTable detail = (SQLVEDataSet.ShipmentDetailDataTable)sQLVEDataSet.ShipmentDetail.GetChanges();
            if (table == null && detail == null)
            {
                MessageBox.Show("沒有改動任何資料! 不用存");
                return;
            }
            if (table != null)
            {
                foreach (SQLVEDataSet.ShipmentRow r in table)
                    if (r.RowState != DataRowState.Deleted)
                    {
                        //if (r.IsStockTimeNull())
                        //{r.time
                        //    MessageBox.Show("進貨單<" + r.ID.ToString() + ">沒有日期,不顯示在某單月,只顯示在全年度!");
                        //}
                        r.BeginEdit();
                        if (!ischecked)
                        {
                            r.KeyinID = MyFunction.OperatorID;
                            r.CheckedID = -1;
                        }
                        else
                        {
                            r.CheckedID = MyFunction.OperatorID;
                        }
                        r.LastUpdated = DateTime.Now;
                        r.EndEdit();
                    }
                try
                {
                    sQLVEDataSet.Shipment.Merge(table);
                    this.shipmentTableAdapter.Update(this.sQLVEDataSet.Shipment);
                    sQLVEDataSet.Shipment.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("存Shipment時,ex:" + ex.Message);
                }
            }
            //if (checkMode)  // 查核模式會更新會計科目
            //{
            //    MyFunction.SetGlobalFlag(GlobalFlag.basicDataModified);
            //    //                return;
            //}
            if (detail != null)
            {
                try
                {
                    sQLVEDataSet.ShipmentDetail.Merge(detail);
                    shipmentDetailTableAdapter.Update(sQLVEDataSet.ShipmentDetail);
                    sQLVEDataSet.ShipmentDetail.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("存ShipmentDetail時,ex:" + ex.Message);
                }
            }


        }
        bool m_edit = false;
        bool m_check = false;
        private void FormShipment_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“vEDataSet.AccountingTitle”中。您可以根据需要移动或删除它。
            this.accountingTitleTableAdapter.Fill(this.vEDataSet.AccountingTitle);
            try
            {

                // TODO: 这行代码将数据加载到表“vEDataSet.Operator”中。您可以根据需要移动或删除它。
                this.operatorTableAdapter.Fill(this.vEDataSet.Operator);
                // TODO: 这行代码将数据加载到表“bakeryOrderSet.Product”中。您可以根据需要移动或删除它。
                this.productTableAdapter.Fill(this.bakeryOrderSet.Product);
                // TODO: 这行代码将数据加载到表“sQLVEDataSet.ShipmentDetail”中。您可以根据需要移动或删除它。
                this.shipmentDetailTableAdapter.Fill(this.sQLVEDataSet.ShipmentDetail);
                // TODO: 这行代码将数据加载到表“sQLVEDataSet.Shipment”中。您可以根据需要移动或删除它。
                this.shipmentTableAdapter.Fill(this.sQLVEDataSet.Shipment);
                this.customerTableAdapter.Fill(this.sQLVEDataSet.Customer);
                // var operatorrow=vEDataSet.Operator.Select("OperatorID='" + MyFunction.OperatorID + "'");
                var opertatorrow = from row in vEDataSet.Operator where row.OperatorID == MyFunction.OperatorID select row;
                var ro = opertatorrow.First();
                m_edit = ro.EditShipment;
                m_check = ro.LockShipment;
            }
            catch (Exception ex)
            {

                MessageBox.Show("出货界面加载时出现异常" + ex.ToString());
            }
        }

        private void shipmentDetailDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow row = e.Row;
            DataGridViewCell cellID = row.Cells["detailColumnID"];
            cellID.Value = Guid.NewGuid();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (MyFunction.LockAll)
            {
                MessageBox.Show("鎖定中,新增無用");
            }
            int month = comboBoxMonth.SelectedIndex;
            if (month < 1 || month > 12)
            {
                month = DateTime.Now.Month;
                MessageBox.Show("你未選擇月份, 電腦設定新增為<" + month.ToString() + "月>單子!");
            }

            //            int count=this.voucherBindingNavigator.PositionItem.
            int ma = MyFunction.MaxNoInDB("ID", sQLVEDataSet.Shipment);
            int i = MyFunction.SetCellMaxNo("ColumnID", shipmentDataGridView, ma);
            if (i > 0)
            {
                this.iDLabel1.Text = i.ToString();
                //removedCheckBox.Checked = false;                           // 只有對DateTime的Binding會受影響, bool不會,所以可以放ResetBindings前  
                //checkedCheckBox.Checked = false;
                this.shipmentBindingSource.ResetBindings(false);           // 這行加了會把stockTimeTextBox.Text和entryTimeTextBox.Text給清成空白,所以放前面
                this.shipmentDetailBindingSource.ResetBindings(false);   // 有id了,可以刷新下面的detail表
                removedCheckBox.Checked = false;
                checkedCheckBox.Checked = false;
                // 初始時間, 放在ResetBindings後面
                int year = MyFunction.IntHeaderYear;
                DateTime t = DateTime.Now;
                disableDateTimePicker = true;
                this.dateTimePicker1.Value = new DateTime(year, month, 1);     // 代入的是資料庫的年份,選的月份
                disableDateTimePicker = false;
                // 有選月份時,先強設日期,否則在當月看不到
                DateTime stockTime = new DateTime(year, month, MyFunction.DayCountOfMonth(month));   // 資料月份,設成該月最後一天
                //stockTimeTextBox.Text = stockTime.ToShortDateString();
                MessageBox.Show("請設成正確出货日期!");
            }
        }
        private bool disableDateTimePicker = false;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (disableDateTimePicker) return;
            DateTimePicker picker = sender as DateTimePicker;
            this.shipTimeTextBox.Text = picker.Text;
        }

        private void shipmentDetailDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            string cellName = view.Columns[e.ColumnIndex].Name;
            if (cellName == "dgvCostColumn")
            {
                this.costTextBox.Text = CostTotal().ToString();
            }
            else if (cellName == "dgvColumnProductID")
            {
                DataGridViewRow dgRow = view.Rows[e.RowIndex];
                DataGridViewCell cell = dgRow.Cells[e.ColumnIndex];
                if (cell.ValueType != typeof(int)) return;  // IngridentCode是int
                if (cell.Value == null || cell.Value == DBNull.Value) return;
                int productID = (int)cell.Value;
                try
                {
                    //string str="ID="+code.ToString();
                    //VEDataSet.IngredientRow[] row = (VEDataSet.IngredientRow[])vEDataSet.Ingredient.Select(str);
                    var rows = from row in bakeryOrderSet.Product where (row.ProductID == productID) select row;
                    if (rows.Count() > 0)
                    {
                        BakeryOrderSet.ProductRow row = rows.First();
                        if (!row.IsTitleCodeNull())
                            dgRow.Cells["dgvColumnTitleCode"].Value = row.TitleCode;
                    }
                }
                catch { }
            }
            else if (cellName == "dgvColumnVolume")
            {
                try
                {
                    DataGridViewRow dgRow = view.Rows[e.RowIndex];
                    DataGridViewCell costCell = dgRow.Cells["dgvCostColumn"];
                    if (costCell.ValueType != typeof(decimal)) return;  // Cost不是decimal,資料庫定義必然被改過了,程式碼失效
                    if (costCell.Value == null) return;
                    if (costCell.Value != DBNull.Value) return;         // Cost有資料時就不改
                    DataRowView rowView = dgRow.DataBoundItem as DataRowView;
                    SQLVEDataSet.ShipmentDetailRow shipmentDetailRow = rowView.Row as SQLVEDataSet.ShipmentDetailRow;
                    // 查出食材表中相對應記錄
                    var rows = from ro in bakeryOrderSet.Product
                               where (ro.ProductID == shipmentDetailRow.ProductID)
                               select ro;
                    if (rows.Count() <= 0) return;
                    BakeryOrderSet.ProductRow row = rows.First();
                    if (row.IsPriceNull()) return;
                    if (row.Price <= 0) return;                      // 參考價不合理
                    costCell.Value = shipmentDetailRow.Volume * (decimal)row.Price;
                }
                catch { }
            }
        }
        private decimal CostTotal()
        {
            DataGridView view = this.shipmentDetailDataGridView;
            int columnIndex = view.Columns["dgvCostColumn"].Index;
            decimal cost = 0;
            foreach (DataGridViewRow row in view.Rows)
                cost += ToDecimal((string)row.Cells[columnIndex].FormattedValue);
            return cost;
        }
        private decimal ToDecimal(string str)
        {
            try
            {
                return Convert.ToDecimal(str);
            }
            catch
            {
                return 0;
            }
        }

        private void removedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ischecked = checkedCheckBox.Checked;
        }

        private void shipmentDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells["Removed"];
            if (cell.ValueType != typeof(bool)) return;    // 不應該
            bool removed = false;
            if (cell.Value != null && cell.Value != DBNull.Value)
                removed = (bool)cell.Value;
            Color color;
            if (removed)
                color = Color.DarkCyan;
            else if ((e.RowIndex % 2) != 0)
                color = Color.Azure;
            else 
                color = Color.White;
            row.DefaultCellStyle.BackColor = color;
        }

        private void shipmentDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells["Removed"];
            DataGridViewCell cell1 = row.Cells["Checked"];
            if (cell.ValueType != typeof(bool)) return;    // 不應該
            if (cell1.ValueType != typeof(bool)) return;    // 不應該
            bool removed = false;
            bool ischecked = false;
            if (cell.Value != null && cell.Value != DBNull.Value)
                removed = (bool)cell.Value;
            if (cell1.Value != null && cell1.Value != DBNull.Value)
                ischecked = (bool)cell1.Value;

            if (removed)
            {//废除单
                customerComboBox.Enabled = false;
                dateTimePicker1.Enabled = false;
                shipTimeTextBox.Enabled = false;
                shipCodeTextBox.Enabled = false;
                costTextBox.Enabled = false;
                shipmentDetailDataGridView.Enabled = false;
                checkedCheckBox.Enabled = false;
            }
            else
            {
                if (m_edit)
                {
                    customerComboBox.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    shipTimeTextBox.Enabled = true;
                    shipCodeTextBox.Enabled = true;
                    costTextBox.Enabled = true;
                    shipmentDetailDataGridView.Enabled = true;
                    removedCheckBox.Enabled = true;
                }
                if (m_check)
                    checkedCheckBox.Enabled = true;

            }
            if (ischecked)//已核
            {
                customerComboBox.Enabled = false;
                dateTimePicker1.Enabled = false;
                shipTimeTextBox.Enabled = false;
                shipCodeTextBox.Enabled = false;
                costTextBox.Enabled = false;
                shipmentDetailDataGridView.Enabled = false;
                if (m_check)
                { checkedCheckBox.Enabled = true; }
                else
                {
                    checkedCheckBox.Enabled = false;
                }
                if (m_edit) { removedCheckBox.Enabled = true; }
                else
                {
                    removedCheckBox.Enabled = false;
                }
            }
            else
            {

                if (m_check)
                { checkedCheckBox.Enabled = true; }
                else
                {
                    checkedCheckBox.Enabled = false;
                }
                if (m_edit) { removedCheckBox.Enabled = true; }
                else
                {
                    customerComboBox.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    shipTimeTextBox.Enabled = true;
                    shipCodeTextBox.Enabled = true;
                    costTextBox.Enabled = true;
                    shipmentDetailDataGridView.Enabled = true;
                    removedCheckBox.Enabled = false;
                }
            }
            Color color;
            if (removed)
                color = Color.DarkCyan;
            else if ((e.RowIndex % 2) != 0)
                color = Color.Azure;
            else
                color = Color.White;
            row.DefaultCellStyle.BackColor = color;
        }

        private void shipmentDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0)
            {
                MessageBox.Show("Shipment第" + e.RowIndex.ToString() + "行錯誤:" + e.Exception.Message);
                return;
            }
            DataGridViewCell cell = view.Rows[e.RowIndex].Cells[e.ColumnIndex];
            MessageBox.Show(string.Format("Shipment on Row{0} Col[{1}]:{2}", e.RowIndex, view.Columns[e.ColumnIndex].Name, e.Exception.Message));
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            int i = box.SelectedIndex;
            //            if (i == 0) return;
            string y = "#" + MyFunction.HeaderYear + "/";
            string m1, m2;
            if (i == 0)
                shipmentBindingSource.Filter = "";
            else
                if (i < 12)
                {
                    m1 = y + i.ToString("d2") + "/01#";
                    m2 = y + (i + 1).ToString("d2") + "/01#";
                    shipmentBindingSource.Filter = "(ShipTime>=" + m1 + ") AND (ShipTime<" + m2 + ")";
                }
                else if (i == 12)
                {
                    m1 = y + "12/01#";
                    m2 = y + "12/31#";
                    shipmentBindingSource.Filter = "(ShipTime>=" + m1 + ") AND (ShipTime<=" + m2 + ")";
                }
            this.shipmentDataGridView.Focus();
        }
        private void tsbtPrint_Click(object sender, EventArgs e)
        {
            DataRowView rowview=shipmentBindingSource.Current as DataRowView;
            SQLVEDataSet.ShipmentRow row = rowview.Row as SQLVEDataSet.ShipmentRow;
            var  customerrows =from ro in sQLVEDataSet.Customer where(ro.CustomerID==row.Customer) select ro;
            var customerrow=customerrows.First();
            Shipmentprint smp = new Shipmentprint();
            smp.ShipmentNumber = row.ID.ToString();
            smp.ContactPeople = customerrow.ContactPeople;
            smp.CustomerName = customerrow.Name;
            smp.ShipAddress = customerrow.Address;
            smp.ContactPhone = customerrow.Telephone;
            smp.EntryTime = row.LastUpdated.ToString("yyyyMMdd");
            smp.ShipTime = row.ShipTime.ToString("yyyyMMdd");
            var shipmetdetailrows=row.GetShipmentDetailRows();
            if(shipmetdetailrows.Count()==0)
                return ;
            List<List<Shipmentdetailprint>> lists = new List<List<Shipmentdetailprint>>();
            int inttemp=shipmetdetailrows.Count()/12;
            for (int j = 0; j <=inttemp; j++)
            {

                List<Shipmentdetailprint> listshipmentdetail = new List<Shipmentdetailprint>();
                for (int i = j*12; i < shipmetdetailrows.Count(); i++)
                {
                    if (i < (j + 1) * 12)
                    {
                        
                   
                    var temrow = shipmetdetailrows[i];
                    var productrow = from r in bakeryOrderSet.Product where (r.ProductID == temrow.ProductID) select r;

                    Shipmentdetailprint smdp = new Shipmentdetailprint();
                    smdp.Num = (i + 1) / 12+1;
                    smdp.NumCount = inttemp+1;
                    smdp.ProductName = productrow.First().Name;
                    smdp.Unit = productrow.First().Unit;
                    // smdp.ProductSpecifications = productrow.First().ProductSpecificatiions;规格
                    smdp.Volum = temrow.Volume;
                    listshipmentdetail.Add(smdp); 
                    }
                }
                lists.Add(listshipmentdetail);
            }
            smp.ShipmentDetileProduct = lists;
            FormShipmentPrint form = new FormShipmentPrint(smp);
            form.Show();
        }
        private void costTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void costTextBox_Validated(object sender, EventArgs e)
        {

        }

        private void shipmentDetailDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0)
            {
                MessageBox.Show("ShipmentDetail第" + e.RowIndex.ToString() + "行錯誤:" + e.Exception.Message);
                return;
            }
            DataGridViewCell cell = view.Rows[e.RowIndex].Cells[e.ColumnIndex];
            MessageBox.Show(string.Format("ShipmentDetail on Row{0} Col[{1}]:{2}", e.RowIndex, view.Columns[e.ColumnIndex].Name, e.Exception.Message));
        }


    }


}
