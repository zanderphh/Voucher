﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace VoucherExpense
{
   
    public class AccTitle
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public double Percentage { get; set; }

        public AccTitle(string code, string name) { Code = code; Name = name; Clear(); }
        public void Clear() { Money = 0;  Percentage = 0; }
        public void Add(decimal n) 
        {
/*            
            if (Code=="1030")
            {
                int i = 0;
                i++;
            }
*/
            Money += n;
        }
    }

    public class CVendor
    {
        public int ID { get; set; }
    }

    public class CIngredient
    {
        int id;
        decimal vol;
        int orc;
        decimal toc;
        decimal unc;
        public int ID       { get { return id;  } set { id = value;  } }
        public decimal Volume   { get { return vol; } set { vol = value; } }
        public decimal TotalCost { get { return toc; } set { toc = value; } }
        public decimal UnitCost  { get { return unc; } set { unc = value; } }
        public int OrderCount    { get { return orc; } set { orc = value; } }
        public CIngredient(int ID) { id = ID; }
    }

    public class CSelectedVoucher
    {
        int id;
        decimal cot;
        public int     ID   { get { return id;  } set { id= value;   } }
        public decimal Cost { get { return cot; } set { cot = value; } }
    }

    public class CMonthlyPay1
    {
        int vid;
        int orc;
        decimal mon;
        public int VenderID { get { return vid; } set { vid = value; } }
        public int OrderCount { get { return orc; } set { orc = value; } }
        public decimal Money { get { return mon; } set { mon = value; } }
    }

    public class TitleSetup
    {
        public string DefaultAsset      { get; set; }
        public string DefualtLiability  { get; set; }
        public string DefaultIncome     { get; set; }
        public string DefaultCost       { get; set; }
        public string DefaultExpense    { get; set; }
        public string VoucherShouldPay  { get; set; }
        public string CashIncome        { get; set; }
        public string CreditIncome      { get; set; }
        public string CashReceivable    { get; set; }
        public string CreditReceivable  { get; set; }
        public string OwnersEquity      { get; set; }
        private decimal feeRate;
        public decimal FeeRate() { return feeRate; }
        public string CreditFeeRate     
        {
            get { return feeRate.ToString(); }
            set 
            {
                decimal rate;
                if (decimal.TryParse(value, out rate) == true)
                     feeRate = rate;
                else feeRate = 0;
            }
        } 
        public const string ConfigName = "DefaultTitle";
        public const string TableName = "ForBalanceSheet";
        Config Cfg = new Config();

        public TitleSetup()
        {
            DefaultAsset    ="100";
            DefualtLiability="200";
            DefaultIncome   ="400";
            DefaultCost     ="500";
            DefaultExpense  ="600";
            VoucherShouldPay="203";
            CashIncome      ="403";
            CreditIncome    ="404";
            CashReceivable  ="1030";
            CreditReceivable="1040";
            OwnersEquity    ="210";
            CreditFeeRate   = "1.8";
        }

        bool DoSetup(XmlNode root, string nodeName, ref string outValue)
        {
            XmlNode node;
            node = root.SelectSingleNode(nodeName);
            if (node != null)
            {
                outValue = node.InnerText;
                return true;
            }
            return false;
        }

        public void Load()
        {
            XmlNode root = Cfg.Load(ConfigName, TableName);
            if (root == null) return;
            string str = "";
            if (DoSetup(root, "DefaultAsset"    , ref str)) DefaultAsset = str;
            if (DoSetup(root, "DefaultLiability", ref str)) DefualtLiability = str;
            if (DoSetup(root, "DefaultIncome"   , ref str)) DefaultIncome = str;
            if (DoSetup(root, "DefaultCost"     , ref str)) DefaultCost = str;
            if (DoSetup(root, "DefaultExpense"  , ref str)) DefaultExpense = str;
            if (DoSetup(root, "CashReceivable"  , ref str)) CashReceivable = str;
            if (DoSetup(root, "CashIncome"      , ref str)) CashIncome = str;
            if (DoSetup(root, "CreditIncome"    , ref str)) CreditIncome = str;
            if (DoSetup(root, "CreditReceivable", ref str)) CreditReceivable = str;
            if (DoSetup(root, "VoucherShouldPay", ref str)) VoucherShouldPay = str;
            if (DoSetup(root, "OwnersEquity"    , ref str)) OwnersEquity = str;
            if (DoSetup(root, "CreditFeeRate"   , ref str)) CreditFeeRate = str;
            
        }

        string AddSetup(string name, string value)
        {
            return "<" + name + ">" + value + "</" + name + ">";
        }

        public bool Save()
        {
            string content="<"+ConfigName+" Name=\""+TableName+"\">";
            content += AddSetup("DefaultAsset"      , DefaultAsset        );
            content += AddSetup("DefaultLiability"  , DefualtLiability    );
            content += AddSetup("DefaultIncome"     , DefaultIncome       );
            content += AddSetup("DefaultCost"       , DefaultCost         );
            content += AddSetup("DefaultExpense"    , DefaultExpense      );
            content += AddSetup("CashReceivable"    , CashReceivable      );
            content += AddSetup("CashIncome"        , CashIncome          );
            content += AddSetup("CreditIncome"      , CreditIncome        );
            content += AddSetup("CreditReceivable"  , CreditReceivable    );
            content += AddSetup("VoucherShouldPay"  , VoucherShouldPay    );
            content += AddSetup("OwnersEquity"      , OwnersEquity        );
            content += AddSetup("CreditFeeRate"     , CreditFeeRate       );
            content += "</" + ConfigName + ">";
            if (Cfg.Save(ConfigName, TableName, content)) return true;
            else return false;
        }

    }

    public class CBankDetail
    {
        public DateTime Date    { set; get; }
        public decimal Credit   { set; get; }
        public decimal Debt     { set; get; }
        public string Note      { set; get; }
    }

    public class CBankAccountForComboBox
    {
        public string Name { set; get; }
        public int ID      { set; get; }
        public CBankAccountForComboBox()
        {
            Name = ""; ID = 0;
        }
    }

    // 在 SaleSpendRatio.cs和FormSoldIngredients.cs中使用
    public class CSaleItem  
    {
        public CSaleItem() { Code = 0; Volume = 0; }  // 必需有這行BindingSource才能AllowNew
        public CSaleItem(int code) { Code = code; Volume = 0; }

        public int Code { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public string Unit { get; set; }
    }



}