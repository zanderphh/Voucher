﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace VoucherExpense
{

    public class HardwareProfile
    {
        public string profileName;

        public bool isServer;
        public string dotPrinterName;

        //public string printerName;
        //public string comPortName;
        //public string dataDir;
        //public string userName;
        //public string password;
        //public string backupDir;

        public DB.SqlCredential Local=new DB.SqlCredential();
        public DB.SqlCredential Cloud=new DB.SqlCredential();
        public bool enableCloudSync;
        public string database;
        public string sharedDatabase;
    }

    public class HardwareConfig
    {
        public static string CfgFileName = "HardwareCfg.xml";
        public string ProfileName;
        public bool IsServer;
        public string DotPrinterName;

        //public string PrinterName;
        //public string ComPortName;
        //public string DataDir;
        //public string UserName;
        //public string Password;
        //public string BackupDir;

        public bool EnableCloudSync;
        public DB.SqlCredential Local=new DB.SqlCredential();
        public DB.SqlCredential Cloud=new DB.SqlCredential();
        public string Database;
        public string SharedDatabase;
        //public string SqlServerIP;
        //public string SqlDatabase;
        //public string SqlUserID;
        //public string SqlPassword;

        //public string SqlServerIPCloud;
        //public string SharedDatabaseCloud;
        //public string SqlUserIDCloud;
        //public string SqlPasswordCloud;

        public List<HardwareProfile> ProfileList = null;
        public HardwareProfile ActiveProfile = null;
        public HardwareProfile LoginDefaultProfile = new HardwareProfile();

        //public string MaskDataDir()
        //{
        //    if (DataDir == null) return "";
        //    int len=DataDir.Length;
        //    if (len==0) return "";
        //    string str ;
        //    if (DataDir[len - 1] == '\\') len--;
        //    str = DataDir.Substring(0, len);
        //    int i=str.LastIndexOf('\\')+2;
        //    if   (i >= len) i = len - 1;
        //    StringBuilder sb= new StringBuilder(str.Substring(0, i));
        //    for (; i < len; i++) sb.Append('*');
        //    return sb.ToString();
        //}

        public HardwareConfig()
        {
            IsServer = true;
        }

        public List<string> GetProfileList()
        {
            return new List<string>();
        }

        void GetAttrib(XmlNode node,string attrib,ref string name)
        {
            if (node == null) return;
            XmlAttribute att = node.Attributes[attrib];
            if (att == null)
            {
                name = null;
                return;
            }
            string str = att.Value;    // 沒有這個attrib 則 name=null
            name = str;
        }

        const string Key = "LordAlex";
        void GetEncryptedAttrib(XmlNode node, string attrib, ref string name)
        {
            if (node == null) return;
            XmlAttribute att = node.Attributes[attrib];
            if (att == null)
            {
                name = null;
                return;
            }
            string str = att.Value;    // 沒有這個attrib 則 name=null
            if (str == null || str.Length ==0)
            {
                name = "";
                return;
            }
            try
            {
                byte[] bufs = Encoder.RC2Decrypt(Convert.FromBase64String(str), Key);
                name = Encoding.Unicode.GetString(bufs);
            }
            catch
            {
                name = null;
            }
        }

        public void LoadToProfile(XmlNode node,HardwareProfile curr)
        {
            //GetAttrib(node.SelectSingleNode("ComPort")       , "Name", ref curr.comPortName);
            //GetAttrib(node.SelectSingleNode("ReceiptPrinter"), "Name", ref curr.printerName);
            GetAttrib(node.SelectSingleNode("DotPrinter")    , "Name", ref curr.dotPrinterName);

            XmlNode Server = node.SelectSingleNode("DataSource");
            if (Server != null)
            {
                string str = "";
                GetAttrib(Server, "IsServer", ref str);
                if (str != null && str.ToUpper() == "NO") curr.isServer = false;
                else curr.isServer = true;
                //GetEncryptedAttrib(Server, "DataDir"    , ref curr.dataDir);
                //GetEncryptedAttrib(Server, "UserName"   , ref curr.userName);
                //GetEncryptedAttrib(Server, "Password"   , ref curr.password);
                //GetEncryptedAttrib(Server, "BackupDir"  , ref curr.backupDir);

                GetEncryptedAttrib(Server, "SqlServerIP", ref curr.Local.ServerIP);
                GetEncryptedAttrib(Server, "SqlUserID"  , ref curr.Local.UserID);
                GetEncryptedAttrib(Server, "SqlPassword", ref curr.Local.Password);
                GetEncryptedAttrib(Server, "SqlDatabase", ref curr.database);

                GetAttrib(Server, "EnableCloudSync", ref str);
                if (str != null && str.ToUpper() == "YES") curr.enableCloudSync = true;
                else curr.enableCloudSync = false;
                GetEncryptedAttrib(Server, "SqlServerIPCloud", ref curr.Cloud.ServerIP);
                GetEncryptedAttrib(Server, "SqlUserIDCloud"  , ref curr.Cloud.UserID);
                GetEncryptedAttrib(Server, "SqlPasswordCloud", ref curr.Cloud.Password);
                GetEncryptedAttrib(Server, "SharedDatabaseCloud", ref curr.sharedDatabase);
            }
        }

        public void CopyHardwareProfile(HardwareProfile from, HardwareProfile to)
        {
            to.profileName = from.profileName;
            to.isServer = from.isServer;
            to.dotPrinterName = from.dotPrinterName;

            //to.printerName = from.printerName;
            //to.comPortName = from.comPortName;
            //to.dataDir = from.dataDir;
            //to.userName = from.userName;
            //to.password = from.password;
            //to.backupDir = from.backupDir;

            to.enableCloudSync = from.enableCloudSync;
            to.database = from.database;
            to.sharedDatabase = from.sharedDatabase;

            to.Local = new DB.SqlCredential(from.Local);
            to.Cloud = new DB.SqlCredential(from.Cloud);
        }

        public void SetDefaultAs(HardwareProfile curr)
        {
            if (curr == null) return;
            ActiveProfile = curr;
            ProfileName =curr.profileName;
            IsServer = curr.isServer;
            DotPrinterName = curr.dotPrinterName;

            //PrinterName = curr.printerName;
            //ComPortName = curr.comPortName;
            //DataDir     =curr.dataDir;
            //UserName    =curr.userName;
            //Password    =curr.password;
            //BackupDir   =curr.backupDir;

            EnableCloudSync = curr.enableCloudSync;

            Local = curr.Local;
            Cloud = curr.Cloud;
            Database = curr.database;
            SharedDatabase = curr.sharedDatabase;
            //SqlServerIP = curr.sqlServerIP;
            //SqlDatabase =curr.sqlDatabase;
            //SqlUserID   =curr.sqlUserID;
            //SqlPassword =curr.sqlPassword;

            //SqlServerIPCloud = curr.sqlServerIPCloud;
            //SharedDatabaseCloud = curr.SharedDatabaseCloud;
            //SqlUserIDCloud   = curr.sqlUserIDCloud;
            //SqlPasswordCloud = curr.sqlPasswordCloud;
        }

        public void SaveDefaultTo(HardwareProfile curr)
        {
            if (curr == null) return;
            curr.profileName = ProfileName;
            curr.isServer = IsServer;
            curr.dotPrinterName = DotPrinterName;
            //curr.printerName = PrinterName;
            //curr.comPortName = ComPortName;
            //curr.dataDir     = DataDir;
            //curr.userName    = UserName;
            //curr.password    = Password;
            //curr.backupDir   = BackupDir;

            curr.enableCloudSync = EnableCloudSync;
            curr.database = Database;
            curr.sharedDatabase = SharedDatabase;

            curr.Local = Local;
            curr.Cloud = Cloud;
            //curr.sqlServerIP = SqlServerIP;
            //curr.sqlDatabase = SqlDatabase;
            //curr.sqlUserID   = SqlUserID;
            //curr.sqlPassword = SqlPassword;

            //curr.sqlServerIPCloud   = SqlServerIPCloud;
            //curr.SharedDatabaseCloud= SharedDatabaseCloud;
            //curr.sqlUserIDCloud     = SqlUserIDCloud;
            //curr.sqlPasswordCloud   = SqlPasswordCloud;
        }

        public void Load()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(CfgFileName);
                XmlNode root = doc.DocumentElement;
                if (root.Name == "HardwareConfig")     // 舊版的,只有一個Profile
                {
                    ProfileList = new List<HardwareProfile>();
                    HardwareProfile curr = new HardwareProfile();
                    curr.profileName = "預設值";
                    LoadToProfile(root, curr);
                    SetDefaultAs(curr);
                    ProfileList.Add(curr);
                    ActiveProfile = curr;
                }
                else if (root.Name == "HardwareProfile")
                {
                    ProfileList = new List<HardwareProfile>();
                    foreach (XmlNode node in root.ChildNodes)
                    {
                        if (node.Name == "Profile")
                        {
                            HardwareProfile curr = new HardwareProfile();
                            curr.profileName = "預設值";
                            GetAttrib(node, "Name", ref curr.profileName);
                            LoadToProfile(node, curr);
                            ProfileList.Add(curr);
                        }
                    }
                    if (ProfileList.Count > 0)
                    {
                        ActiveProfile = ProfileList[0];
                        SetDefaultAs(ActiveProfile);
                    }
                }
                else
                    MessageBox.Show("未知的HardwareCfg.xml格式!");
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取<HardwareCfg.xml>時發生錯誤!\r\n請確定正確的HardwareCfg.xml和Manage.exe在相同目錄!\r\n錯誤原因:" + ex.Message);
            }
        }

        public void Save()
        {
            SaveTo(".");
        }

        private void SaveToNode(XmlDocument doc,XmlNode node, HardwareProfile curr)
        {
            UpdateXmlAttrib(doc, node, "DotPrinter"     , "Name", curr.dotPrinterName);
            UpdateXmlAttrib(doc, node, "DataSource"     , "IsServer", (IsServer ? "YES" : "NO"));
            //UpdateXmlAttrib(doc, node, "ReceiptPrinter", "Name", curr.printerName);
            //UpdateXmlAttrib(doc, node, "ComPort", "Name", curr.comPortName);
            //UpdateXmlAttribEncrypted(doc, node, "DataSource", "DataDir", curr.dataDir);
            //UpdateXmlAttribEncrypted(doc, node, "DataSource", "UserName"    , curr.userName);
            //UpdateXmlAttribEncrypted(doc, node, "DataSource", "Password"    , curr.password);
            //UpdateXmlAttribEncrypted(doc, node, "DataSource", "BackupDir"   , curr.backupDir);

            UpdateXmlAttribEncrypted(doc, node, "DataSource", "SqlServerIP" , curr.Local.ServerIP);
            UpdateXmlAttribEncrypted(doc, node, "DataSource", "SqlUserID"   , curr.Local.UserID);
            UpdateXmlAttribEncrypted(doc, node, "DataSource", "SqlPassword" , curr.Local.Password);
            UpdateXmlAttribEncrypted(doc, node, "DataSource", "SqlServerIPCloud", curr.Cloud.ServerIP);
            UpdateXmlAttribEncrypted(doc, node, "DataSource", "SqlUserIDCloud", curr.Cloud.UserID);
            UpdateXmlAttribEncrypted(doc, node, "DataSource", "SqlPasswordCloud", curr.Cloud.Password);

            UpdateXmlAttrib(doc, node, "DataSource", "EnableCloudSync", (EnableCloudSync ? "YES" : "NO"));
            UpdateXmlAttribEncrypted(doc, node, "DataSource", "SqlDatabase", curr.database);
            UpdateXmlAttribEncrypted(doc, node, "DataSource", "SharedDatabaseCloud", curr.sharedDatabase);

        }

        public void SaveTo(string dir)
        {
            SaveDefaultTo(ActiveProfile);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<HardwareProfile />");
            XmlNode root = doc.FirstChild;
            foreach(var profile in ProfileList)
            {
                XmlNode node = doc.CreateElement("Profile");
                root.AppendChild(node);
                XmlAttribute att = doc.CreateAttribute("Name");
                att.Value = profile.profileName;
                node.Attributes.Append(att);
                SaveToNode(doc, node, profile);
            }
            doc.Save(dir+"\\"+CfgFileName);
        }

        protected void UpdateXmlText(XmlDocument xml, XmlNode root, string Name, string Text)
        {
            XmlNode node = root.SelectSingleNode(Name);
            if (node == null)
            {
                node = xml.CreateElement(Name);
                root.AppendChild(node);
            }
            XmlText text = xml.CreateTextNode(Text);
            node.AppendChild(text);
        }

        protected XmlNode UpdateXmlAttrib(XmlDocument xml, XmlNode root, string Name, string Attrib, string Value)
        {
            XmlNode node = root.SelectSingleNode(Name);
            if (node == null)
            {
                node = xml.CreateElement(Name);
                root.AppendChild(node);
            }
            XmlAttribute att = xml.CreateAttribute(Attrib);
            att.Value = Value;
            node.Attributes.Append(att);
            return node;
        }

        protected void UpdateXmlAttribEncrypted(XmlDocument xml, XmlNode root, string Name, string Attrib, string Value)
        {
            XmlNode node = root.SelectSingleNode(Name);
            if (node == null)
            {
                node = xml.CreateElement(Name);
                root.AppendChild(node);
            }
            if (Value == null) return;
            XmlAttribute att = xml.CreateAttribute(Attrib);

            byte[] bufs=Encoder.RC2Encrypt(Encoding.Unicode.GetBytes(Value),Key);
            att.Value = Convert.ToBase64String(bufs);

            node.Attributes.Append(att);
        }


    }
}
