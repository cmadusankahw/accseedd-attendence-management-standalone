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
using DGVPrinterHelper;
using System.IO;





//consider from date and to date for queries

namespace BankManager
{
    public partial class find : UserControl
    {
        public find()
        {
            InitializeComponent();
        }
        connection con = new connection();

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectSql();
        }



        private void resetFields()
        {
            txtempidfind.Text = "";
            txtempnamefind.Text = "";
            combodeptfind.Text = "";
            combootclassfind.Text = "";
       
        }

        private void getEmpList()
        {
            string todate = toDate.Value.ToString("yyyy-MM-dd");
            string fromdate = fDate.Value.ToString("yyyy-MM-dd");
          
            string qeid = "select attend.emp_id, employee.name, employee.department, employee.ot_class, attend.ot_hours from employee,attend where attend.emp_id='" + txtempidfind.Text + "' and employee.emp_id=attend.emp_id and attend.date between '" + fromdate + "' and '" + todate + "';";
            updateGrid(qeid);
            //resetFields();


        }

        private void getEmpSummaryList()
        {
            string todate = toDate.Value.ToString("yyyy-MM-dd");
            string fromdate = fDate.Value.ToString("yyyy-MM-dd");

            string qeid = "select distinct attend.emp_id, employee.name, employee.department, employee.ot_class,ROUND(SUM(attend.ot_hours),2) as 'Total OT Hours',count(attend.emp_id) as 'Days Attended' from employee,attend where attend.emp_id='" + txtempidfind.Text + "' and employee.emp_id=attend.emp_id and attend.date between '" + fromdate + "' and '" + todate + "' group by attend.emp_id;";
            updateGrid(qeid);
            //resetFields();


        }

        private void getDeptList()
        {
            string todate = toDate.Value.ToString("yyyy-MM-dd");
            string fromdate = fDate.Value.ToString("yyyy-MM-dd");

            string qeid = "select distinct attend.emp_id, employee.name, employee.department, employee.ot_class,ROUND(SUM(attend.ot_hours),2) as 'Total OT Hours',count(attend.emp_id) as 'Days Attended' from employee,attend where employee.emp_id=attend.emp_id and attend.date between '" + fromdate + "' and '" + todate + "' and employee.department='"+ combodeptfind.Text+"' group by attend.emp_id;";

            updateGrid(qeid);
            resetFields();


        }

        private void getEmpNameList()
        {
            string todate = toDate.Value.ToString("yyyy-MM-dd");
            string fromdate = fDate.Value.ToString("yyyy-MM-dd");

            string qeid = "select attend.emp_id, employee.name, employee.department, employee.ot_class, attend.ot_hours,ROUND(SUM(attend.ot_hours),2) as 'Total OT Hours',count(attend.emp_id) as 'Days Attended' from employee,attend where employee.name like '" + txtempnamefind.Text + "' and employee.emp_id=attend.emp_id and attend.date between '" + fromdate + "' and '" + todate + "' group by attend.emp_id;";

           
            updateGrid(qeid);
            resetFields();


        }

        private void getEmpOtClassList()
        {
            string todate = toDate.Value.ToString("yyyy-MM-dd");
            string fromdate = fDate.Value.ToString("yyyy-MM-dd");

            string qeid = "select distinct attend.emp_id, employee.name, employee.department, employee.ot_class,ROUND(SUM(attend.ot_hours),2) as 'Total OT Hours',count(attend.emp_id) as 'Days Attended' from employee,attend where employee.emp_id=attend.emp_id and attend.date between '" + fromdate + "' and '" + todate + "' and employee.ot_class='" + combootclassfind.Text + "' group by attend.emp_id;";

         
            updateGrid(qeid);
            resetFields();


        }



        private void selectSql()
        {
     
            if (radioempname.Checked == true)
            {
                getEmpNameList();
            }
            else if (radioempid.Checked == true)
            {
                if (radiolisted.Checked == true)
                {
                    getEmpList();
                }
                else 
                {
                    getEmpSummaryList();
                }

            }
            else if (radiodept.Checked == true)
            {
                getDeptList();
            }
            else if (radiootclass.Checked == true)
            {
                getEmpOtClassList();
            }
       
        }

        private void radioempid_CheckedChanged(object sender, EventArgs e)
        {
            selectText();

        }
        private void selectText()
        {

            if (radioempname.Checked == true)
            {
                txtempnamefind.Enabled = true;
                txtempidfind.Enabled = false;
                combodeptfind.Enabled = false;
                combootclassfind.Enabled = false;
                radiolisted.Visible = false;
                radiosummary.Visible = false;
            }
            else if (radioempid.Checked == true)
            {
                txtempnamefind.Enabled = false;
                txtempidfind.Enabled = true;
                combodeptfind.Enabled = false;
                combootclassfind.Enabled = false;
                radiolisted.Visible = true;
                radiosummary.Visible = true;
            }
            else if (radiodept.Checked == true)
            {
                txtempnamefind.Enabled = false;
                txtempidfind.Enabled = false;
                combodeptfind.Enabled = true;
                combootclassfind.Enabled = false;
                radiolisted.Visible = false;
                radiosummary.Visible = false;
            }
            else if (radiootclass.Checked == true)
            {
                txtempnamefind.Enabled = false;
                txtempidfind.Enabled = false;
                combodeptfind.Enabled = false;
                combootclassfind.Enabled = true;
                radiolisted.Visible = false;
                radiosummary.Visible = false;
            }
          
        }

        private void find_Load(object sender, EventArgs e)
        {
            resetFields();
            txtempnamefind.Enabled = false;
            txtempidfind.Enabled = true;
            combodeptfind.Enabled = false;
            combootclassfind.Enabled = false;
            radioempid.Checked = true;
            getDepartments();
            getOTClasses();
            findTbl.Rows.Clear();
            findTbl.Refresh();
            radiolisted.Checked = true;
        }

  
    

        private void getDepartments()
        {
            string query = "select dept from departments";
            getDataTable(query, combodeptfind, "dept");
        }

        private void getOTClasses()
        {
            string query = "select class_time from ot_classes";
            getDataTable(query, combootclassfind, "class_time");
        }

        private void getDataTable(string Query, ComboBox combo, string colname)
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

        private void radioempname_CheckedChanged(object sender, EventArgs e)
        {
            selectText();

        }

        private void radiodept_CheckedChanged(object sender, EventArgs e)
        {
            selectText();

        }

        private void radiootclass_CheckedChanged(object sender, EventArgs e)
        {
            selectText();
        }

        private void updateGrid(string Query)
        {

            try
            {
                con.Open();
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                DataTable table = new DataTable();

                MyDA.SelectCommand = con.ExecuteCmd(Query);

                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                findTbl.DataSource = bSource;
                //close connection
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResetfind_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void combodeptfind_Click(object sender, EventArgs e)
        {
            getDepartments();
        }

        private void combootclassfind_Click(object sender, EventArgs e)
        {
            getOTClasses();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string todate = toDate.Value.ToString("yyyy-MM-dd");
            string fromdate = fDate.Value.ToString("yyyy-MM-dd");

            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Employee Attendence Report";

            printer.SubTitle = "Attendence and OT Report from" + fromdate + " to " + todate;

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "Report by Accseedd";

            printer.FooterSpacing = 15;



            printer.PrintDataGridView(findTbl);
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
          
            
           var sb = new StringBuilder();

            var headers = findTbl.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in findTbl.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog1.Filter = filter;
            StreamWriter writer = null;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filter = saveFileDialog1.FileName;
                writer = new StreamWriter(filter);

                writer.WriteLine(sb.ToString());

                writer.Close();
            }
        }
    }
}
