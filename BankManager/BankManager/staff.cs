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
    public partial class txtContact : UserControl
    {
        public txtContact()
        {
            InitializeComponent();
        }
        connection con = new connection();


        private void updateGrid()
        {

            try
            {
                con.Open();
                MySqlDataAdapter MyDA2 = new MySqlDataAdapter();
                DataTable table2 = new DataTable();

                string sqlSelectemp = "SELECT * from employee";

                MyDA2.SelectCommand = con.ExecuteCmd(sqlSelectemp);

                MyDA2.Fill(table2);

                BindingSource bSource2 = new BindingSource();
                bSource2.DataSource = table2;

                empTbl.DataSource = bSource2;
                //close connection
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Double CalcStime(string hr1, string min1, string hr2, string min2)
        {
            Double lateMins = 0;

            try
            {
                Double hrs = Convert.ToDouble(hr1);
                Double hre = Convert.ToDouble(hr2);
                Double mins = Convert.ToDouble(min1);
                Double mine = Convert.ToDouble(min2);

                if (hre < hrs)
                {
                    lateMins = 0;
                }
                else if (hre == hrs)
                {
                    if (mins == mine)
                    {
                        lateMins = 0;
                    }
                    else
                    {
                        lateMins = mine - mins;
                    }
                }
                else
                {
                    lateMins = (hre - hrs) * 60 + (mine - mins);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lateMins;
        }

        private double calcOTTime(double late_time, double ot_hours)
        {
            double ot_mins = ot_hours - late_time;

            if (ot_mins > 0)
            {
                return ot_mins;
            }
            else
            {
                return 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmpid.Text=="" | txtName.Text=="")
            {
                MessageBox.Show("Employee ID and Name should be provided!");
                return;
            }
            try
            {

                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into employee(emp_id,nic,name,gender,contact,department,ot_class,start_time,reg_date) values('" + 
                    this.txtEmpid.Text + "','" + 
                    this.txtNIC.Text + "','" + 
                    this.txtName.Text + "','" +
                    this.comboGender.Text + "','" +
                    this.txtContactno.Text + "','" +
                    this.comboDept.Text + "','" +
                    this.comboOT.Text + "','" +
                    this.combostart.Text + "','" +
                    this.regdatePicker.Value.Date.ToString("yyyyMMdd") + "');"; //date convertion check

                string Queryotclass = "select in_time,out_time from attend where emp_id='" + this.txtEmpid.Text + "';";

                string QueryAttend = "update attend set ot_hours=";

                con.Open();

                MySqlDataReader MyReader2;
                
                //adding new row to employee table
                using (MyReader2 = con.ExecuteReader(Query))
                {
                    while (MyReader2.Read())
                    {

                    }
                }

                MessageBox.Show("Successfully Added!");

                //DialogResult dialogResult = MessageBox.Show("Employee Successfully Added!\n generate past OT for the employee?", "Generate OT", MessageBoxButtons.YesNo);

                //if (dialogResult == DialogResult.Yes)
                //{
                //    //ot calculation foe existing rows

                //    //getting start time and ot class of the employee
                //    string[] ot = this.comboOT.Text.Split(':');
                //    string[] st = this.combostart.Text.Split(':');

                //    double othr = Convert.ToDouble(ot[0]);
                //    double otmin = Convert.ToDouble(ot[1]);

                //    double sthr = Convert.ToDouble(st[0]);
                //    double stmin = Convert.ToDouble(st[1]);

                //    List<double> inhr = new List<double>();
                //    List<double> inmin = new List<double>();
                //    List<double> outhr = new List<double>();
                //    List<double> outmin = new List<double>();


                //    //getting in_time and out_time of the employee
                //    using (MyReader2 = con.ExecuteReader(Queryotclass))
                //    {
                //        if (MyReader2.HasRows)
                //        {
                //            while (MyReader2.Read())
                //            {
                //                string[] intimes = MyReader2.GetString(0).Split(':');
                //                inhr.Add(Convert.ToDouble(intimes[0]));
                //                inmin.Add(Convert.ToDouble(intimes[1]));

                //                string[] outtimes = MyReader2.GetString(1).Split(':');
                //                outhr.Add(Convert.ToDouble(outtimes[0]));
                //                outmin.Add(Convert.ToDouble(outtimes[1]));

                //            }


                //        }
                //        else
                //        {
                //            MessageBox.Show("No past OT data found for the added Employee!!");
                //        }
                        
                    //}


                    

                //}

                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            resetFields();
            updateGrid();
     
        }

        private void txtContact_Load(object sender, EventArgs e)
        {
            updateGrid();
            resetFields();
            getDepartments();
            getOTClasses();
            getStartTimes();

        }

        private void resetFields()
        {
            txtEmpid.Text = "";
            txtName.Text = "";
            txtNIC.Text = "";
            txtContactno.Text = "";
            comboDept.Text = "";
            comboGender.Text = "";
            comboOT.Text = "";
            combostart.Text = "";
            btnremoveemp.Enabled = false;
            btnupdateemp.Enabled = false;
            regdatePicker.Enabled = true;
            txtEmpid.Enabled = true;
           

        }

        private void getDepartments()
        {
            string query = "select dept from departments";
            getDataTable(query, comboDept,"dept");
        }

        private void getOTClasses()
        {
            string query = "select class_time from ot_classes";
            getDataTable(query, comboOT,"class_time");
        }

        private void getStartTimes()
        {
            string query = "select start_time from start_times";
            getDataTable(query, combostart,"start_time");
        }

        private void getDataTable(string Query,ComboBox combo,string colname)
        {
            try
            {
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                DataTable ds = new DataTable();


                MyDA.SelectCommand = con.ExecuteCmd(Query);

                MyDA.Fill(ds);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = ds;

                combo.Items.Clear();

                foreach (DataRow dr in ds.Rows)
                {
                    
                    combo.Items.Add(dr[colname]);
                }
              
            
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdateemp_Click(object sender, EventArgs e)
        {
            try
            {

                
                string Query = "update employee set nic= '" +
                    this.txtNIC.Text + "', name='" +
                    this.txtName.Text + "', gender='" +
                    this.comboGender.Text + "', contact='" +
                    this.txtContactno.Text + "', department='" +
                    this.comboDept.Text + "', ot_class='" +
                    this.comboOT.Text+"', start_time='" +
                    this.combostart.Text + "' where emp_id="+txtEmpid.Text+";";  

                con.Open();

                MySqlDataReader MyReader2;
                
                MyReader2 = con.ExecuteReader(Query);
                MessageBox.Show("Successfully Updated!");

               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            resetFields();
            updateGrid();
        }

        private void empTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpid.Enabled = false;
            btnremoveemp.Enabled = true;
            btnupdateemp.Enabled = true;
            regdatePicker.Enabled = false;

            if (empTbl.SelectedCells.Count > 0)
            {
                int ri = empTbl.CurrentCell.RowIndex;
                string empidSel = empTbl.Rows[ri].Cells[0].Value.ToString();
                string empnicSel = empTbl.Rows[ri].Cells[1].Value.ToString();
                string empnameSel = empTbl.Rows[ri].Cells[2].Value.ToString();
                string empgenderSel = empTbl.Rows[ri].Cells[3].Value.ToString();
                string empcontactSel = empTbl.Rows[ri].Cells[4].Value.ToString();
                string empdeptSel= empTbl.Rows[ri].Cells[5].Value.ToString();
                string empotSel = empTbl.Rows[ri].Cells[6].Value.ToString();
                string startSel = empTbl.Rows[ri].Cells[7].Value.ToString();



                txtEmpid.Text = empidSel;
                txtName.Text = empnameSel;
                txtNIC.Text = empnicSel;
                txtContactno.Text = empcontactSel;
                comboDept.Text = empdeptSel;
                comboGender.Text = empgenderSel;
                comboOT.Text = empotSel;
                combostart.Text = startSel;
               
            }

        }

        private void btnremoveemp_Click(object sender, EventArgs e)
        {
            try
            {

                string Query = "delete from  employee where emp_id='" + this.txtEmpid.Text + "';";

                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader MyReader2;
                
                DialogResult delResult = MessageBox.Show("Sure want to Delete Entry " + this.txtEmpid.Text +" ?", "Delete Record", MessageBoxButtons.YesNo);
                if (delResult == DialogResult.Yes)
                {
                    MyReader2 = con.ExecuteReader(Query);
                    MessageBox.Show("Successfully removed entry " + this.txtEmpid.Text + " !");
                }
               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            resetFields();
            updateGrid();

        }

        private void btnresetemp_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void comboDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboDept_Click(object sender, EventArgs e)
        {
            getDepartments();
           
        }

        private void comboOT_Click(object sender, EventArgs e)
        {
            getOTClasses();
            
        }

        private void combostart_Click(object sender, EventArgs e)
        {
            getStartTimes();
        }

        private void txtEmpid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNIC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void combostart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
