using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BankManager.classes;
using Connection_DB;
using MySql.Data.MySqlClient;

namespace BankManager
{
    public partial class calcot : UserControl
    {
        public calcot()
        {
            InitializeComponent();
        }
        connection con = new connection();
        List<employee_attended> employee = new List<employee_attended>();
        List<final_attend> finalatd = new List<final_attend>();


        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Account1_Load(object sender, EventArgs e)
        {

        }

        private void General_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }






        private void btnUpload_Click(object sender, EventArgs e)
        {
            

            string path = GetDatFileName();
            lblDatnew.Text = path;
            
            try
            {

                

            List<string> lines = File.ReadAllLines(path).ToList();
                lines.RemoveAt(0);
                
                //MessageBox.Show(lines[0] + "\n" + lines[1] +"\n" + lines[2], "output 0"); //to Debug
                
                foreach (var line in lines)
                {
                  
                    string[] entries = line.Split('\t');
                    //Double late_hrs = 0;
                    // Double ot_hrs = 0;

                    employee_attended emp = new employee_attended();

                    
                    emp.emp_id = entries[0];
                    emp.emp_id = emp.emp_id.Replace(" ", String.Empty);
                    string[] date_time = entries[1].Split(' ');
                    emp.date = date_time[0];


                    //MessageBox.Show( entries[0] + "," + entries[1] + "," + date_time[0] + "," + date_time[1]  , "output 1"); //to Debug

                    //time check
                    string[] timeVals = date_time[1].Split(':'); // timeVals[0]=hrs timeVals[1]=mins

                    //MessageBox.Show(timeVals[0] + ", " + timeVals[1], "output 2"); //to Debug

                    if (Int32.Parse(timeVals[0]) < 12)
                    {
                        emp.in_time = date_time[1];

                       // MessageBox.Show(emp.emp_id +" , "+emp.in_time, "obj vals In_T"); //to Debug
                        
                        string start_time= getStartTime(emp.emp_id);
                        string[] start_times = start_time.Split(':');
                        
                        //MessageBox.Show(start_times[0] + ", " + start_times[1], "output 3"); //to Debug
                        
                        emp.late_time= CalcStime(start_times[0], start_times[1], timeVals[0], timeVals[1]);

                    }
                    else
                    {
                        emp.out_time = date_time[1];
                        
                        //MessageBox.Show(emp.emp_id + " , " + emp.out_time, "obj vals OT"); //to Debug
                        
                        string ot_class = getOTClass(emp.emp_id);
                        string[] ot_classes = ot_class.Split(':'); //ot_classes[0] = hrs ot_classes[1] = mins
                       
                        //MessageBox.Show(ot_classes[0] + ", " + ot_classes[1], "output 3"); //to Debug
                        
                        emp.ot_hours = CalcStime(ot_classes[0], ot_classes[1], timeVals[0], timeVals[1]);
                    }

                    //MessageBox.Show(emp.emp_id + ", " + emp.date + ", " + emp.in_time + ", " + emp.out_time + ", " + " Delay : " + emp.late_time.ToString() + ", OT: " + emp.ot_hours.ToString(), "Output") ; //To Debug

                    employee.Add(emp);
                }
                pbox.Visible = false;
                MessageBox.Show("Data Added Successfully!", " DAT Upload");
                btnimport.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }






        private string GetDatFileName()
        {
            // Create Open File Dialog with the correct filter
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "dat-file (*.dat) | *.dat";

                string fileNameAndFolder = "";
                pbox.Visible = true;
                // Get file plus folder.
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileNameAndFolder = ofd.FileName;
                    
                }
                else
                {
                    pbox.Visible = false;
                }

                // Return the fileName;
                return fileNameAndFolder;
            }
        }

        private string getStartTime(string empid)
        {
            empid = empid.Replace(" ", String.Empty);
            string SelQuery = "SELECT start_time from employee where emp_id='"+ empid +"';";
            string StartTime = "";

            try
            {
                con.Open();

                MySqlDataReader mr;

                mr = con.ExecuteReader(SelQuery);     


                if (mr.HasRows)
                {
                    mr.Read();// Get first record.
                    StartTime = mr.GetString(0);// Get value of first column as string.
                }
                else
                {
                    StartTime = "11:59";
                }
                con.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return StartTime;
        }

        private string getOTClass(string empid)
        {
            empid = empid.Replace(" ", String.Empty);
            string SelQuery = "SELECT ot_class from employee where emp_id='" + empid + "';";
            string OTClass = "";

            try
            {
                con.Open();

                MySqlDataReader mr;

                mr = con.ExecuteReader(SelQuery);


                if (mr.HasRows)
                {
                    mr.Read();// Get first record.
                    OTClass = mr.GetString(0);// Get value of first column as string.
                }
                else
                {
                    OTClass = "23:59";
                }
                con.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return OTClass;
        }
        
        private Double CalcStime(string hr1,string min1,string hr2,string min2) {
            Double lateMins=0;

            try
            {
                Double hrs = Convert.ToDouble(hr1);
                Double hre = Convert.ToDouble(hr2);
                Double mins = Convert.ToDouble(min1);
                Double mine = Convert.ToDouble(min2);

                if(hre<hrs)
                {
                    lateMins = 0;
                }
                else if (hre==hrs)
                {
                    if(mins==mine)
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

       

        private void btnimport_Click(object sender, EventArgs e)
        {
            pbox.Visible = true;

            DialogResult dialogResult = MessageBox.Show("All employees should be registered with 'Employee management' with a valid Employee ID, OT Class and a Start-Time\nNote that table mismatches may result mislead information\n\nThis action can't be undone! Import Data? ", "Import Data", MessageBoxButtons.YesNo);

            //con.Open();
            if (dialogResult == DialogResult.Yes)
            {
                

                //add final object array data to sql tables
                foreach (var emp in employee)
                {
                    //double ot_hrs= calcOTTime(emp.late_time,emp.ot_hours);
                    if (string.IsNullOrEmpty(emp.in_time)) //out
                    {
                        string que1 = "select emp_id from attend_out where emp_id="+emp.emp_id+" and date='"+emp.date+"';";

                        try
                        {
                            con.Open();

                            MySqlDataReader MyReader1;

                            MyReader1 = con.ExecuteReader(que1);
                            //MessageBox.Show("Successfully executed query!"); //to Debug
                            


                            if (MyReader1.HasRows)
                            {
                                //string queadd = "update attend_out set out_time='" + emp.out_time + "', ot_mins='" + emp.ot_hours + "';";
                                con.Close();
                                //checkAttendTableQuery(queadd);
                                //MessageBox.Show(emp.emp_id + " already in Out time! updated!"); //to Debug
                            }
                            else
                            {
                                string queadd = "insert into attend_out values( '" + emp.emp_id + "','" + emp.date + "','" + emp.out_time + "','" + emp.ot_hours + "');";
                                con.Close();
                                checkAttendTableQuery(queadd);
                                //MessageBox.Show(emp.emp_id +" Successfully  added to out time!"); //to Debug
                            }
                        
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                    else if (string.IsNullOrEmpty(emp.out_time)) //in
                    {
                        string que2 = "select emp_id from attend_im where emp_id=" + emp.emp_id + " and date='" + emp.date + "';";

                        try
                        {
                            con.Open();

                            MySqlDataReader MyReader2;

                            MyReader2 = con.ExecuteReader(que2);
                            //MessageBox.Show("Successfully executed query!"); //to Debug
                            


                            if (MyReader2.HasRows)
                            {
                                //MessageBox.Show(emp.emp_id + " Already in In Time! Updated!!"); //to Debug
                                con.Close();
                            }
                            else
                            {
                                string queadd = "insert into attend_im values( '" + emp.emp_id + "','" + emp.date + "','" + emp.in_time + "','" + emp.late_time + "');";
                                con.Close();
                                checkAttendTableQuery(queadd);
                               // MessageBox.Show(emp.emp_id + " Successfully  added to in time!"); //to Debug
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not updating in_table or out_table"); //to Debug
                    }
                    

                }

                updateAttendTable();
                updateGrid();
                lblnext.Text=updateLastDate();
                employee.Clear();
                lblDatnew.Text = "No file selected";
            }
            else
            {
                pbox.Visible = false;
            }

           
        }

        private void updateAttendTable()
        {
            finalatd.Clear();
            string quein = "select attend_im.emp_id , attend_im.date , attend_im.in_time , attend_im.late_mins , attend_out.out_time , attend_out.ot_mins from attend_im,attend_out where attend_im.emp_id=attend_out.emp_id and attend_im.date = attend_out.date; ";

            try
            {
                con.Open();

                MySqlDataReader MyReader3;

                MyReader3 = con.ExecuteReader(quein);
             

                if (MyReader3.HasRows)
                {
                    while (MyReader3.Read())
                    {
                        final_attend atdfnl = new final_attend();

                        atdfnl.empid = MyReader3.GetString(0);
                        atdfnl.empdate = MyReader3.GetString(1);
                        atdfnl.empintime = MyReader3.GetString(2);
                        double latemins = Convert.ToDouble(MyReader3.GetString(3));
                        atdfnl.empouttime = MyReader3.GetString(4);
                        double otmins = Convert.ToDouble(MyReader3.GetString(5));


                        //calculate ot minutes
                        double ottime = calcOTTime(latemins, otmins);

                        //convert to ot hours
                        ottime = (ottime / 60);
                        atdfnl.ottime = Convert.ToDouble(ottime.ToString("0.##"));



                        finalatd.Add(atdfnl);
                    }

                    con.Close();
                }

                else
                {
                    MessageBox.Show("Data not imported from in table and out table!"); //to Debug
                }

                foreach (var atd in finalatd)
                {
                    con.Open();
                    MySqlDataReader queadd;

                    string queaddrows = "insert into attend values( '" + atd.empid + "','" + atd.empdate + "','" + atd.empintime + "','" + atd.empouttime + "','" + atd.ottime + "');";

                    queadd = con.ExecuteReader(queaddrows);

                    con.Close();

                   // MessageBox.Show("Attend Row added!"); //to Debug
                }
                pbox.Visible = false;
                MessageBox.Show("Suuccessfully Updated!"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void checkAttendTableQuery(string Query)
        {
            try
            {
                con.Open();
                MySqlDataReader MyReader;

                MyReader = con.ExecuteReader(Query);
                //MessageBox.Show("Successfully executed query!"); //to Debug
                con.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
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




        private void updateGrid()
        {

            try
            {
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                DataTable table = new DataTable();

                string sqlSelectAll = "SELECT * from attend";

                MyDA.SelectCommand = con.ExecuteCmd(sqlSelectAll);

                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dfTable.DataSource = bSource;
                //close connection
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataFleTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calcot_Load(object sender, EventArgs e)
        {
            updateGrid();
            lblTo.Text=updateLastDate();

        }

        private string updateLastDate()
        {
            string lbl = "";
            try
            {

                string Query = "select date from attend order by date asc limit 1;";

                con.Open();

                MySqlDataReader MyReader;

                MyReader = con.ExecuteReader(Query);


                if (MyReader.HasRows)
                {
                    MyReader.Read();// Get first record.
                    string[] datest = MyReader.GetString(0).Split(' ');
                    lbl = datest[0];// Get value of first column as string.
                }

                con.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lbl;
        }

        private void calcOTTimeIn()
        {
            string todate = tdatePick.Value.ToString("yyyy-MM-dd");
            string fromdate = fdatePick.Value.ToString("yyyy-MM-dd");
            try
            {

                string Query = "select ot_hours from attend where emp_id='"+ txtempidot.Text+"' and date between '"+ fromdate +"' and '"+ todate +"';";
                double totalot = 0;
                string empnamein = "Not assigned";
                string empdeptin = "Not assigned";

                con.Open();

                MySqlDataReader MyReader;

                MyReader = con.ExecuteReader(Query);
                

                if (MyReader.HasRows)
                {
                    while (MyReader.Read()){
                        totalot += Convert.ToDouble(MyReader.GetString(0));
                    }
   
                }
                con.Close();

                double otrate = Convert.ToDouble(txthr.Text);

                double amountpay = totalot * otrate;
 
                try
                {
                    string nameque = "select name,department from employee where emp_id='" + txtempidot.Text + "';";
                 

                    con.Open();
                    MySqlDataReader otemp;

                    otemp = con.ExecuteReader(nameque);
                    
                    if (otemp.HasRows)
                    {
                        otemp.Read();
                            empnamein = otemp.GetString(0);
                            empdeptin = otemp.GetString(1);
     

                    }
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                lblempname.Text = empnamein;
                lblempdept.Text = empdeptin;
                lblempothrs.Text = totalot.ToString();
                lblemppay.Text = amountpay.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblnext_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnresetot_Click(object sender, EventArgs e)
        {
            txtempidot.Text = "";
            lblempdept.Text = "";
            lblempname.Text = "";
            lblempothrs.Text = "";
            lblemppay.Text = "";
        }

        private void btnGenot_Click(object sender, EventArgs e)
        {
            calcOTTimeIn();
        }

        private void pbox_Click(object sender, EventArgs e)
        {

        }
    }
}
