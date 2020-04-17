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
    public partial class contactUScontrol1 : UserControl
    {
        public contactUScontrol1()
        {
            InitializeComponent();
        }

        private void contactUScontrol1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select br_name, br_address,br_telephone,br_id from branch ", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dtable = new DataTable();
            dtable.Columns.Add("ID");
            dtable.Columns.Add("Address");
            dtable.Columns.Add("Telephone");
            dtable.Columns.Add("Name");
            DataRow row;

            while (reader.Read())
            {
                row = dtable.NewRow();
                row["ID"] = reader["br_id"];
                row["Address"] = reader["br_address"];
                row["Telephone"] = reader["br_telephone"];
                row["Name"] = reader["br_name"];

                dtable.Rows.Add(row);
            }
            reader.Close();   
            con.Close();
            dataGridView1.DataSource = dtable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;
                           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
