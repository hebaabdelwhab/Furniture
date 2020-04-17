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
    public partial class updatebranch : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
        
        public updatebranch()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            string update_branch = @"update branch set Br_Address='" + txtbx_address.Text + "',Br_Telephone='" + txtbox_telephone.Text + "',Br_Name='" + branch_nameTxt.Text + "' where br_id=" + textBox_id_branch.Text;
            SqlCommand cmd = new SqlCommand(update_branch, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Branch successfully updated");
            con.Close();
        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            string ch = "select id from addproduct where id='" + textBox_id_branch;
            con.Open();
            SqlCommand cmd = new SqlCommand(ch, con);
            panelupdatebranch.Visible = true;
            panel_id_check.Visible = false;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }

        private void updateproduct1_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            admincontrol admincon = null;
            admincon = new admincontrol();
            this.Controls.Add(admincon);
            admincon.BringToFront();
        }
    }
}
