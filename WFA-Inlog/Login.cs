using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Inlog
{
    public partial class Login : Form
    {
        String query = "";
        public Login()
        {
            InitializeComponent();
            Row1.Dock = DockStyle.Top;
            Row2.Dock = DockStyle.Bottom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            DataTable tbLogin = new DataTable();
            query = $"SELECT COUNT (*) FROM [dbo].[User] WHERE USERNAME='"+ usernameField.Text + "'";
            tbLogin = Global.executeSqlGetDataTable(query, "DatabaseName");
            if(tbLogin.Rows[0][0].ToString()== "1")
            {
                this.Hide();
                Table f2 = new Table();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username");
            }

        }

        private void usernameField_Enter(object sender, EventArgs e)
        {
            if (usernameField.Text == "Username") 
            {
                usernameField.Text = "";

                usernameField.ForeColor = Color.LightSlateGray;
            }
        }

        private void usernameField_Leave(object sender, EventArgs e)
        {
            if (usernameField.Text == "") 
            {
                usernameField.Text = "Username";

                usernameField.ForeColor = Color.LightSlateGray;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Password")
            {
                passwordField.Text = "";

                passwordField.ForeColor = Color.LightSlateGray;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Password";
                

            }
        }

        private void subText_Click(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
