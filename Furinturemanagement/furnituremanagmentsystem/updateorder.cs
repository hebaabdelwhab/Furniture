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
    public partial class updateorder : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
        
        public updateorder()
        {
            InitializeComponent();
        }

        private void btn_UPorder_Click(object sender, EventArgs e)
        {
            con.Open();
            string update_order = @"update [order] set Ord_Cu_ID='" + txtbox_id_cust.Text + "',Ord_Amount='" + textbox_amount.Text + "' where Ord_ID='" + textBox7.Text + "'";
            SqlCommand cmd = new SqlCommand(update_order, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully update");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelcheck.Visible=false;
            panelupdate.Visible=true;
            con.Close();
        } 
        private void btn_back_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
        private void buttonback_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
