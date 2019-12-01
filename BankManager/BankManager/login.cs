using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection_DB;
using MySql.Data.MySqlClient;

namespace BankManager
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        connection con = new connection();

        public static string unamemain;

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUname.Text != "" && txtPword.Text != "")
                {

                    con.Open();
                    string query = "select username,password from user WHERE username ='" + txtUname.Text + "' AND password ='" + txtPword.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        main m = new main();
                        unamemain = txtUname.Text;
                        m.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password! Try Again!", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
