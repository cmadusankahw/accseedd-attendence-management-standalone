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
    public partial class user : UserControl
    {
        public user()
        {
            InitializeComponent();
        }
        connection con = new connection();

        private void updateGrid()
        {
            
            try
            {
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                DataTable table = new DataTable();

                string sqlSelectAll = "SELECT * from user";

                MyDA.SelectCommand = con.ExecuteCmd(sqlSelectAll);

                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                empTable.DataSource = bSource;
                //close connection
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        



        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            { 
     
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into user(username,role,password) values('" + this.txtuser.Text + "','" + this.comborole.Text + "','" + this.txtpword.Text +"');";
                con.Open();
   
                MySqlDataReader MyReader2;

                MyReader2 = con.ExecuteReader(Query);     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Successfully aded!");
                updateGrid();

                while (MyReader2.Read())
                {
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            resetFields();
        }

        private void user_Load(object sender, EventArgs e)
        {

            updateGrid();
            resetFields();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            try
            {

                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "update user set role='" + this.comborole.Text + "',password='" + this.txtpword.Text + "';";
                con.Open();

                MySqlDataReader MyReader2;

                MyReader2 = con.ExecuteReader(Query);     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Successfully updated!");
                updateGrid();
                while (MyReader2.Read())
                {
                    
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            resetFields();

        }

        private void empTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            txtuser.Enabled = false;
            btnupdate.Enabled = true;
            btnremove.Enabled = true;
            
            if (empTable.SelectedCells.Count > 0)
            {
                int ri = empTable.CurrentCell.RowIndex;
                int ci = empTable.CurrentCell.ColumnIndex;
                string unameSel = empTable.Rows[ri].Cells[0].Value.ToString();
                string roleSel = empTable.Rows[ri].Cells[1].Value.ToString();
                string pwordSel = empTable.Rows[ri].Cells[2].Value.ToString();


                txtuser.Text = unameSel;
                txtpword.Text = pwordSel;
                comborole.Text = roleSel;
            }

            

            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            
            try
            {

                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "delete from  user where username='"+ this.txtuser.Text+"';";
               
                con.Open();

                MySqlCommand cmd=new MySqlCommand();
                MySqlDataReader MyReader2;

                cmd.CommandText = "SELECT COUNT(*) FROM user";
                Int32 count = (Int32)cmd.ExecuteScalar();

                if (count>1)
                {
                    MyReader2 = con.ExecuteReader(Query);     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Successfully removed entry " + this.txtuser.Text + " !");


                    while (MyReader2.Read())
                    {

                    }
                }
                else
                {
                    MessageBox.Show("At least one User should be remained!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            resetFields();

          
        }

        private void resetFields()
        {
            txtuser.Text = "";
            txtpword.Text = "";
            comborole.Text = "";
            btnremove.Enabled = false;
            btnupdate.Enabled = false;

        }

        private void empTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetFields();
        }
    }
}
