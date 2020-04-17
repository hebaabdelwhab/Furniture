using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace furnituremanagmentsystem
{
    public partial class addcustomer : UserControl
    {
        
        
        public addcustomer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            if (textBox_name.Text == "" || textBox_address.Text == "" || textBox_telephone.Text == "" || textBox_mail.Text == "" || textBox_username.Text == "" || textBox_password.Text == "" || textBox_credit.Text == "") {
                errorLbl.Visible = true;
                errorLbl.Text = "Please fill all fields";
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
            con.Open();
            string addcustomer = @"insert into [dbo].[Customer] (Cu_Name,Cu_Address,Cu_Telephone,Cu_Email,Cu_username,Cu_password,Cu_feedback,Cu_credit_Card_Number)values('" + this.textBox_name.Text + "','" + this.textBox_address.Text + "','" + this.textBox_telephone.Text + "','" + this.textBox_mail.Text + "','" + this.textBox_username.Text + "','" + textBox_password.Text + "','" + "NULL" + "','" + this.textBox_credit.Text + "')";
            SqlCommand cmd = new SqlCommand(addcustomer, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer account added successfully");
          
            textBox_name.Text = " ";
            textBox_address.Text = " ";
            textBox_telephone.Text = " ";
            textBox_mail.Text = " ";
            textBox_username.Text = " ";
            textBox_password.Text = " ";
           
            textBox_credit.Text=" ";
            con.Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addcustomer_Load(object sender, EventArgs e)
        {
            errorLbl.Visible = false;
        }
    }
}
