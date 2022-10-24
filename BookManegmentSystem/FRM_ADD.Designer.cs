namespace BookManegmentSystem
{
    partial class FRM_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnadd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CAT = new System.Windows.Forms.ComboBox();
            this.TXT_PRICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_AUTHOR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TC = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.RATE = new Bunifu.Framework.UI.BunifuRating();
            this.DATE = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 41);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(848, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 38);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnadd);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 685);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 92);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnadd
            // 
            this.btnadd.ActiveBorderThickness = 1;
            this.btnadd.ActiveCornerRadius = 20;
            this.btnadd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnadd.ActiveForecolor = System.Drawing.Color.White;
            this.btnadd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.ButtonText = "Add new book";
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnadd, BunifuAnimatorNS.DecorationType.None);
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleBorderThickness = 1;
            this.btnadd.IdleCornerRadius = 20;
            this.btnadd.IdleFillColor = System.Drawing.Color.White;
            this.btnadd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnadd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnadd.Location = new System.Drawing.Point(320, 23);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(279, 47);
            this.btnadd.TabIndex = 1;
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadd.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 644);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.CAT);
            this.groupBox2.Controls.Add(this.TXT_PRICE);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXT_AUTHOR);
            this.groupBox2.Controls.Add(this.TC);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(442, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 638);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(290, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 37);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CAT
            // 
            this.CAT.AllowDrop = true;
            this.bunifuTransition1.SetDecoration(this.CAT, BunifuAnimatorNS.DecorationType.None);
            this.CAT.FormattingEnabled = true;
            this.CAT.IntegralHeight = false;
            this.CAT.Location = new System.Drawing.Point(3, 418);
            this.CAT.Name = "CAT";
            this.CAT.Size = new System.Drawing.Size(213, 37);
            this.CAT.Sorted = true;
            this.CAT.TabIndex = 6;
            this.CAT.SelectedIndexChanged += new System.EventHandler(this.CAT_SelectedIndexChanged);
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.TXT_PRICE, BunifuAnimatorNS.DecorationType.None);
            this.TXT_PRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_PRICE.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_PRICE.HintText = "";
            this.TXT_PRICE.isPassword = false;
            this.TXT_PRICE.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_PRICE.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_PRICE.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_PRICE.LineThickness = 4;
            this.TXT_PRICE.Location = new System.Drawing.Point(3, 306);
            this.TXT_PRICE.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(429, 38);
            this.TXT_PRICE.TabIndex = 5;
            this.TXT_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PRICE.OnValueChanged += new System.EventHandler(this.TXT_PRICE_OnValueChanged);
            this.TXT_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PRICE_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(3, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Category";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXT_AUTHOR
            // 
            this.TXT_AUTHOR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.TXT_AUTHOR, BunifuAnimatorNS.DecorationType.None);
            this.TXT_AUTHOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_AUTHOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_AUTHOR.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_AUTHOR.HintText = "";
            this.TXT_AUTHOR.isPassword = false;
            this.TXT_AUTHOR.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_AUTHOR.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_AUTHOR.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_AUTHOR.LineThickness = 4;
            this.TXT_AUTHOR.Location = new System.Drawing.Point(3, 181);
            this.TXT_AUTHOR.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TXT_AUTHOR.Name = "TXT_AUTHOR";
            this.TXT_AUTHOR.Size = new System.Drawing.Size(429, 41);
            this.TXT_AUTHOR.TabIndex = 3;
            this.TXT_AUTHOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_AUTHOR.OnValueChanged += new System.EventHandler(this.TXT_AUTHOR_OnValueChanged);
            this.TXT_AUTHOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_AUTHOR_KeyPress);
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.TC, BunifuAnimatorNS.DecorationType.None);
            this.TC.ForeColor = System.Drawing.Color.Gray;
            this.TC.Location = new System.Drawing.Point(3, 141);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(88, 29);
            this.TC.TabIndex = 2;
            this.TC.Text = "Author";
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txt_name, BunifuAnimatorNS.DecorationType.None);
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_name.LineThickness = 4;
            this.txt_name.Location = new System.Drawing.Point(3, 86);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(429, 37);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book\'s name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.Cover);
            this.groupBox1.Controls.Add(this.RATE);
            this.groupBox1.Controls.Add(this.DATE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 638);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secondary information";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel1, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel1.Location = new System.Drawing.Point(141, 593);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 29);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Upload";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Cover
            // 
            this.bunifuTransition1.SetDecoration(this.Cover, BunifuAnimatorNS.DecorationType.None);
            this.Cover.Image = ((System.Drawing.Image)(resources.GetObject("Cover.Image")));
            this.Cover.Location = new System.Drawing.Point(110, 330);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(166, 238);
            this.Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cover.TabIndex = 4;
            this.Cover.TabStop = false;
            // 
            // RATE
            // 
            this.RATE.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.RATE, BunifuAnimatorNS.DecorationType.None);
            this.RATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RATE.ForeColor = System.Drawing.Color.SeaGreen;
            this.RATE.Location = new System.Drawing.Point(0, 197);
            this.RATE.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RATE.Name = "RATE";
            this.RATE.Size = new System.Drawing.Size(217, 45);
            this.RATE.TabIndex = 3;
            this.RATE.Value = 0;
            // 
            // DATE
            // 
            this.DATE.BackColor = System.Drawing.Color.SeaGreen;
            this.DATE.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.DATE, BunifuAnimatorNS.DecorationType.None);
            this.DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE.ForeColor = System.Drawing.Color.White;
            this.DATE.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DATE.FormatCustom = null;
            this.DATE.Location = new System.Drawing.Point(0, 92);
            this.DATE.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(424, 44);
            this.DATE.TabIndex = 2;
            this.DATE.Value = new System.DateTime(2021, 12, 22, 7, 38, 43, 41);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(0, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cover";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(0, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(0, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.Interval = 4;
            // 
            // FRM_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 777);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FRM_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FRM_ADD_Activated);
            this.Load += new System.EventHandler(this.FRM_ADD_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        public System.Windows.Forms.GroupBox groupBox2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TXT_PRICE;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TXT_AUTHOR;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        public System.Windows.Forms.ComboBox CAT;
        public System.Windows.Forms.PictureBox Cover;
        public Bunifu.Framework.UI.BunifuRating RATE;
        public Bunifu.Framework.UI.BunifuDatepicker DATE;
        public Bunifu.Framework.UI.BunifuThinButton2 btnadd;
    }
}