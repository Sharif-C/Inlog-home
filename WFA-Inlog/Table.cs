using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Inlog
{
    public partial class Table : Form
    {
        String query = "";


 
        public Table()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            DataTable dtTestTable = new DataTable();

            query = $"SELECT * FROM [dbo].[User]";
            dtTestTable = Global.executeSqlGetDataTable(query, "Databasenaam");

            gcUsers.DataSource = dtTestTable;
        }

        private void gcUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
