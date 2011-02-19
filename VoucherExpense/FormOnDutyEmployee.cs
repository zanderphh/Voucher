﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VoucherExpense
{
    public partial class FormOnDutyEmployee : Form
    {
        public FormOnDutyEmployee()
        {
            InitializeComponent();
        }

        private void onDutyEmployeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            VEDataSet.OnDutyEmployeeDataTable table = MyFunction.SaveCheck<VEDataSet.OnDutyEmployeeDataTable>(
                                                        this, this.onDutyEmployeeBindingSource, vEDataSet.OnDutyEmployee);
            if (table == null) return;
            foreach (VEDataSet.OnDutyEmployeeRow r in table.Rows)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                r.BeginEdit();
                r.LastUpdated = DateTime.Now;
                r.EndEdit();
            }
            vEDataSet.OnDutyEmployee.Merge(table);
            this.onDutyEmployeeTableAdapter.Update(this.vEDataSet.OnDutyEmployee);
            this.vEDataSet.OnDutyEmployee.AcceptChanges();
        }

        private void FormOnDutyEmployee_Load(object sender, EventArgs e)
        {
            onDutyDataTableAdapter.Connection       = MapPath.VEConnection;
            onDutyEmployeeTableAdapter.Connection   = MapPath.VEConnection;
            this.onDutyDataTableAdapter.Fill(this.vEDataSet.OnDutyData);
            this.onDutyEmployeeTableAdapter.Fill(this.vEDataSet.OnDutyEmployee);
            int index=DateTime.Now.Month - 2;
            if (index<0) index=0;
            this.comboBoxMonth.SelectedIndex = index;
            ckBoxShowAll_CheckedChanged(null,null);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MyFunction.AddNewItem(dgvOnDutyEmployee, "columnID", "ID", vEDataSet.OnDutyEmployee);
            DataGridViewRow row = this.dgvOnDutyEmployee.CurrentRow;
        }

        private void dgvOnDutyEmployee_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView view=sender as DataGridView;
            VEDataSet.OnDutyEmployeeRow er;
            try
            {
                DataRowView rv=view.CurrentRow.DataBoundItem as DataRowView;
                er = rv.Row as VEDataSet.OnDutyEmployeeRow;
            }
            catch
            {
                return;
            }
            if (er == null) return;
            if (er.IsOnDutyCodeNull()) return;
            if (er.IsNameNull()) return;
            labelName.Text = er.Name;
            int dutyCode = er.OnDutyCode;
            int month = comboBoxMonth.SelectedIndex + 1;
            int count = MyFunction.DayCountOfMonth(month);
            string[] str = new string[count];
            for (int i = 0; i < count; i++) str[i] = (i+1).ToString("d2")+"日";

            int d, h;
            VEDataSet.OnDutyDataRow[] rows=er.GetOnDutyDataRows();
            foreach (VEDataSet.OnDutyDataRow row in rows)
            {
                try
                {
                    DateTime t=row.TimeMark;
                    if (t.Month == month)
                    {
                        d = t.Day - 1;
                        h = t.Hour;
                        if (h < 7) d--;
                        if (d < 0) continue;
                    }
                    else if (t.Month == (month + 1))    // 下個月七點前的算到上個月去
                    {
                        d = t.Day - 1;
                        if (d != 0) continue;
                        h = t.Hour;
                        if (h < 7) continue;
                        d = count - 1;
                    }
                    else continue;
                    str[d] += " " + h.ToString("d2")+":"+t.Minute.ToString("d2")+" ";
                }
                catch { }
            }
            checkedListBox1.Items.Clear();
            foreach (string s in str)
                checkedListBox1.Items.Add(s);
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvOnDutyEmployee_SelectionChanged(dgvOnDutyEmployee, null);
        }

        private void ckBoxShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxShowAll.Checked)
                onDutyEmployeeBindingSource.Filter = "";
            else
                onDutyEmployeeBindingSource.Filter = "IsOnTheJob=true";
//            onDutyEmployeeBindingSource.ResetBindings(false);
        }

        string m_FileName = null;
        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result=openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            m_FileName = openFileDialog1.FileName;
            string[] data = System.IO.File.ReadAllLines(m_FileName);
            char[] sept= new char[1] {','};
            checkedListBox1.Items.Clear();
            string[] l;
            foreach (string s in data)
            {
                l=s.Split(sept);
                if (l.Length<1) continue;
                if (l.Length < 2)
                    checkedListBox1.Items.Add(l[0]);
                else
                {
                    checkedListBox1.Items.Add(l[0] + "," + l[1]);
                }
            }
            labelName.Text = "若下方資料無誤,請按 ==>";
            btnConfirmTrans.Visible = true;
        }

        private void btnConfirmTrans_Click(object sender, EventArgs e)
        {
            string[] data = System.IO.File.ReadAllLines(m_FileName);
            char[] sept= new char[1] {','};
            string[] l;
            int code;
            DateTime dt;
            int max=0,success=0,error=0,repeat=0;
            progressBar1.Maximum = 0;
            progressBar1.Maximum = data.Length+1;       // +1 nothing buf for safe
            progressBar1.Step = 1;
            progressBar1.Visible = true;
            foreach (VEDataSet.OnDutyDataRow r in vEDataSet.OnDutyData)
                if (r.ID > max) max = r.ID;
            foreach (string s in data)
            {
                l = s.Split(sept);
                if (l.Length < 2) continue;
                try
                {
                    if (!int.TryParse(l[0]         , out code   )) continue;
                    if (!DateTime.TryParse(l[1], out dt      )) continue;
                    var linqRow = from lr in vEDataSet.OnDutyData
                                  where (lr.TimeMark.Date == dt.Date && lr.TimeMark.Hour == dt.Hour && lr.TimeMark.Minute == dt.Minute && lr.OnDutyCode == code)
                                  select lr.RowState;
                    if (linqRow.Count() > 0)
                    {
                        bool allDeleted = true;
                        foreach (DataRowState state in linqRow)
                            if (state != DataRowState.Deleted)
                            {
                                allDeleted = false;
                                break;
                            }
                        if (!allDeleted)
                        {
                            repeat++;
                            progressBar1.PerformStep();
                            Application.DoEvents();
                            continue;
                        }
                    }
                    VEDataSet.OnDutyDataRow row = vEDataSet.OnDutyData.NewOnDutyDataRow();
                    row.ID = (++max);
                    row.OnDutyCode = code;
                    row.TimeMark = dt;
                    vEDataSet.OnDutyData.AddOnDutyDataRow(row);
                    success++;
                }
                catch { error++; }
                progressBar1.PerformStep();
                Application.DoEvents();
            }
            // Adapter.Update
            onDutyDataTableAdapter.Update(vEDataSet.OnDutyData);
            vEDataSet.OnDutyData.AcceptChanges();
            btnConfirmTrans.Visible=false;
            progressBar1.Visible = false;
            labelName.Text="轉檔完成" ;
            MessageBox.Show("轉檔完成! 共成功轉入" + success.ToString() + "筆! 失敗" + error.ToString() + "筆! 重複"+repeat.ToString()+"筆!");
            checkedListBox1.Items.Clear();
        }
    }
}