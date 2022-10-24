namespace BookManegmentSystem
{
    partial class FRM_DETAILS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DETAILS));
            this.TXT_PRICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_AUTHOR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TC = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.RATE = new Bunifu.Framework.UI.BunifuRating();
            this.DATE = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CAT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_PRICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_PRICE.Enabled = false;
            this.TXT_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_PRICE.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_PRICE.HintText = "";
            this.TXT_PRICE.isPassword = false;
            this.TXT_PRICE.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_PRICE.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_PRICE.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_PRICE.LineThickness = 4;
            this.TXT_PRICE.Location = new System.Drawing.Point(156, 454);
            this.TXT_PRICE.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(433, 42);
            this.TXT_PRICE.TabIndex = 19;
            this.TXT_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PRICE.OnValueChanged += new System.EventHandler(this.TXT_PRICE_OnValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(15, 548);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Category";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(15, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price";
            // 
            // TXT_AUTHOR
            // 
            this.TXT_AUTHOR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_AUTHOR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_AUTHOR.Enabled = false;
            this.TXT_AUTHOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_AUTHOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_AUTHOR.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_AUTHOR.HintText = "";
            this.TXT_AUTHOR.isPassword = false;
            this.TXT_AUTHOR.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_AUTHOR.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_AUTHOR.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_AUTHOR.LineThickness = 4;
            this.TXT_AUTHOR.Location = new System.Drawing.Point(156, 313);
            this.TXT_AUTHOR.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TXT_AUTHOR.Name = "TXT_AUTHOR";
            this.TXT_AUTHOR.Size = new System.Drawing.Size(433, 42);
            this.TXT_AUTHOR.TabIndex = 14;
            this.TXT_AUTHOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_AUTHOR.OnValueChanged += new System.EventHandler(this.TXT_AUTHOR_OnValueChanged);
            // 
            // TC
            // 
            this.TC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TC.AutoSize = true;
            this.TC.Enabled = false;
            this.TC.ForeColor = System.Drawing.Color.Gray;
            this.TC.Location = new System.Drawing.Point(15, 282);
            this.TC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(105, 32);
            this.TC.TabIndex = 12;
            this.TC.Text = "Author";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_name.LineThickness = 4;
            this.txt_name.Location = new System.Drawing.Point(156, 215);
            this.txt_name.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(433, 42);
            this.txt_name.TabIndex = 8;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.OnValueChanged += new System.EventHandler(this.txt_name_OnValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book\'s name";
            // 
            // Cover
            // 
            this.Cover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cover.Enabled = false;
            this.Cover.Image = ((System.Drawing.Image)(resources.GetObject("Cover.Image")));
            this.Cover.Location = new System.Drawing.Point(848, 187);
            this.Cover.Margin = new System.Windows.Forms.Padding(6);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(353, 461);
            this.Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cover.TabIndex = 18;
            this.Cover.TabStop = false;
            // 
            // RATE
            // 
            this.RATE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RATE.BackColor = System.Drawing.Color.Transparent;
            this.RATE.Enabled = false;
            this.RATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RATE.ForeColor = System.Drawing.Color.SeaGreen;
            this.RATE.Location = new System.Drawing.Point(848, 776);
            this.RATE.Margin = new System.Windows.Forms.Padding(17, 14, 17, 14);
            this.RATE.Name = "RATE";
            this.RATE.Size = new System.Drawing.Size(353, 54);
            this.RATE.TabIndex = 15;
            this.RATE.Value = 0;
            // 
            // DATE
            // 
            this.DATE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DATE.BackColor = System.Drawing.Color.SeaGreen;
            this.DATE.BorderRadius = 0;
            this.DATE.Enabled = false;
            this.DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE.ForeColor = System.Drawing.Color.White;
            this.DATE.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DATE.FormatCustom = null;
            this.DATE.Location = new System.Drawing.Point(156, 730);
            this.DATE.Margin = new System.Windows.Forms.Padding(17, 14, 17, 14);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(433, 72);
            this.DATE.TabIndex = 13;
            this.DATE.Value = new System.DateTime(2021, 12, 22, 7, 38, 43, 41);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(759, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cover";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(775, 730);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rate";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(21, 682);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date";
            // 
            // CAT
            // 
            this.CAT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CAT.Enabled = false;
            this.CAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CAT.HintForeColor = System.Drawing.Color.Empty;
            this.CAT.HintText = "";
            this.CAT.isPassword = false;
            this.CAT.LineFocusedColor = System.Drawing.Color.Blue;
            this.CAT.LineIdleColor = System.Drawing.Color.Gray;
            this.CAT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.CAT.LineThickness = 4;
            this.CAT.Location = new System.Drawing.Point(156, 593);
            this.CAT.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.CAT.Name = "CAT";
            this.CAT.Size = new System.Drawing.Size(433, 42);
            this.CAT.TabIndex = 20;
            this.CAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CAT.OnValueChanged += new System.EventHandler(this.CAT_OnValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1226, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 67);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 21;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // FRM_DETAILS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 1055);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.CAT);
            this.Controls.Add(this.TXT_PRICE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_AUTHOR);
            this.Controls.Add(this.TC);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cover);
            this.Controls.Add(this.RATE);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRM_DETAILS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_DIADD";
            this.Load += new System.EventHandler(this.FRM_DETAILS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuMaterialTextbox TXT_PRICE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TXT_AUTHOR;
        private System.Windows.Forms.Label TC;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Cover;
        public Bunifu.Framework.UI.BunifuRating RATE;
        public Bunifu.Framework.UI.BunifuDatepicker DATE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuMaterialTextbox CAT;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}