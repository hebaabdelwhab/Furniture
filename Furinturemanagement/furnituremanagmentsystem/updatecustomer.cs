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
    public partial class updatecustomer : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
        
        public updatecustomer()
        {
            InitializeComponent();
        }

        private void buttoncheck_Click(object sender, EventArgs e)
        { 
            
            panel_id_check.Visible = false;
            panel_upcust.Visible = true;
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            string update_customer = @"update Customer set Cu_Name='" + textBox_name.Text + "',Cu_Address='" + textBox_address.Text + "',Cu_Telephone='" + textBox_telephone.Text + "',Cu_Email='" + textBox_mail.Text + "',Cu_username='" + textBox_username + "',Cu_password='" + textBox_password.Text + "',Cu_credit_Card_Number='" + textBox_credit.Text + "'where Cu_ID='" + textBox_id_cust + "'";
            SqlCommand cmd = new SqlCommand(update_customer, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer data successfully updated");

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void panel_upcust_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_id_cust_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
