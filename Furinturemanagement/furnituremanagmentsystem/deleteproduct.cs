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
    public partial class deleteproduct : UserControl
    {
        public deleteproduct()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteproduct_Load(object sender, EventArgs e)
        {

        }

        private void button_DEL_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
            con.Open();
            string deleteproduct = "delete from [dbo].[Furniture_piece] where Furn_ID=" + this.textBox_del_id.Text;
            SqlCommand cmd = new SqlCommand(deleteproduct,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product deleted successfully");
            textBox_del_id.Text = " ";
            con.Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
