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
    public partial class addorder : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
       
        public addorder()
        {
            InitializeComponent();
        }

        private void btn_addorder_Click(object sender, EventArgs e)
        {
            con.Open();
            string addorder = @"insert into [order] values("+txtbox_id_cust.Text + ",'" + textbox_amount.Text + "')";
            SqlCommand cmd = new SqlCommand(addorder, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Order added successfully");
           
            txtbox_id_cust.Text = " ";
            textbox_amount.Text = " ";
           
        }
        private void buttonback_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
    }
}
