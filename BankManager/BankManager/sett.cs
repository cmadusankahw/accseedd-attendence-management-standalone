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
    public partial class sett : UserControl
    {
        public sett()
        {
            InitializeComponent();
        }
        connection con = new connection();

        private void btnupdatesql_Click(object sender, EventArgs e)
        {

        }

        private void adddept_Click(object sender, EventArgs e)
        {

            try
            {

                string Query = "insert into departments(dept) values('" +txtdeptadd.Text+ "');";
                con.Open();

                MySqlDataReader MyReader2;

                MyReader2 = con.ExecuteReader(Query);     
                MessageBox.Show("Successfully aded!");

               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateDeptGrid();
            txtdeptadd.Text = "";
        }

        private void addot_Click(object sender, EventArgs e)
        {
            
        }

        private void addstart_Click(object sender, EventArgs e)
        {
           
        }

        private void updateDeptGrid()
        {

            try
            {
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                DataTable table = new DataTable();

                string sqlSelectAll = "SELECT dept from departments";

                MyDA.SelectCommand = con.ExecuteCmd(sqlSelectAll);

                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                DeptView.DataSource = bSource;
                //close connection
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateOTGrid()
        {

            try
            {
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                DataTable table = new DataTable();

                string sqlSelectAll = "SELECT class_time from ot_classes";

                MyDA.SelectCommand = con.ExecuteCmd(sqlSelectAll);

                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                otview.DataSource = bSource;
                //close connection
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void updatestartGrid()
        {

            try
            {
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                DataTable table = new DataTable();

                string sqlSelectAll = "SELECT start_time from start_times";

                MyDA.SelectCommand = con.ExecuteCmd(sqlSelectAll);

                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                startview.DataSource = bSource;
                //close connection
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnremovedept_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = DeptView.CurrentCell.RowIndex;
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "delete from  departments where dept='" + DeptView.Rows[rowindex].Cells[0].Value.ToString() + "';";

                con.Open();

    
                MySqlDataReader MyReader2;

                 MyReader2 = con.ExecuteReader(Query);     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Successfully removed entry " + DeptView.Rows[rowindex].Cells[0].Value.ToString() + " !");

          

                con.Close();
                updateDeptGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnupdatedept.Enabled = false;
            btnremovedept.Enabled = false;
        }

        private void sett_Load(object sender, EventArgs e)
        {
            updateDeptGrid();
            updateOTGrid();
            updatestartGrid();
        }

        private void btnremoveot_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = otview.CurrentCell.RowIndex;
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "delete from  ot_classes where class_time='" + otview.Rows[rowindex].Cells[0].Value.ToString() + "';";

                con.Open();


                MySqlDataReader MyReader2;

      
                    MyReader2 = con.ExecuteReader(Query);     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Successfully removed entry " + otview.Rows[rowindex].Cells[0].Value.ToString() + " !");

              
                con.Close();
                updateOTGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnremoveot.Enabled = false;
            btnupdateot.Enabled = false;
        }

        private void startremove_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = startview.CurrentCell.RowIndex;
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "delete from  start_times where start_time='" + startview.Rows[rowindex].Cells[0].Value.ToString() + "';";

                con.Open();

                MySqlDataReader MyReader2;

               
                    MyReader2 = con.ExecuteReader(Query);     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Successfully removed entry " + startview.Rows[rowindex].Cells[0].Value.ToString() + " !");

              
                con.Close();
                updatestartGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            startremove.Enabled = false;
            startupdate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = DeptView.CurrentCell.RowIndex;
            int columnindex = DeptView.CurrentCell.ColumnIndex;

            string seldept = DeptView.Rows[rowindex].Cells[columnindex].Value.ToString();

            string Query = "update departments set dept='" + txtdeptadd.Text + "' where dept='" + seldept + "';";
            string Query2 = "update employee set department='" + txtdeptadd.Text + "' where department='" + seldept + "';";

            try
            {

                
                con.Open();

                MySqlDataReader MyReader;

                using (MyReader = con.ExecuteReader(Query))
                {
                    while (MyReader.Read())
                    {
                       
                    }
                }
                using (MyReader = con.ExecuteReader(Query2))
                {
                    while (MyReader.Read())
                    {

                    }
                }

                    MessageBox.Show("Successfully Updated!");


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateDeptGrid();
            txtdeptadd.Text = "";
            btnupdatedept.Enabled = false;
            btnremovedept.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnaddot_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "insert into ot_classes(class_time) values('" + txtotadd.Text + "');";
                con.Open();

                MySqlDataReader MyReader2;

                MyReader2 = con.ExecuteReader(Query);
                MessageBox.Show("Successfully aded!");


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateOTGrid();
            txtotadd.Text = "";
        }

        private void startadd_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "insert into start_times(start_time) values('" + txtstartadd.Text + "');";
                con.Open();

                MySqlDataReader MyReader2;

                MyReader2 = con.ExecuteReader(Query);
                MessageBox.Show("Successfully aded!");


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updatestartGrid();
            txtstartadd.Text = "";
        }
        

        private void btnupdateot_Click(object sender, EventArgs e)
        {


           int rowindex = otview.CurrentCell.RowIndex;
           int columnindex = otview.CurrentCell.ColumnIndex;

                string selot = otview.Rows[rowindex].Cells[columnindex].Value.ToString();

            string last_date = "last updated";

            string Query = "update ot_classes set class_time='" + txtotadd.Text + "' where class_time='" + selot + "';";
            string Query2 = "update employee set ot_class='" + txtotadd.Text + "' where ot_class='" + selot + "';";
            string Query3 = "select date from attend order by date asc limit 1;";

            try
            {


                con.Open();

                MySqlDataReader MyReader;

                using (MyReader = con.ExecuteReader(Query3))
                {
                    if (MyReader.HasRows)
                    {
                        MyReader.Read();// Get first record.
                        string[] datest = MyReader.GetString(0).Split(' ');
                        last_date = datest[0];
                    }
                }


                DialogResult dialogResult = MessageBox.Show("If you update the OT Class, it will affect for all employees OT calculations from "+ last_date+ ".\n Are you sure want to update?", "Update OT Class", MessageBoxButtons.YesNo);

                //con.Open();
                if (dialogResult == DialogResult.Yes)
                {
                    using (MyReader = con.ExecuteReader(Query))
                    {
                        while (MyReader.Read())
                        {

                        }
                    }
                    using (MyReader = con.ExecuteReader(Query2))
                    {
                        while (MyReader.Read())
                        {

                        }
                    }
                    MessageBox.Show("Successfully Updated!");

                }




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateOTGrid();
            txtotadd.Text = "";
        }

        private void DeptView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = DeptView.CurrentCell.RowIndex;
            int columnindex = DeptView.CurrentCell.ColumnIndex;

            string seldept = DeptView.Rows[rowindex].Cells[columnindex].Value.ToString();

            txtdeptadd.Text = seldept;

            btnremovedept.Enabled = true;
            btnupdatedept.Enabled = true;

        }

        private void startview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = startview.CurrentCell.RowIndex;
            int columnindex = startview.CurrentCell.ColumnIndex;

            string selstart = startview.Rows[rowindex].Cells[columnindex].Value.ToString();

            txtstartadd.Text = selstart;

            startupdate.Enabled = true;
            startremove.Enabled = true;
        }

        private void otview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = otview.CurrentCell.RowIndex;
            int columnindex = otview.CurrentCell.ColumnIndex;

            string selot = otview.Rows[rowindex].Cells[columnindex].Value.ToString();

            txtotadd.Text = selot;

            btnremoveot.Enabled = true;
            btnupdateot.Enabled = true;
        }

        private void startupdate_Click(object sender, EventArgs e)
        {
            int rowindex = startview.CurrentCell.RowIndex;
            int columnindex = startview.CurrentCell.ColumnIndex;

            string selstart = startview.Rows[rowindex].Cells[columnindex].Value.ToString();

            string last_date = "last updated";

            string Query = "update start_times set start_time='" + txtstartadd.Text + "' where start_time='" + selstart + "';";
            string Query2 = "update employee set start_time='" + txtstartadd.Text + "' where start_time='" + selstart + "';";
            string Query3 = "select date from attend order by date asc limit 1;";

            try
            {


                con.Open();

                MySqlDataReader MyReader;

                using (MyReader = con.ExecuteReader(Query3))
                {

                    if (MyReader.HasRows)
                    {
                        MyReader.Read();// Get first record.
                        string[] datest = MyReader.GetString(0).Split(' ');
                        last_date = datest[0];
                    }
                }


                DialogResult dialogResult = MessageBox.Show("If you update the Start Time, it will affect for all employees OT calculations from " + last_date + ".\n Are you sure want to update?", "Update Start Time", MessageBoxButtons.YesNo);

                //con.Open();
                if (dialogResult == DialogResult.Yes)
                {

                    using (MyReader = con.ExecuteReader(Query))
                    {
                        while (MyReader.Read())
                        {

                        }
                    }
                    using (MyReader = con.ExecuteReader(Query2))
                    {
                        while (MyReader.Read())
                        {

                        }
                    }
                    MessageBox.Show("Successfully Updated!");

                }




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updatestartGrid();
            txtotadd.Text = "";

            startremove.Enabled = false;
            startupdate.Enabled = false;
        }
    }
}
