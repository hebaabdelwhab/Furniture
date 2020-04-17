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
    public partial class deletecustomer : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
        
        public deletecustomer()
        {
            InitializeComponent();
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            con.Open();
            string deleteCustomeer = "delete from Customer where Cu_ID=" + this.textBox_ID.Text;
            SqlCommand cmd = new SqlCommand(deleteCustomeer, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Customer account deleted successfully");
            textBox_ID.Text = " ";
        }
        private void buttonback_Click_1(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
    }
}
