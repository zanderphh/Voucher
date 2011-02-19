﻿using System;
using System.Data;
using System.Windows.Forms;

namespace VoucherExpense
{
    public partial class FormOperator : Form
    {
        public FormOperator()
        {
            InitializeComponent();
        }

        private void operatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            VEDataSet.OperatorDataTable table = MyFunction.SaveCheck<VEDataSet.OperatorDataTable>(
                                                        this, operatorBindingSource, vEDataSet.Operator);
            if (table == null) return;
            foreach (VEDataSet.OperatorRow r in table.Rows)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                r.BeginEdit();
                r.LastUpdated = DateTime.Now;
                // 初次密碼設為和帳號相同 
                if (!r.IsPasswordNull())
                {
                    string str = r.Password.ToString().Trim();
                    if (str != "")
                    {
                        r.EndEdit();
                        continue;
                    }
                }
                r.Password = r.LoginName;
                r.EndEdit();
            }
            vEDataSet.Operator.Merge(table);
            this.operatorTableAdapter.Update(this.vEDataSet.Operator);
            this.vEDataSet.Operator.AcceptChanges();

        }

        private void FormOperator_Load(object sender, EventArgs e)
        {
            operatorTableAdapter.Connection = MapPath.VEConnection;
            // TODO: 這行程式碼會將資料載入 'vEDataSet.Operator' 資料表。您可以視需要進行移動或移除。
            this.operatorTableAdapter.Fill(this.vEDataSet.Operator);
            MyFunction.SetFieldLength(operatorDataGridView, vEDataSet.Operator);
        }

        private void operatorDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            // 自動產生內碼
            DataGridView view = (DataGridView)sender;
            MyFunction.SetCellMaxNo("OperatorID", view,0);
            DataGridViewRow row = view.CurrentRow;
            object ob=row.Cells["LoginName"].Value;
            if (ob != null)
                if (!Convert.IsDBNull(ob))
                {
                    string str=((string)ob).Trim();
                    if (str.Length < 5)
                    {
                        MessageBox.Show("登入名太短了!");
                        e.Cancel = true;
                    }
                    return;
                }
            MessageBox.Show("必須有登入名稱!");
            e.Cancel = true;
        }

        private void operatorDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
            DataGridView view = (DataGridView)sender;
            string cellName = view.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = view.Rows[e.RowIndex];
            if (cellName == "LoginName")
            {
                string str = e.FormattedValue.ToString().Trim();
                if (str.Length < 5)
                {
                    MessageBox.Show("登入名太短了!");
                    e.Cancel = true;
                    return;
                }
                for (int i = 0; i < view.Rows.Count; i++)
                {
                    if (i == e.RowIndex) continue;
                    DataGridViewCell c = view.Rows[i].Cells[cellName];
                    if (c.FormattedValue.ToString().Trim() == str)
                    {
                        MessageBox.Show("登入名<" + str + ">和第" + (i + 1).ToString() + "行重複!");
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

/*
        private void operatorDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            string cellName = view.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = view.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];
            if (cellName == "IsSuper")
            {
                if (cell.Value==null) return;
                if (Convert.IsDBNull(cell.Value)) return;
                bool isSuper=(bool)cell.Value;
                if (!isSuper) return;
                foreach(DataGridViewCell c in row.Cells) c.ReadOnly=true;
                try
                {
                    cell=row.Cells["OperatorID"];
                    int id = (int)cell.Value;
                    if (id == MyFunction.OperatorID)
                        row.Cells["LoginName"].ReadOnly = false;
                }
                catch{}
                return;
            }
        }
*/

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MyFunction.AddNewItem(operatorDataGridView,"operatorID","operatorID",vEDataSet.Operator);
            DataGridViewRow row = operatorDataGridView.CurrentRow;
            row.Cells["LoginName"].Value = "Name" + row.Cells["operatorID"].Value.ToString();
        }

    }
}