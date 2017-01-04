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
    }
}
