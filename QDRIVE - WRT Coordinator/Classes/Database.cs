using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace QDRIVE___WRT_Coordinator
{
    public class Database
    {
        public static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbwrtcoordinator.accdb";
        
        public static int SelectStatement(String selectItem, String table, String whereClause, int whereItem)
        {
            int answer;
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    String select = String.Format("SELECT {0} FROM {1} WHERE {2} = @whereItem", selectItem, table, whereClause);
                    OleDbCommand cmdSelect = new OleDbCommand(select, conn);
                    cmdSelect.Parameters.AddWithValue("@whereItem", OleDbType.Integer).Value = whereItem;

                    conn.Open();
                    answer = Convert.ToInt32(cmdSelect.ExecuteScalar());
                }

                return answer;
        }

        public static void DeleteStatement(String table, String deleteItem, int value)
        {
            String delete = String.Format("DELETE FROM {0} WHERE {1} = @value", table, deleteItem);

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmdDelete = new OleDbCommand(delete, conn);
                cmdDelete.Parameters.AddWithValue("@value", OleDbType.Integer).Value = value;
                conn.Open();
                cmdDelete.ExecuteNonQuery();
            }
        }

        public static void InsertStatement(object[] dbItems, object[] values, String table, String whereClause, int whereItem)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT ");
            int counter = 1;

            sb.Append("INTO");
            sb.Append(table);
            foreach (int i in dbItems)
            {
                sb.Append(i);
                counter++;
                if (counter < dbItems.Length)
                    sb.Append(", ");
                else
                    sb.Append(") ");
            }
            sb.Append("VALUES (");

            counter = 1;
            foreach (int j in values)
            {
                sb.Append(j);
                counter++;
                if (counter < values.Length)
                    sb.Append(", ");
                else
                    sb.Append(") ");
            }
            sb.Append(")");

          /*  using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmdInsert = new OleDbCommand(sb.ToString(), conn);
                foreach(int i in values)
                {
                    cmdInsert.Parameters.AddWithValue(i, )
                }
            }*/

        }
    }


}
