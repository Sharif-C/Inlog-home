using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace WFA_Inlog
{
    public static class Global
    {

        public static DataTable executeSqlGetDataTable(string query, string db)
        {
            
            string conST = "Data Source = ServerName; Initial Catalog = " + db + "; Integrated Security = True";

            SqlConnection conSt = new SqlConnection(conST);
            SqlCommand commandST = new SqlCommand(query, conSt);
            SqlDataAdapter da = new SqlDataAdapter(commandST);
            DataTable TestTable = new DataTable();
            da.Fill(TestTable);

            return TestTable;
        }

    }
}
