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
    public partial class deleteorder : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
        
        public deleteorder()
        {
            InitializeComponent();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string deleteorder = "delete from [order] where orderID=" + this.textBox_ID.Text;
            SqlCommand cmd = new SqlCommand(deleteorder, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Order deleted successfully");
            textBox_ID.Text = " ";
        }
        private void buttonback_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
