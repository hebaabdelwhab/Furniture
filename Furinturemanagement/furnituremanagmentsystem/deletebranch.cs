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
    public partial class deletebranch : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
        
        public deletebranch()
        {
            InitializeComponent();
        }

        private void button_DEL_Click(object sender, EventArgs e)
        {
            con.Open();
            string deletebranch = "delete from branch where Br_ID=" + this.textBox_del_id.Text;
            SqlCommand cmd = new SqlCommand(deletebranch, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Branch deleted successfully");
            textBox_del_id.Text = " ";
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
