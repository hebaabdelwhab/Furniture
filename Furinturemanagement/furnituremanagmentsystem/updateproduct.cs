﻿using System;
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
    public partial class updateproduct : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=furniture store;Integrated Security=True");

        public updateproduct()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            
            string ch = ("select id from [dbo].[Furniture_piece] where Furn_ID='" + textBoxproduct_id.Text + "'");
            con.Open();
            if (textBoxproduct_id.Text ==" ")
            {
                caseempty2();
                return;
            }
            SqlDataAdapter dbtl = new SqlDataAdapter(ch, con);
            DataTable tb = new DataTable();
            dbtl.Fill(tb);
            if (tb.Rows.Count != 1)
            {
                caseempty1();
                return;
            }
              
            panelupdateproduct.Visible = true;
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            if (
            textBox_color.Text==null||
            textBoxcatagory.Text==null||
            textBox_image.Text ==null||
            pictureBox_addprod.Image == null||
            textBox_prodname.Text==null||
            textbox_price.Text==null)
            {
                caseempty1();
                return;
            }

            string upproduct = @"update [dbo].[Furniture_piece] set Furn_Color='" + textBox_color.Text + "',Furn_Branch_ID='" + textBox_branch_id.Text + "',Furn_category_ID='" + textBoxcatagory.Text + "',Furn_image='" + textBox_image.Text + "',Furn_Model='" + textBox_prodname.Text + "',Furn_Price='" + textbox_price.Text + "' where Furn_ID='" + textBoxproduct_id.Text + "'";
            SqlCommand cmd = new SqlCommand(upproduct,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully update");
            textBox_branch_id.Text = " ";
            textBox_color.Text = " ";
            textBoxcatagory.Text =" ";
            textBox_image.Text = " ";
            pictureBox_addprod.Image = null;
            textBox_prodname.Text=" "; 
            textbox_price.Text=" ";


            con.Close();
        }
        private void btn_back_Click(object sender, EventArgs e)  //button back
        {
            admincontrol conadd = null;
            conadd = new admincontrol();
            this.Controls.Add(conadd);
            conadd.BringToFront();
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox_addprod.Image = new Bitmap(open.FileName);
                // image file path  
                textBox_image.Text = open.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void caseempty1()
        {
            this.lbl_case2.Text = "ID NOT FOUND ";
            this.lbl_case2.ForeColor = System.Drawing.Color.Red;
            this.lbl_case2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void caseempty2()
        {
            this.label_caseem.Text = "ID NOT FOUND ";
            this.label_caseem.ForeColor = System.Drawing.Color.Red;
            this.label_caseem.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void caseempty()
        {
            this.lbl_caseempty1.Text = "fill all data";
            this.lbl_caseempty1.ForeColor = System.Drawing.Color.Red;
            this.lbl_caseempty1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
