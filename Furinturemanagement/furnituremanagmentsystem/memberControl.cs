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
    public partial class memberControl : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
        
        public memberControl()
        {
            InitializeComponent();
        }

        private void cusomerbtn_Click(object sender, EventArgs e)
        {
            custlogpanel.Visible = true;
            custlogpanel.BringToFront();
            registerpanel.Visible = false;
            logadminpanel.Visible = false;
        }
        private void notregisterbtn_Click(object sender, EventArgs e)
        {
            registerpanel.Visible = true;
            registerpanel.BringToFront();
            logadminpanel.Visible = false;
            custlogpanel.Visible = false;
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            logadminpanel.Visible =true;
            logadminpanel.BringToFront();
            registerpanel.Visible = false;
            custlogpanel.Visible = false;
        }

        private void usernametxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void memberControl_Load(object sender, EventArgs e)
        {

        }

        private void custlogpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loguserbtn_Click(object sender, EventArgs e)
        {
            emptyCustLbl.Visible = false;
            loginStateLbl.Visible = false;


            if (userNameLogTxt.Text=="" || custPasswordLogTxt.Text=="")
            {
                emptyCustLbl.Text="Please fill all fields";
                emptyCustLbl.Visible = true;
                return;
            }

            con.Open();
            string query = "select * from customer where Cu_username= '" + userNameLogTxt.Text.Trim() + "' and Cu_password ='" + custPasswordLogTxt.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable resultTable = new DataTable();
            sda.Fill(resultTable);
            int count = resultTable.Rows.Count;
            
            if (count == 1)
            {
               
                global.GlobalLoggedCustomer = true;
                global.GlobalLoggedUserId = (int)resultTable.Rows[0].ItemArray[0];
                global.GlobalLoggedUserName = resultTable.Rows[0].ItemArray[5].ToString();
                homecontrol hc = new homecontrol();
                this.Controls.Add(hc);
                hc.BringToFront();
            }

            else
            {
                loginStateLbl.Text = "Username or password is wrong";
                loginStateLbl.Visible = true;
              
            }           
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;

            if (adminnametxtbx.Text == "" || passadmintxtBx.Text == "")
            {
                label4.Text = "Please fill all fields";
                label4.Visible = true;
                return;
            }

            string query = ("select * from admin where Adm_UserName='" + adminnametxtbx.Text + "' and Adm_Password ='" + passadmintxtBx.Text + "'");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                global.GlobalLoggedAdmin = true;
                global.GlobalLoggedUserId = (int)dt.Rows[0].ItemArray[0];
                global.GlobalLoggedUserName = dt.Rows[0].ItemArray[1].ToString();
                admincontrol adminCon = new admincontrol();
                
                this.Controls.Add(adminCon);
                
                adminCon.BringToFront();
            }
            else
            {
                label4.Text = "Username or password is wrong";
                label4.Visible = true;
            }

            con.Close();
        }
       

        private void registerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            emptyTxtLbl.Visible = false;

            if (nametextBox.Text == "" || adresstxt.Text == "" || userNameRegTxt.Text == ""
                || passRegTxt.Text == "" || phoneTxt.Text == "" || creditCTxt.Text == ""
                || emailTxt.Text == "")
            {
                emptyTxtLbl.Text = "Please fill all fields";
                emptyTxtLbl.Visible = true;
                return;
            }

            con.Open();
            string query = "select * from customer where Cu_Email='" + emailTxt.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable resultTable = new DataTable();
            sda.Fill(resultTable);
            int count = resultTable.Rows.Count;
            if (count > 0)
            {
                errorEmailLbl.Text="This e-mail is used before";
                errorEmailLbl.Visible = true;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("addAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@name", nametextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@address", adresstxt.Text));
                cmd.Parameters.Add(new SqlParameter("@phone", phoneTxt.Text));
                cmd.Parameters.Add(new SqlParameter("@email", emailTxt.Text));    
                cmd.Parameters.Add(new SqlParameter("@userName", userNameRegTxt.Text));
                cmd.Parameters.Add(new SqlParameter("@password", passRegTxt.Text));
                cmd.Parameters.Add(new SqlParameter("@creditCard", creditCTxt.Text));
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();

                SqlCommand cmd2= new SqlCommand("select Cu_ID from Customer where Cu_Email='"+emailTxt.Text+"'");
                global.GlobalLoggedUserId = (int)cmd2.ExecuteScalar();
                SqlCommand cmd3 = new SqlCommand("select Cu_username from Customer where Cu_Email='" + emailTxt.Text + "'");
                global.GlobalLoggedUserName = cmd3.ExecuteScalar().ToString();
                global.GlobalLoggedCustomer = true;
            }
            
            con.Close();

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void userNameLogTxt_Click(object sender, EventArgs e)
        {
            userNameLogTxt.Text = String.Empty;
        }

        private void custPasswordLogTxt_Click(object sender, EventArgs e)
        {
            custPasswordLogTxt.Text = String.Empty;
        }

        private void nametextBox_Click(object sender, EventArgs e)
        {
            nametextBox.Text = String.Empty;
        }

        private void userNameRegTxt_Click(object sender, EventArgs e)
        {
            userNameRegTxt.Text = String.Empty;
        }

        private void passRegTxt_Click(object sender, EventArgs e)
        {
            passRegTxt.Text = String.Empty;

        }

        private void adresstxt_Click(object sender, EventArgs e)
        {
            adresstxt.Text = String.Empty;
        }

        private void phoneTxt_Click(object sender, EventArgs e)
        {
            phoneTxt.Text = String.Empty;

        }

        private void emailTxt_Click(object sender, EventArgs e)
        {
            emailTxt.Text = String.Empty;
        }

        private void creditCTxt_Click(object sender, EventArgs e)
        {
            creditCTxt.Text = String.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
