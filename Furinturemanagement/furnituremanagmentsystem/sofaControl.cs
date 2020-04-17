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
    public partial class 
       sofaControl : UserControl 
    {
       SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
        public sofaControl()
        {
            InitializeComponent();
            
        }

        private void sofaControl_Load(object sender, EventArgs e)
        {
            
            buyPanel.Visible = false;
            notRegisteredLbl.Visible = false;
            emptyTxtLbl2.Visible = false;

            con.Open();
            string query="select * from fn_DisplayCategoryProducts ('sofa')"; 
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.Fill(dt);
            sofaDataGrid.DataSource = dt;
            sofaDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sofaDataGrid.RowTemplate.Height = 120;
            sofaDataGrid.AllowUserToAddRows = false;
           
            int sofaNum=dt.Rows.Count;

            con.Close();
            

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            sofaDataGrid.Hide();
            buyBtn.Hide();
            buyPanel.Visible = true;
            buyPanel.Show();

        }

        private void cancelBuyBtn_Click(object sender, EventArgs e)
        {
            sofaDataGrid.Show();
            buyBtn.Show();
            buyPanel.Visible = false;
            buyPanel.Hide();
        }

        private void buyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ensureBuyBtn_Click(object sender, EventArgs e)
        {
            
            if (itemIdTxt.Text == " ")
            {
                emptyTxtLbl2.Text = "Fill the Item Id field";
                emptyTxtLbl2.Visible = true;
                return;
            }
            if (global.GlobalLoggedUserId == 0)
            {
                notRegisteredLbl.Text = "Please login or register first";
                notRegisteredLbl.Visible = true;
                return;
            }
            
            con.Open();

            SqlCommand cmd = new SqlCommand("insertOrder", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter(@"ordercustomerid", global.GlobalLoggedUserId));
            
            SqlCommand cmd2 = new SqlCommand("select Furn_Price from [dbo].[Furniture_piece] where Furn_ID='" + itemIdTxt.Text + "'", con);
            decimal orderAmount=(decimal)cmd2.ExecuteScalar();
            cmd.Parameters.Add(new SqlParameter(@"orderamount",orderAmount));

            priceLbl.Text =("Item price :"+ orderAmount.ToString());
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        private void notRegisteredLbl_Click(object sender, EventArgs e)
        {

        }

        private void sofaDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
