using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BankManager
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            homecontrol1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //this.Left = (Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2);
           // this.Top = (Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
            //TopMost = true;
            
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;


            this.lbluser.Text = loginForm.unamemain;
           
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure want to Exit?", "Exit System", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
               

        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            //button2.BackColor = Color.Black;
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            homecontrol1.BringToFront();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Acconts_Click(object sender, EventArgs e)
        {
            staff1.BringToFront();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Acc1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
       
          
            calcot.BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            loanuc2.BringToFront();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            user1.BringToFront();
            

        }

    

        private void Transforms1_Load(object sender, EventArgs e)
        {

        }

        private void calcot_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            sett1.BringToFront();
        }

        private void sett1_Load(object sender, EventArgs e)
        {

        }
    }
}
