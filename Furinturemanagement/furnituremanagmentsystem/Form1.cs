using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace furnituremanagmentsystem
{
    public partial class Form1 : Form
    {
       // bool loggedIn = false;
        bool ismenupanelopen = false;
        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            homecontrol1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = productbtn.Height;
            sidepanel.Top = productbtn.Top;
            timer1.Start(); //to open timer
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ismenupanelopen)  //case that close menu
            {
                menupanel1.Height -= 20;
                if (menupanel1.Height == 0)
                {
                    timer1.Stop();
                    ismenupanelopen=false;
                }
            }
            else   //open menu
            {
                menupanel1.Height += 20;
                if (menupanel1.Height == 260)
                {
                    timer1.Stop();
                    ismenupanelopen = true;
                }
            }
        }

        private void memberbtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = memberbtn.Height;
            sidepanel.Top = memberbtn.Top;
            memberControl1.BringToFront();
        }
        private void homebtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            homecontrol1.BringToFront();
        }
        
        //private void tablebtn_click(object sender, EventArgs e)
        //{
        //    tableControl11.BringToFront();
        //}    
        //private void sofabtn_click(object sender, EventArgs e)
        //{
        //    sofaControl1.BringToFront();
        //}
        //private void chairbtn_click(object sender, EventArgs e)
        //{
        //    chairControl1.BringToFront();
        //}
        //private void bedbtn_click(object sender, EventArgs e)
        //{
        //    bedControl1.BringToFront();
        //}

        private void aboutControl1_Load(object sender, EventArgs e)
        {

        }

        private void homebtn_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            homecontrol1.BringToFront();


        }

      

        private void tablebutton_Click(object sender, EventArgs e)
        {
            tableControl11.BringToFront();
        }

        private void sofabutton_Click(object sender, EventArgs e)
        {
            sofaControl1.BringToFront();
        }

        
       

        private void menupanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void memberControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userLoggedBtn_Click(object sender, EventArgs e)
        {

            if (global.GlobalLoggedUserId != 0)
            {
                userLoggedBtn.Text = global.GlobalLoggedUserName;
            }
            else
            {
                userLoggedBtn.Text = "No user signed in";

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            global.GlobalLoggedUserId = 0;
            global.GlobalLoggedCustomer = false;
            global.GlobalLoggedAdmin = false;
            global.GlobalLoggedUserName = "";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void contactUsbtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = contactUsbtn.Height;
            sidepanel.Top = contactUsbtn.Top;
            contactUScontrol11.BringToFront();
        }
                    

    }
}
