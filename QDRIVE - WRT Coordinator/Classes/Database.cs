using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QDRIVE___WRT_Coordinator
{
    public class Database
    {
        public static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbwrtcoordinator.accdb";

        public static DialogResult MessageBoxError(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SHOW THIS TO ADMINISTRATOR:\n\n");
            sb.Append("MESSAGE:\n");
            sb.Append(e.Message + "\n\n");
            sb.Append("BASE EXCEPTION:\n");
            sb.Append(e.GetBaseException());

            return MessageBox.Show(sb.ToString(), "QDRIVE - WRT Coordinator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        public static int SelectStatementInt(string selectItem, string table, string whereClause, int whereItem)
        {
            int answer = 0;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} WHERE {2} = @whereItem", selectItem, table, whereClause);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereItem", OleDbType.Integer).Value = whereItem;

                    conn.Open();
                    answer = Convert.ToInt32(cmdSelect.ExecuteScalar());
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static int SelectStatementInt(string selectItem, string table, string whereClause, string whereItem)
        {
            int answer = 0;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} WHERE {2} = @whereItem", selectItem, table, whereClause);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereItem", OleDbType.WChar).Value = whereItem;

                    conn.Open();
                    answer = Convert.ToInt32(cmdSelect.ExecuteScalar());
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static int SelectStatementInt(string selectItem, string table, string whereClause, string whereClause2, int whereItem, object whereItem2)
        {
            int answer = 0;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} WHERE {2} = @whereItem AND {3} = @whereItem2", selectItem, table, whereClause, whereClause2);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereItem", OleDbType.Integer).Value = whereItem;
                    cmdSelect.Parameters.AddWithValue("@whereItem2", OleDbType.Integer).Value = whereItem2;

                    conn.Open();
                    answer = Convert.ToInt32(cmdSelect.ExecuteScalar());
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static int SelectStatementInt(string selectItem, string table, string table2, string onClause1, string onClause2, string andClause, object whereValue)
        {
            int answer = 0;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} INNER JOIN {2} ON ({3} = {4} AND {5} = @whereValue)", selectItem, table, table2, onClause1, onClause2, andClause);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereValue", OleDbType.IUnknown).Value = whereValue;

                    conn.Open();
                    answer = Convert.ToInt32(cmdSelect.ExecuteScalar());
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static double SelectStatementDub(string selectItem, string table, string whereClause, int whereItem)
        {
            double answer = 0.0;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} WHERE {2} = @whereItem", selectItem, table, whereClause);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereItem", OleDbType.Integer).Value = whereItem;

                    conn.Open();
                    answer = Convert.ToDouble(cmdSelect.ExecuteScalar());
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static string SelectStatementString(string selectItem, string table, string whereClause, int whereItem)
        {
            string answer = null;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} WHERE {2} = @whereItem", selectItem, table, whereClause);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereItem", OleDbType.Integer).Value = whereItem;

                    conn.Open();
                    answer = cmdSelect.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static string SelectStatementString(string selectItem, string table, string table2, string onClause1, string onClause2, string andClause, object whereValue)
        {
            string answer = null;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} INNER JOIN {2} ON ({3} = {4} AND {5} = @whereValue)", selectItem, table, table2, onClause1, onClause2, andClause);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereValue", OleDbType.IUnknown).Value = whereValue;

                    conn.Open();
                    answer = cmdSelect.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static string SelectStatementString(string selectItem, string table, string table2, string table3, string onClause1, string onClause2, string onClause3, string onClause4,
           string whereClause1, string whereClause2, object whereValue1, object whereValue2)
        {
            string answer = null;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} INNER JOIN ({2} INNER JOIN {3} ON ({4} = {5})) ON ({6} = {7}) WHERE {8} = @whereValue1 AND {9} = @whereValue2",
                        selectItem, table, table2, table3, onClause1, onClause2, onClause3, onClause4, whereClause1, whereClause2);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereValue1", OleDbType.IUnknown).Value = whereValue1;
                    cmdSelect.Parameters.AddWithValue("@whereValue2", OleDbType.IUnknown).Value = whereValue2;

                    conn.Open();
                    answer = cmdSelect.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static List<int> SelectStatementList(string selectItem, string table, string whereClause, int whereItem)
        {
            OleDbDataReader reader;
            List<int> answer = new List<int>();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} WHERE {2} = @whereItem", selectItem, table, whereClause);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereItem", OleDbType.Integer).Value = whereItem;

                    conn.Open();
                    reader = cmdSelect.ExecuteReader();
                    while (reader.Read())
                        answer.Add(reader.GetInt32(0));
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static List<int> SelectStatementList(string selectItem, string table)
        {
            OleDbDataReader reader;
            List<int> answer = new List<int>();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1}", selectItem, table);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);

                    conn.Open();
                    reader = cmdSelect.ExecuteReader();
                    while (reader.Read())
                        answer.Add(reader.GetInt32(0));
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static List<string> SelectStatementList(string selectItem, string table, string table2, string table3, string onClause1, string onClause2, string onClause3, string onClause4,
   string whereClause1, string whereClause2, object whereValue1, object whereValue2)
        {
            OleDbDataReader reader;
            List<string> answer = new List<string>();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string select = String.Format("SELECT {0} FROM {1} INNER JOIN ({2} INNER JOIN {3} ON ({4} = {5})) ON ({6} = {7}) WHERE {8} = @whereValue1 AND {9} = @whereValue2",
                        selectItem, table, table2, table3, onClause1, onClause2, onClause3, onClause4, whereClause1, whereClause2);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereValue1", OleDbType.IUnknown).Value = whereValue1;
                    cmdSelect.Parameters.AddWithValue("@whereValue2", OleDbType.IUnknown).Value = whereValue2;

                    conn.Open();
                    reader = cmdSelect.ExecuteReader();
                    while (reader.Read())
                        answer.Add(reader.GetString(0));
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }

            return answer;
        }

        public static void DeleteStatement(String table, String deleteItem, int value)
        {
            String delete = String.Format("DELETE FROM {0} WHERE {1} = @value", table, deleteItem);

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    OleDbCommand cmdDelete = new OleDbCommand(delete, conn);
                    cmdDelete.Parameters.AddWithValue("@value", OleDbType.Integer).Value = value;
                    conn.Open();
                    cmdDelete.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void updateStatement(string table, string updateItem, string whereClause, object updateValue, object whereValue)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string update = String.Format("UPDATE {0} SET {1} = @updateValue WHERE {2} = @whereValue", table, updateItem, whereClause);
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@updateValue", OleDbType.IUnknown).Value = updateValue;
                    cmdUpdate.Parameters.AddWithValue("@whereValue", OleDbType.IUnknown).Value = whereValue;
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void updateStatement(string table, string updateItem1, string updateItem2, string whereClause,
            object updateValue1, object updateValue2, object whereValue)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string update = String.Format("UPDATE {0} SET {1} = @updateValue1, {2} = @updateValue2 WHERE {3} = @whereValue",
                        table, updateItem1, updateItem2, whereClause);
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@updateValue1", OleDbType.IUnknown).Value = updateValue1;
                    cmdUpdate.Parameters.AddWithValue("@updateValue2", OleDbType.IUnknown).Value = updateValue2;
                    cmdUpdate.Parameters.AddWithValue("@whereValue", OleDbType.IUnknown).Value = whereValue;
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void updateStatement(string table, string updateItem1, string updateItem2, string updateItem3, string whereClause,
    object updateValue1, object updateValue2, object updateValue3, object whereValue)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string update = String.Format("UPDATE {0} SET {1} = @updateValue1, {2} = @updateValue2, {3} = @updateValue3 WHERE {4} = @whereValue",
                        table, updateItem1, updateItem2, updateItem3, whereClause);
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@updateValue1", OleDbType.IUnknown).Value = updateValue1;
                    cmdUpdate.Parameters.AddWithValue("@updateValue2", OleDbType.IUnknown).Value = updateValue2;
                    cmdUpdate.Parameters.AddWithValue("@updateValue3", OleDbType.IUnknown).Value = updateValue3;
                    cmdUpdate.Parameters.AddWithValue("@whereValue", OleDbType.IUnknown).Value = whereValue;
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void updateStatement(string table, string updateItem1, string updateItem2, string updateItem3,
    string updateItem4, string whereClause, object updateValue1, object updateValue2, object updateValue3, object updateValue4,
    int whereValue)
        {
            string update = String.Format("UPDATE {0} SET {1} = @updateValue1, {2} = @updateValue2, {3} = @updateValue3, " +
                "{4} = @updateValue4 WHERE {5} = @whereValue", table, updateItem1, updateItem2, updateItem3, updateItem4,
                 whereClause);

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@updateValue1", OleDbType.IUnknown).Value = updateValue1;
                    cmdUpdate.Parameters.AddWithValue("@updateValue2", OleDbType.IUnknown).Value = updateValue2;
                    cmdUpdate.Parameters.AddWithValue("@updateValue3", OleDbType.IUnknown).Value = updateValue3;
                    cmdUpdate.Parameters.AddWithValue("@updateValue4", OleDbType.IUnknown).Value = updateValue4;
                    cmdUpdate.Parameters.AddWithValue("@whereValue", OleDbType.IUnknown).Value = whereValue;
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void updateStatement(string table, string updateItem1, string updateItem2, string updateItem3,
    string updateItem4, string updateItem5, string whereClause, object updateValue1, object updateValue2, object updateValue3, object updateValue4,
    object updateValue5, int whereValue)
        {
            string update = String.Format("UPDATE {0} SET {1} = @updateValue1, {2} = @updateValue2, {3} = @updateValue3, " +
                "{4} = @updateValue4, {5} = @updateValue5 WHERE {6} = @whereValue", table, updateItem1, updateItem2, updateItem3, updateItem4,
                updateItem5, whereClause);

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@updateValue1", OleDbType.IUnknown).Value = updateValue1;
                    cmdUpdate.Parameters.AddWithValue("@updateValue2", OleDbType.IUnknown).Value = updateValue2;
                    cmdUpdate.Parameters.AddWithValue("@updateValue3", OleDbType.IUnknown).Value = updateValue3;
                    cmdUpdate.Parameters.AddWithValue("@updateValue4", OleDbType.IUnknown).Value = updateValue4;
                    cmdUpdate.Parameters.AddWithValue("@updateValue5", OleDbType.IUnknown).Value = updateValue5;
                    cmdUpdate.Parameters.AddWithValue("@whereValue", OleDbType.IUnknown).Value = whereValue;
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void updateStatement(string table, string updateItem1, string updateItem2, string updateItem3,
            string updateItem4, string updateItem5, string updateItem6, string whereClause, object updateValue1, object updateValue2, object updateValue3, object updateValue4,
            object updateValue5, object updateValue6, int whereValue)
        {
            string update = String.Format("UPDATE {0} SET {1} = @updateValue1, {2} = @updateValue2, {3} = @updateValue3, " +
                "{4} = @updateValue4, {5} = @updateValue5, {6} = @updateValue6 WHERE {7} = @whereValue", table, updateItem1, updateItem2, updateItem3, updateItem4,
                updateItem5, updateItem6, whereClause);

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@updateValue1", OleDbType.IUnknown).Value = updateValue1;
                    cmdUpdate.Parameters.AddWithValue("@updateValue2", OleDbType.IUnknown).Value = updateValue2;
                    cmdUpdate.Parameters.AddWithValue("@updateValue3", OleDbType.IUnknown).Value = updateValue3;
                    cmdUpdate.Parameters.AddWithValue("@updateValue4", OleDbType.IUnknown).Value = updateValue4;
                    cmdUpdate.Parameters.AddWithValue("@updateValue5", OleDbType.IUnknown).Value = updateValue5;
                    cmdUpdate.Parameters.AddWithValue("@updateValue6", OleDbType.IUnknown).Value = updateValue6;
                    cmdUpdate.Parameters.AddWithValue("@whereValue", OleDbType.IUnknown).Value = whereValue;
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void updateStatementDualWhere(string table, string updateItem1, string whereClause1, string whereClause2,
    object updateValue1, int whereValue, int whereValue2)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string update = String.Format("UPDATE {0} SET {1} = @updateValue1 WHERE {2} = @whereValue1 AND {3} = @whereValue2",
                        table, updateItem1, whereClause1, whereClause2);
                    OleDbCommand cmdUpdate = new OleDbCommand(update, conn);
                    cmdUpdate.Parameters.AddWithValue("@updateValue1", OleDbType.IUnknown).Value = updateValue1;
                    cmdUpdate.Parameters.AddWithValue("@whereValue1", OleDbType.IUnknown).Value = whereValue;
                    cmdUpdate.Parameters.AddWithValue("@whereValue2", OleDbType.IUnknown).Value = whereValue2;
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void insertStatement(string table, string insertItem1, string insertItem2, string insertItem3, string insertItem4,
     object insertValue1, object insertValue2, object insertValue3, object insertValue4)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string insert = String.Format("INSERT INTO {0} ({1}, {2}, {3}, {4}) VALUES (@insertValue1, @insertValue2, @insertValue3, " +
                        "@insertValue4)", table, insertItem1, insertItem2, insertItem3, insertItem4);
                    OleDbCommand cmdInsert = new OleDbCommand(insert, conn);
                    cmdInsert.Parameters.AddWithValue("@insertValue1", OleDbType.IUnknown).Value = insertValue1;
                    cmdInsert.Parameters.AddWithValue("@insertValue2", OleDbType.IUnknown).Value = insertValue2;
                    cmdInsert.Parameters.AddWithValue("@insertValue3", OleDbType.IUnknown).Value = insertValue3;
                    cmdInsert.Parameters.AddWithValue("@insertValue4", OleDbType.IUnknown).Value = insertValue4;
                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }

        public static void insertStatement(string table, string insertItem1, string insertItem2, string insertItem3, string insertItem4,
            string insertItem5, object insertValue1, object insertValue2, object insertValue3, object insertValue4, object insertValue5)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    string insert = String.Format("INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}) VALUES (@insertValue1, @insertValue2, @insertValue3, " +
                        "@insertValue4, @insertValue5)", table, insertItem1, insertItem2, insertItem3, insertItem4, insertItem5);
                    OleDbCommand cmdInsert = new OleDbCommand(insert, conn);
                    cmdInsert.Parameters.AddWithValue("@insertValue1", OleDbType.IUnknown).Value = insertValue1;
                    cmdInsert.Parameters.AddWithValue("@insertValue2", OleDbType.IUnknown).Value = insertValue2;
                    cmdInsert.Parameters.AddWithValue("@insertValue3", OleDbType.IUnknown).Value = insertValue3;
                    cmdInsert.Parameters.AddWithValue("@insertValue4", OleDbType.IUnknown).Value = insertValue4;
                    cmdInsert.Parameters.AddWithValue("@insertValue5", OleDbType.IUnknown).Value = insertValue5;
                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBoxError(e);
                }
            }
        }
    }


}
