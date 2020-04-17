namespace furnituremanagmentsystem
{
    partial class sofaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sofaControl));
            this.sofaDataGrid = new System.Windows.Forms.DataGridView();
            this.buyBtn = new System.Windows.Forms.Button();
            this.buyPanel = new System.Windows.Forms.Panel();
            this.notRegisteredLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.emptyTxtLbl2 = new System.Windows.Forms.Label();
            this.cancelBuyBtn = new System.Windows.Forms.Button();
            this.ensureBuyBtn = new System.Windows.Forms.Button();
            this.itemIdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sofaDataGrid)).BeginInit();
            this.buyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sofaDataGrid
            // 
            this.sofaDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sofaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sofaDataGrid.Location = new System.Drawing.Point(38, 20);
            this.sofaDataGrid.Name = "sofaDataGrid";
            this.sofaDataGrid.RowTemplate.Height = 24;
            this.sofaDataGrid.Size = new System.Drawing.Size(846, 595);
            this.sofaDataGrid.TabIndex = 0;
            this.sofaDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sofaDataGrid_CellContentClick);
            // 
            // buyBtn
            // 
            this.buyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buyBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.ForeColor = System.Drawing.Color.White;
            this.buyBtn.Location = new System.Drawing.Point(343, 629);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(194, 91);
            this.buyBtn.TabIndex = 1;
            this.buyBtn.Text = "Buy an item";
            this.buyBtn.UseVisualStyleBackColor = false;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // buyPanel
            // 
            this.buyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buyPanel.Controls.Add(this.notRegisteredLbl);
            this.buyPanel.Controls.Add(this.priceLbl);
            this.buyPanel.Controls.Add(this.emptyTxtLbl2);
            this.buyPanel.Controls.Add(this.cancelBuyBtn);
            this.buyPanel.Controls.Add(this.ensureBuyBtn);
            this.buyPanel.Controls.Add(this.itemIdTxt);
            this.buyPanel.Controls.Add(this.label3);
            this.buyPanel.Controls.Add(this.label1);
            this.buyPanel.Location = new System.Drawing.Point(57, 36);
            this.buyPanel.Name = "buyPanel";
            this.buyPanel.Size = new System.Drawing.Size(810, 336);
            this.buyPanel.TabIndex = 2;
            this.buyPanel.Visible = false;
            this.buyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buyPanel_Paint);
            // 
            // notRegisteredLbl
            // 
            this.notRegisteredLbl.AutoSize = true;
            this.notRegisteredLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notRegisteredLbl.ForeColor = System.Drawing.Color.White;
            this.notRegisteredLbl.Location = new System.Drawing.Point(347, 149);
            this.notRegisteredLbl.Name = "notRegisteredLbl";
            this.notRegisteredLbl.Size = new System.Drawing.Size(56, 23);
            this.notRegisteredLbl.TabIndex = 8;
            this.notRegisteredLbl.Text = "NULL";
            this.notRegisteredLbl.Visible = false;
            this.notRegisteredLbl.Click += new System.EventHandler(this.notRegisteredLbl_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.White;
            this.priceLbl.Location = new System.Drawing.Point(175, 209);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(116, 23);
            this.priceLbl.TabIndex = 7;
            this.priceLbl.Text = "Item price:";
            // 
            // emptyTxtLbl2
            // 
            this.emptyTxtLbl2.AutoSize = true;
            this.emptyTxtLbl2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyTxtLbl2.ForeColor = System.Drawing.Color.White;
            this.emptyTxtLbl2.Location = new System.Drawing.Point(347, 149);
            this.emptyTxtLbl2.Name = "emptyTxtLbl2";
            this.emptyTxtLbl2.Size = new System.Drawing.Size(56, 23);
            this.emptyTxtLbl2.TabIndex = 6;
            this.emptyTxtLbl2.Text = "NULL";
            this.emptyTxtLbl2.Visible = false;
            // 
            // cancelBuyBtn
            // 
            this.cancelBuyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBuyBtn.BackColor = System.Drawing.Color.White;
            this.cancelBuyBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBuyBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBuyBtn.Location = new System.Drawing.Point(446, 246);
            this.cancelBuyBtn.Name = "cancelBuyBtn";
            this.cancelBuyBtn.Size = new System.Drawing.Size(112, 39);
            this.cancelBuyBtn.TabIndex = 5;
            this.cancelBuyBtn.Text = "CANCEL";
            this.cancelBuyBtn.UseVisualStyleBackColor = false;
            this.cancelBuyBtn.Click += new System.EventHandler(this.cancelBuyBtn_Click);
            // 
            // ensureBuyBtn
            // 
            this.ensureBuyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ensureBuyBtn.BackColor = System.Drawing.Color.White;
            this.ensureBuyBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ensureBuyBtn.ForeColor = System.Drawing.Color.Black;
            this.ensureBuyBtn.Location = new System.Drawing.Point(237, 246);
            this.ensureBuyBtn.Name = "ensureBuyBtn";
            this.ensureBuyBtn.Size = new System.Drawing.Size(112, 39);
            this.ensureBuyBtn.TabIndex = 4;
            this.ensureBuyBtn.Text = "BUY";
            this.ensureBuyBtn.UseVisualStyleBackColor = false;
            this.ensureBuyBtn.Click += new System.EventHandler(this.ensureBuyBtn_Click);
            // 
            // itemIdTxt
            // 
            this.itemIdTxt.Location = new System.Drawing.Point(330, 95);
            this.itemIdTxt.Name = "itemIdTxt";
            this.itemIdTxt.Size = new System.Drawing.Size(258, 23);
            this.itemIdTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy an item";
            // 
            // sofaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buyPanel);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.sofaDataGrid);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "sofaControl";
            this.Size = new System.Drawing.Size(916, 754);
            this.Load += new System.EventHandler(this.sofaControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sofaDataGrid)).EndInit();
            this.buyPanel.ResumeLayout(false);
            this.buyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sofaDataGrid;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Panel buyPanel;
        private System.Windows.Forms.Button ensureBuyBtn;
        private System.Windows.Forms.TextBox itemIdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBuyBtn;
        private System.Windows.Forms.Label emptyTxtLbl2;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label notRegisteredLbl;





    }
}
