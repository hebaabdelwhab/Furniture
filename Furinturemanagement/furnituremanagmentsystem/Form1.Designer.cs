namespace furnituremanagmentsystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.contactUsbtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.userLoggedBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menupanel1 = new System.Windows.Forms.Panel();
            this.tablebutton = new System.Windows.Forms.Button();
            this.sofabutton = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.menupanel = new System.Windows.Forms.Panel();
            this.memberbtn = new System.Windows.Forms.Button();
            this.productbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableControl11 = new furnituremanagmentsystem.tableControl1();
            this.sofaControl1 = new furnituremanagmentsystem.sofaControl();
            this.memberControl1 = new furnituremanagmentsystem.memberControl();
            this.homecontrol1 = new furnituremanagmentsystem.homecontrol();
            this.contactUScontrol11 = new furnituremanagmentsystem.contactUScontrol1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menupanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.contactUsbtn);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.userLoggedBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menupanel1);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.menupanel);
            this.panel1.Controls.Add(this.memberbtn);
            this.panel1.Controls.Add(this.productbtn);
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 692);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // contactUsbtn
            // 
            this.contactUsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.contactUsbtn.FlatAppearance.BorderSize = 0;
            this.contactUsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactUsbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUsbtn.ForeColor = System.Drawing.Color.White;
            this.contactUsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactUsbtn.Location = new System.Drawing.Point(3, 271);
            this.contactUsbtn.Name = "contactUsbtn";
            this.contactUsbtn.Size = new System.Drawing.Size(266, 45);
            this.contactUsbtn.TabIndex = 9;
            this.contactUsbtn.Text = "Contact us";
            this.contactUsbtn.UseVisualStyleBackColor = false;
            this.contactUsbtn.Click += new System.EventHandler(this.contactUsbtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.White;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.Location = new System.Drawing.Point(1, 632);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(266, 60);
            this.logOutBtn.TabIndex = 8;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // userLoggedBtn
            // 
            this.userLoggedBtn.BackColor = System.Drawing.Color.White;
            this.userLoggedBtn.FlatAppearance.BorderSize = 0;
            this.userLoggedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLoggedBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoggedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userLoggedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userLoggedBtn.Location = new System.Drawing.Point(1, 566);
            this.userLoggedBtn.Name = "userLoggedBtn";
            this.userLoggedBtn.Size = new System.Drawing.Size(266, 60);
            this.userLoggedBtn.TabIndex = 2;
            this.userLoggedBtn.Text = "signed in user";
            this.userLoggedBtn.UseVisualStyleBackColor = false;
            this.userLoggedBtn.Click += new System.EventHandler(this.userLoggedBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menupanel1
            // 
            this.menupanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menupanel1.Controls.Add(this.tablebutton);
            this.menupanel1.Controls.Add(this.sofabutton);
            this.menupanel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menupanel1.ForeColor = System.Drawing.Color.White;
            this.menupanel1.Location = new System.Drawing.Point(4, 389);
            this.menupanel1.Name = "menupanel1";
            this.menupanel1.Size = new System.Drawing.Size(263, 0);
            this.menupanel1.TabIndex = 7;
            this.menupanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.menupanel1_Paint);
            // 
            // tablebutton
            // 
            this.tablebutton.FlatAppearance.BorderSize = 0;
            this.tablebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablebutton.Location = new System.Drawing.Point(-3, 56);
            this.tablebutton.Name = "tablebutton";
            this.tablebutton.Size = new System.Drawing.Size(266, 45);
            this.tablebutton.TabIndex = 2;
            this.tablebutton.Text = "Table";
            this.tablebutton.UseVisualStyleBackColor = true;
            this.tablebutton.Click += new System.EventHandler(this.tablebutton_Click);
            // 
            // sofabutton
            // 
            this.sofabutton.FlatAppearance.BorderSize = 0;
            this.sofabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sofabutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sofabutton.Location = new System.Drawing.Point(0, 1);
            this.sofabutton.Name = "sofabutton";
            this.sofabutton.Size = new System.Drawing.Size(266, 45);
            this.sofabutton.TabIndex = 1;
            this.sofabutton.Text = "Sofa";
            this.sofabutton.UseVisualStyleBackColor = true;
            this.sofabutton.Click += new System.EventHandler(this.sofabutton_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.White;
            this.sidepanel.Location = new System.Drawing.Point(0, 172);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(13, 58);
            this.sidepanel.TabIndex = 6;
            // 
            // menupanel
            // 
            this.menupanel.ForeColor = System.Drawing.Color.White;
            this.menupanel.Location = new System.Drawing.Point(4, 499);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(266, 0);
            this.menupanel.TabIndex = 5;
            // 
            // memberbtn
            // 
            this.memberbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.memberbtn.FlatAppearance.BorderSize = 0;
            this.memberbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberbtn.ForeColor = System.Drawing.Color.White;
            this.memberbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memberbtn.Location = new System.Drawing.Point(2, 223);
            this.memberbtn.Name = "memberbtn";
            this.memberbtn.Size = new System.Drawing.Size(266, 45);
            this.memberbtn.TabIndex = 4;
            this.memberbtn.Text = "Member";
            this.memberbtn.UseVisualStyleBackColor = false;
            this.memberbtn.Click += new System.EventHandler(this.memberbtn_Click);
            // 
            // productbtn
            // 
            this.productbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.productbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productbtn.FlatAppearance.BorderSize = 0;
            this.productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productbtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbtn.ForeColor = System.Drawing.Color.White;
            this.productbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productbtn.Location = new System.Drawing.Point(2, 319);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(266, 45);
            this.productbtn.TabIndex = 3;
            this.productbtn.Text = "Product\r\n";
            this.productbtn.UseVisualStyleBackColor = false;
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homebtn.Location = new System.Drawing.Point(0, 170);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(266, 45);
            this.homebtn.TabIndex = 1;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 37);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // closebtn
            // 
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(1132, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(50, 37);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "x";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableControl11
            // 
            this.tableControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableControl11.BackgroundImage")));
            this.tableControl11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableControl11.Location = new System.Drawing.Point(273, 37);
            this.tableControl11.Name = "tableControl11";
            this.tableControl11.Size = new System.Drawing.Size(913, 692);
            this.tableControl11.TabIndex = 6;
            // 
            // sofaControl1
            // 
            this.sofaControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sofaControl1.AutoScroll = true;
            this.sofaControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sofaControl1.BackgroundImage")));
            this.sofaControl1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sofaControl1.Location = new System.Drawing.Point(273, 37);
            this.sofaControl1.Name = "sofaControl1";
            this.sofaControl1.Size = new System.Drawing.Size(913, 692);
            this.sofaControl1.TabIndex = 5;
            // 
            // memberControl1
            // 
            this.memberControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memberControl1.BackgroundImage")));
            this.memberControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memberControl1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberControl1.Location = new System.Drawing.Point(269, 37);
            this.memberControl1.Name = "memberControl1";
            this.memberControl1.Size = new System.Drawing.Size(913, 692);
            this.memberControl1.TabIndex = 8;
            this.memberControl1.Load += new System.EventHandler(this.memberControl1_Load);
            // 
            // homecontrol1
            // 
            this.homecontrol1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homecontrol1.BackgroundImage")));
            this.homecontrol1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homecontrol1.Location = new System.Drawing.Point(269, 37);
            this.homecontrol1.Name = "homecontrol1";
            this.homecontrol1.Size = new System.Drawing.Size(913, 692);
            this.homecontrol1.TabIndex = 2;
            // 
            // contactUScontrol11
            // 
            this.contactUScontrol11.AutoScroll = true;
            this.contactUScontrol11.BackColor = System.Drawing.Color.White;
            this.contactUScontrol11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contactUScontrol11.BackgroundImage")));
            this.contactUScontrol11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contactUScontrol11.Location = new System.Drawing.Point(269, 37);
            this.contactUScontrol11.Margin = new System.Windows.Forms.Padding(4);
            this.contactUScontrol11.Name = "contactUScontrol11";
            this.contactUScontrol11.Size = new System.Drawing.Size(913, 668);
            this.contactUScontrol11.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 729);
            this.Controls.Add(this.tableControl11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sofaControl1);
            this.Controls.Add(this.memberControl1);
            this.Controls.Add(this.homecontrol1);
            this.Controls.Add(this.contactUScontrol11);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Harmony furniture store";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menupanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button memberbtn;
        private System.Windows.Forms.Button productbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel sidepanel;
        private homecontrol homecontrol1;
        private sofaControl sofaControl1;
        private tableControl1 tableControl11;
     
        private memberControl memberControl1;
        private System.Windows.Forms.Panel menupanel1;
        private System.Windows.Forms.Button tablebutton;
        private System.Windows.Forms.Button sofabutton;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Button userLoggedBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button contactUsbtn;
        private contactUScontrol1 contactUScontrol11;
    }
}

