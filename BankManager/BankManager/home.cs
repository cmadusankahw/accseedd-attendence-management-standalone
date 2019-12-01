using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection_DB;
using MySql.Data.MySqlClient;


namespace BankManager
{
    public partial class homecontrol : UserControl
    {
        public homecontrol()
        {
            InitializeComponent();
        }
        connection con = new connection();


        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void homecontrol_Load(object sender, EventArgs e)
        {
            try
            {

                string Query = "select count(emp_id) from employee";
                string Query2 = "select date from attend order by date asc limit 1;";

                con.Open();



                MySqlDataReader MyReader;

                MyReader = con.ExecuteReader(Query);

                if (MyReader.HasRows)
                {
                    MyReader.Read();// Get first record.
                    lblcount.Text  = MyReader.GetString(0);// Get value of first column as string.
                }
                con.Close();

                con.Open();
                MyReader = con.ExecuteReader(Query2);

                if (MyReader.HasRows)
                {
                    MyReader.Read();// Get first record.
                    string[] datest = MyReader.GetString(0).Split(' ');
                    lbldate.Text = datest[0];// Get value of first column as string.
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }
    }
}
