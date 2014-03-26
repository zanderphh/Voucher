﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SyncCloud
{
    static class DB
    {
        public static string SqlConnectString(string address, string database, string userID, string password)
        {
            return "Data Source=" + address + ";Initial Catalog=" + database
                   + ";Persist Security Info=True;User ID=" + userID + ";Password=" + password;
        }

        public static bool GetDeletedVersion(SqlConnection conn,out int maxID)
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(DeletedID) from dbo.SyncUpdatedVersion where 1=1", conn);
            maxID = -1;
            try
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    cmd.CommandText = "INSERT INTO dbo.SyncUpdatedVersion (DeletedID,Locked) VALUES(0,1)";
                    cmd.ExecuteNonQuery();
                    maxID = 0;
                    return true;                          // 是空的
                }
                if (obj == null || obj.GetType() != typeof(int)) return false; // 發生錯誤了
                int n = (int)obj;
                maxID = n;
                //cmd.CommandText = "SELECT Locked from dbo.SyncDeletedVersion Where DeletedID=" + n.ToString();
                //obj=cmd.ExecuteScalar();
                //if (obj == null || obj == DBNull.Value || obj.GetType() != typeof(bool))
                //    return false;    // 無法取得
                //if ((bool)obj == true) return false;   // 資料庫己鎖定
                //else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("取得<更新版本号>出錯,原因:" + ex.Message);
                return false;
            }
        }

        public static Dictionary<string,List<SqlColumnStruct>> GetTablesName(SqlConnection conn)
        {
            string cmdText = "Select SO.name from sysobjects SO where SO.xtype ='U' and SO.status>= 0";
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, conn);
            DataTable tables = new DataTable();
            try
            {
                adapter.Fill(tables);
            }
            catch (Exception ex)
            {
                MessageBox.Show("尋找表名出錯,原因:" + ex.Message);
                return null;
            }
            var list = new Dictionary<string,List<SqlColumnStruct>>();
            foreach (DataRow row in tables.Rows)
            {
                list.Add((string)row["name"],null);
            }
            return list;
        }

        public static Dictionary<string, int> GetTableID(SqlConnection conn)
        {
            var adapter = new SyncCloud.DamaiDataSetTableAdapters.SyncTableTableAdapter();
            var table=new SyncCloud.DamaiDataSet.SyncTableDataTable();
            var dic = new Dictionary<string, int>();
            try
            {
                adapter.Fill(table);
                foreach (var row in table) dic.Add(row.Name, row.TableID);
                return dic;
            }
            catch {  }
            return null;
        }

        static public bool CheckSyncTable(SqlConnection conn,string briefName)
        {
Retry:
            SqlCommand cmd = new SqlCommand("dbo.uspCheckSyncTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                object obj = cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 0xafc)
                {
                    if (MessageBox.Show(briefName+"沒有找到預存程序"+"[uspCheckSyncTable],是否建立?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (CreateStoredProcedure(StoredProcedureName.uspCheckSynTable, conn))
                            goto Retry;
                    }
                }
                else
                    MessageBox.Show("呼叫uspCheckSynctable時出錯,原因:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("呼叫uspCheckSynctable時出錯,原因:" + ex.Message);
            }
            return false;
        }

        public enum StoredProcedureName { uspCheckSynTable };
        static public bool CreateStoredProcedure(StoredProcedureName name,SqlConnection conn)
        {
            StringBuilder sb=new StringBuilder();
            string cmdTxt;
            switch (name)
            {
                case StoredProcedureName.uspCheckSynTable:
                     sb=new StringBuilder("CREATE PROCEDURE [dbo].[uspCheckSyncTable] AS\r\n");
                     sb.AppendLine("BEGIN");
                     sb.AppendLine("Declare @tableName nvarchar(50)");
                     sb.AppendLine("DECLARE @program nvarchar(512)");
	                 sb.AppendLine("DECLARE @maxID int");
	                 sb.AppendLine("DECLARE @result int");
	                 sb.AppendLine("SET NOCOUNT ON");
	                 sb.AppendLine("DECLARE My_Cursor Cursor");
	                 sb.AppendLine("FOR (Select SO.name from sysobjects SO where SO.xtype ='U' and SO.status>= 0) ORDER BY SO.name");
	                 sb.AppendLine("OPEN My_Cursor");
	                 sb.AppendLine("FETCH NEXT FROM My_Cursor INTO @tableName");
	                 sb.AppendLine("WHILE @@FETCH_STATUS =0");
	                 sb.AppendLine("BEGIN");
		             sb.AppendLine("    IF (@tableName not like '%Item') and (@tableName not like 'Sync%') and (@tableName not like '%Detail')");
                     sb.AppendLine("    BEGIN");
			         sb.AppendLine("    SET @result=(SELECT Count(Name) from SyncTable where Name=@tableName)");
			         sb.AppendLine("    IF (@result<=0)");
			         sb.AppendLine("        BEGIN");
			         sb.AppendLine("        Set @maxID=ISNULL((SELECT MAX(TableID) from SyncTable),0)+1");
				     sb.AppendLine("        INSERT INTO [dbo].[SyncTable] ([TableID],[Name]) Values(@maxID,@tableName)");
			         sb.AppendLine("        END");
		             sb.AppendLine("    END");
		             sb.AppendLine("    FETCH NEXT FROM My_Cursor INTO @tableName");
	                 sb.AppendLine("END");
	                 sb.AppendLine("CLOSE My_Cursor");
	                 sb.AppendLine("DEALLOCATE My_Cursor");
                     sb.AppendLine("END");
                     cmdTxt=sb.ToString();
                     break;
                default: MessageBox.Show("不知名字的Stored Procedure 程式錯誤!");
                         return false;
            }
            try
            {
                SqlCommand sc=new SqlCommand(cmdTxt,conn);
                sc.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("創建Stored Procedure<"+name.ToString()+">失敗,原因:"+ex.Message);
                return false;
            }
            return true;

        }

        public class SqlColumnStruct
        {
            public string TableName;
            public string Name;
            public bool   IsNullable;
            public Int16  Length;
            public SqlDbType DbType;
            public bool IsPrimaryKey=false;
            static public SqlDbType ConvertToDbType(string typeName)
            {
                int n = (int)(SqlDbType.DateTimeOffset);
                for(int i=0;i<=n;i++)
                {
                    SqlDbType t=(SqlDbType)i;
                    if (typeName.Equals(t.ToString(), StringComparison.InvariantCultureIgnoreCase))
                        return t;
                }
                return SqlDbType.Structured;   // 未知型態,指定 Structured
            }
        }

        static public List<SqlColumnStruct> GetStruct(string TableName, SqlConnection Db)
        {
            SqlDataAdapter adapter = null,primaryAdapter=null;
            string sqltxt = "SELECT SO.name 'TableName', SC.name 'Name', SC.isnullable 'IsNullable',SC.length 'Length',ST.name 'DbType'"+
                            " FROM sysobjects SO , syscolumns SC , systypes ST"+
                            " WHERE SO.name='"+ TableName + "'"+
                            " And SO.id = SC.id AND SO.xtype = 'U' AND SO.status >= 0 AND  SC.xtype = ST.xusertype  ORDER BY  SO.name , SC.colorder";
            string sqlFindPrimary="SELECT PrimaryColName=SC.name FROM sys.indexes IDX"
                          + " INNER JOIN sys.objects SO ON SO.[object_id]=IDX.[object_id] And SO.name='" + TableName+"'"
                          + " INNER JOIN sys.index_columns IDXC ON IDX.[object_id]=IDXC.[object_id] AND IDX.index_id=IDXC.index_id"
                          + " INNER JOIN sys.columns SC ON SO.[object_id]=SC.[object_id] AND SO.type='U' AND SO.is_ms_shipped=0 AND IDXC.column_id=SC.column_id"
	                      +" WHERE IDX.is_primary_key=1";
            List<SqlColumnStruct> list = new List<SqlColumnStruct>();
            try
            {
                primaryAdapter = new SqlDataAdapter(sqlFindPrimary, Db);
                DataTable priTable = new DataTable();
                primaryAdapter.Fill(priTable);
                var listPrimary=new List<string>();
                foreach (DataRow row in priTable.Rows)
                    listPrimary.Add((string)row["PrimaryColName"]);
                adapter = new SqlDataAdapter(sqltxt, Db);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table == null) return null;
                foreach (DataRow row in table.Rows)
                {
                    SqlColumnStruct col = new SqlColumnStruct();
                    col.TableName = (string)row["TableName"];
                    col.Name = (string)row["Name"];
                    col.IsNullable = ((int)row["IsNullable"] == 0) ? false : true;
                    col.Length = (Int16)row["Length"];
                    col.DbType = SqlColumnStruct.ConvertToDbType((string)row["DbType"]);
                    // 查出PrimaryKey
                    if (listPrimary.Contains(col.Name)) col.IsPrimaryKey = true;
                    list.Add(col);
                }
            }
            catch (Exception ex) { throw ex;          }
            finally { adapter.Dispose(); primaryAdapter.Dispose(); }

            return list;
        }

        static public bool SameStruct(string TableName, SqlConnection DB1, SqlConnection DB2)
        {
            SqlDataAdapter sda1 = null;
            SqlDataAdapter sda2 = null;
            string sqltxt = "SELECT SO.name 'TableName', SC.name 'Name', SC.isnullable 'IsNullable',SC.length 'Length',ST.name 'DbType' FROM sysobjects SO , syscolumns SC , systypes ST WHERE SO.name='"
                          + TableName + "' and SO.id = SC.id AND SO.xtype = 'U' AND   SO.status >= 0 AND  SC.xtype = ST.xusertype  ORDER BY  SO.name , SC.colorder";
            try
            {
                sda1 = new SqlDataAdapter(sqltxt, DB1);
                sda2 = new SqlDataAdapter(sqltxt, DB2);
                DataSet ds1 = new DataSet();
                DataSet ds2 = new DataSet();
                sda1.Fill(ds1);
                sda2.Fill(ds2);
                if (ds1 == null || ds2 == null)
                {
                    return false;
                }
                return TableIsSame(ds1.Tables[0], ds2.Tables[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sda1.Dispose();
                sda2.Dispose();
            }
        }

        static bool TableIsSame(DataTable dt1, DataTable dt2)
        {
            if (dt1 == null || dt2 == null)
            {
                return false;
            }
            if (dt1.Rows.Count != dt2.Rows.Count || dt1.Columns.Count != dt2.Columns.Count)
            {
                return false;
            }
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                for (int j = 0; j < dt1.Columns.Count; j++)
                {
                    if (dt1.Rows[i][j].ToString() != dt2.Rows[i][j].ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static string PrimaryKeyStandardOption=" WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY]";
        public enum SyncDataTable { SyncUpdatedVersion ,SyncTable,SyncMD5Old,SyncMD5Now};
        static public bool CreateDataTable(SyncDataTable tableName,SqlConnection conn)
        {
            string cmdStr;
            string name = tableName.ToString();
            switch (tableName)
            {
                case SyncDataTable.SyncUpdatedVersion:
                    cmdStr = "CREATE TABLE [dbo].[SyncUpdatedVersion] (";
                    cmdStr+= "  [DeletedID] [int] NOT NULL,[Locked] [bit],";
                    cmdStr+= "  CONSTRAINT [PK_Sync_UpdatedVersion] PRIMARY KEY CLUSTERED ( [DeletedID] ASC )" + PrimaryKeyStandardOption;
                    break;
                case SyncDataTable.SyncTable:
                    cmdStr = "CREATE TABLE [dbo].[SyncTable] (";
                    cmdStr+= "  [TableID] [int] NOT NULL,";
	                cmdStr+= "  [Name] [nvarchar](50) NOT NULL,";
	                cmdStr+= "  [MD5] [uniqueidentifier] NULL,";
	                cmdStr+= "  [RecordCount] [int] NULL,";
                    cmdStr+= "  CONSTRAINT [PK_SyncTable] PRIMARY KEY CLUSTERED ( [TableID] ASC )" + PrimaryKeyStandardOption;
                    break;
                case SyncDataTable.SyncMD5Old:
                    cmdStr = "CREATE TABLE [dbo].[SyncMD5Old](";
	                cmdStr+= "  [ID] [uniqueidentifier] NOT NULL,";
	                cmdStr+= "  [TableID] [int] NULL,";
	                cmdStr+= "  [PKInt] [int] NULL,";
	                cmdStr+= "  [PKUUID] [uniqueidentifier] NULL,";
                    cmdStr+= "  [MD5] [binary](16) NULL,";
                    cmdStr+= "  CONSTRAINT [PK_SyncMD5Old] PRIMARY KEY CLUSTERED ( [ID] ASC )"+ PrimaryKeyStandardOption;
                    break;
                case SyncDataTable.SyncMD5Now:
                    cmdStr = "CREATE TABLE [dbo].[SyncMD5Now](";
                    cmdStr += "  [ID] [uniqueidentifier] NOT NULL,";
                    cmdStr += "  [TableID] [int] NULL,";
                    cmdStr += "  [PKInt] [int] NULL,";
                    cmdStr += "  [PKUUID] [uniqueidentifier] NULL,";
                    cmdStr += "  [MD5] [binary](16) NULL,";
                    cmdStr += "  CONSTRAINT [PK_SyncMD5Now] PRIMARY KEY CLUSTERED ( [ID] ASC )" + PrimaryKeyStandardOption;
                    break;
                default:
                    MessageBox.Show("不知TableName[" + name + "] 程式錯誤!");
                    return false;
            }
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            try
            {
                object obj = cmd.ExecuteScalar();
                if (obj!=null)   
                {
                    MessageBox.Show("創建Sync用資料表["+name+"]出錯!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("創建Sync用資料表["+name+"]出錯,原因:" + ex.Message);
                return false;
            }
            return true;
        }

        static public bool DropTable(string name,SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("DROP TABLE [dbo].["+name+"]", conn);
            try
            {
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    MessageBox.Show("刪除資料表[" + name + "]出錯!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除資料表[" + name + "]出錯,原因:" + ex.Message);
                return false;
            }
            return true;
        }


        static public bool AskCreateDataTable(string prefix, SyncDataTable tableName, SqlConnection conn)
        {
            if (MessageBox.Show(prefix+"必需有["+tableName.ToString()+"]資料表! 要創建嗎?", "", MessageBoxButtons.YesNo) != DialogResult.Yes) return false;
            if (!CreateDataTable(tableName, conn)) return false;
            return true;
        }

        public enum RowStatus { Deleted, New, Changed,Unchanged };
        public class Md5Result
        {
            public Int64 PrimaryKey;  // Int64.Min 則PK 不為Int
            public Guid UniqueIdentifier;
            public byte[] Md5Old;
            public byte[] Md5Now;
            public RowStatus Status;
            public bool SameMd5()
            {
                if (Md5Old == null) return false;
                if (Md5Now == null) return false;
                if (Md5Old.Length != Md5Now.Length) return false;
                int len = Md5Old.Length;
                for (int i = 0; i < len; i++)
                    if (Md5Old[i] != Md5Now[i]) return false;
                return true;
            }
        }

        static string Bytes2Hex(byte[] bytes)
        {
            string str = "";
            foreach (byte b in bytes)
                str += b.ToString("X2");
            return str;
        }

        static public  List<Md5Result> CalcCompMd5(string tableName,SqlConnection conn,List<SqlColumnStruct> listStruct,Dictionary<string,int> IDLookupTable)
        {
            // 找出TableID
            if (!IDLookupTable.ContainsKey(tableName)) return null;
            int id = IDLookupTable[tableName];
            // 判斷主Key型態, 主Key中一有Guid就不理Int的部分,故只支援Int有複合主Key
            bool isPKInt = true;
            foreach (var col in listStruct)
            {
                if (col.IsPrimaryKey)
                {
                    if (col.DbType == SqlDbType.UniqueIdentifier)
                    {
                        isPKInt = false;
                        break;
                    }
                    else if (col.DbType == SqlDbType.Int || col.DbType == SqlDbType.SmallInt || col.DbType == SqlDbType.BigInt || col.DbType== SqlDbType.TinyInt) break;
                    else return null;     // PrimaryKey不是UUID也不是Int目前無支援
                }
            }
            // 載入Old
            var adapterOld = new DamaiDataSetTableAdapters.SyncMD5OldTableAdapter();
            adapterOld.Connection = conn;
            adapterOld.Adapter.SelectCommand = new SqlCommand("Select * from SyncMd5Old Where TableID=" + id.ToString());
            var tableOld = new DamaiDataSet.SyncMD5OldDataTable();
            var intResult = new Dictionary<Int64, Md5Result>();
            var guidResult = new Dictionary<Guid, Md5Result>();
            //var listResult = new List<Md5Result>();
            try
            {
                adapterOld.Fill(tableOld);
                foreach (var row in tableOld)
                {
                    Md5Result result = new Md5Result();
                    result.Md5Old = row.MD5;
                    result.Status = RowStatus.Unchanged;
                    if (isPKInt)
                    {
                        result.PrimaryKey = row.PKInt;
                        intResult.Add(result.PrimaryKey, result);
                    }
                    else
                    {
                        result.PrimaryKey = Int64.MinValue;
                        result.UniqueIdentifier = row.PKUUID;
                        guidResult.Add(result.UniqueIdentifier, result);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            // 計算New
            MD5 MD5Provider = new MD5CryptoServiceProvider();
            if (tableName.ToLower() == "order")    // [Order]的MD5量大,是由AP計算的
            {
                SqlDataAdapter adapterNow = new SqlDataAdapter("Select [ID],[MD5] From [" + tableName + "]", conn);
                DataTable table = new DataTable();
                try
                {
                    adapterNow.Fill(table);
                    // 填MD5Now入listResult
                    foreach (DataRow row in table.Rows)
                    {
                        int i = (int)row["ID"];
                        Int64 pk=(Int64)i;
                        if (intResult.Keys.Contains(pk))
                        {
                            Md5Result val = intResult[pk];
                            val.Md5Now = (byte[])row["MD5"];
                            if (!val.SameMd5()) val.Status=RowStatus.Changed;
                        }
                        else
                        {
                            Md5Result val = new Md5Result();
                            val.PrimaryKey = pk;
                            val.Md5Old = null;
                            val.Md5Now = (byte[])row["MD5"];
                            val.Status = RowStatus.New;
                            intResult.Add(pk, val);
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            else
            {
                SqlDataAdapter adapterNow = new SqlDataAdapter("Select * From [" + tableName + "]", conn);
                DataTable table = new DataTable();
                try
                {
                    adapterNow.Fill(table);
                    Int64 pkInt = 0;
                    Guid pkGuid=Guid.Empty;
                    foreach (DataRow row in table.Rows)
                    {
                        string str = "";
                        foreach (SqlColumnStruct st in listStruct)
                        {
                            str += "|";
                            object obj = row[st.Name];
                            if (obj == null || DBNull.Value == obj) continue; // Null不加入計算MD5
                            if (st.IsPrimaryKey)
                            {
                                if (isPKInt)
                                {
                                    if (st.DbType == SqlDbType.UniqueIdentifier) continue; // 不可能,跳過
                                    else
                                    {
                                        switch (st.DbType)
                                        {   // 所有Int型態的PrimaryKey都手工設置大於0, 此處才能正確
                                            case SqlDbType.Int:    pkInt    += (pkInt << 32) + (int)obj;   break;    
                                            case SqlDbType.BigInt: pkInt     = (Int64)obj; break;
                                            case SqlDbType.TinyInt: pkInt   += (pkInt << 8 ) + (byte)obj;   break;
                                            case SqlDbType.SmallInt: pkInt  += (pkInt << 16) + (Int16)obj; break;
                                            default:
                                                MessageBox.Show("無法辦認的PrimaryKey型態<" + st.DbType.ToString() + "> 欄位[" + st.Name + "]!"); break;
                                        }
                                    }
                                }
                                else
                                {
                                    if (st.DbType == SqlDbType.UniqueIdentifier)
                                    {
                                        pkInt = Int64.MinValue;
                                        pkGuid = (Guid)obj;   // 轉的成嗎???
                                    }
                                    else continue;    // PrimaryKey是Int卻有UniqueIdentifier,基本不可能,跳過
                                }

                            }
                            else
                                switch (st.DbType)
                                {
                                    case SqlDbType.UniqueIdentifier:
                                    case SqlDbType.SmallInt:
                                    case SqlDbType.TinyInt:
                                    case SqlDbType.BigInt:
                                    case SqlDbType.Int: str += obj.ToString(); break;
                                    case SqlDbType.Char:
                                    case SqlDbType.NChar:
                                    case SqlDbType.NVarChar:
                                    case SqlDbType.VarChar: str += obj.ToString(); break;
                                    case SqlDbType.Bit: str += (bool)obj ? '1' : '0'; break;   // bit被轉成bool
                                    case SqlDbType.Money:
                                    case SqlDbType.SmallMoney:
                                    case SqlDbType.Decimal: str += ((decimal)obj).ToString("N2"); break;
                                    case SqlDbType.Float: str += ((Double)obj).ToString("F4"); break;                      // float目前暫時用N4
                                    case SqlDbType.SmallDateTime:
                                    case SqlDbType.DateTime: str += ((DateTime)obj).ToString("yyyy-MM-dd hh:mm:ss"); break;
                                    case SqlDbType.Binary:
                                    case SqlDbType.VarBinary:
                                    case SqlDbType.Image:
                                                    byte[] bytes = (byte[])obj;
                                                    if (bytes.Length <= 32)
                                                        str += Bytes2Hex(bytes);
                                                    else
                                                        str += Bytes2Hex(MD5Provider.ComputeHash((byte[])obj)); break;    // Image算出MD5後轉成string
                                    default:
                                        throw new Exception("不支援計算MD5的型別<" + st.DbType.ToString() + "> 欄位[" + st.Name + "]!");
                                }
                        }
                        byte[] md5 = MD5Provider.ComputeHash(Encoding.Unicode.GetBytes(str));   // 還沒考慮Detail
                        if (isPKInt)
                        {
                            if (intResult.Keys.Contains(pkInt))
                            {
                                Md5Result val = intResult[pkInt];
                                val.Md5Now = md5;
                                if (!val.SameMd5()) val.Status=RowStatus.Changed;
                            }
                            else
                            {
                                Md5Result val   = new Md5Result();
                                val.PrimaryKey  = pkInt;
                                val.Md5Old      = null;
                                val.Md5Now      = md5;
                                val.Status      = RowStatus.New;
                                intResult.Add(pkInt, val);
                            }
                        }
                        else
                        {
                            if (guidResult.Keys.Contains(pkGuid))
                            {
                                Md5Result val = guidResult[pkGuid];
                                val.Md5Now = md5;
                                if (!val.SameMd5()) val.Status = RowStatus.Changed;
                            }
                            else
                            {
                                Md5Result val = new Md5Result();
                                val.PrimaryKey = Int64.MinValue;
                                val.UniqueIdentifier = pkGuid;
                                val.Md5Old = null;
                                val.Md5Now = md5;
                                val.Status = RowStatus.New;
                                guidResult.Add(pkGuid, val);
                            }
                        }
                    }
                }
                catch (Exception ex) { throw ex; }
            }
            if (isPKInt) return intResult.Values.ToList<Md5Result>();
            return guidResult.Values.ToList<Md5Result>();
        }

    }
}
