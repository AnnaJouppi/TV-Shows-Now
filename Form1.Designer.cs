namespace TV_Shows_Now
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            description = new Label();
            pictureBoxShow = new PictureBox();
            labelStarring = new Label();
            castName1 = new Label();
            castName2 = new Label();
            castName3 = new Label();
            castName4 = new Label();
            labelLanguage = new Label();
            languageText = new Label();
            helpText = new Label();
            officialWebsiteLink = new LinkLabel();
            webBrowser1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webBrowser1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(979, 296);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(441, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 1;
            label1.Text = "Search for TV Shows";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(452, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 27);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.FlatAppearance.BorderColor = Color.HotPink;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(477, 89);
            button1.Name = "button1";
            button1.Size = new Size(103, 31);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            description.Location = new Point(476, 493);
            description.Name = "description";
            description.Size = new Size(104, 23);
            description.TabIndex = 4;
            description.Text = "Description";
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Location = new Point(1040, 151);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(210, 300);
            pictureBoxShow.TabIndex = 6;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            // 
            // labelStarring
            // 
            labelStarring.AutoSize = true;
            labelStarring.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStarring.Location = new Point(1049, 497);
            labelStarring.Name = "labelStarring";
            labelStarring.Size = new Size(69, 19);
            labelStarring.TabIndex = 7;
            labelStarring.Text = "Starring:";
            // 
            // castName1
            // 
            castName1.AutoSize = true;
            castName1.Font = new Font("Candara", 12F);
            castName1.Location = new Point(1155, 497);
            castName1.Name = "castName1";
            castName1.Size = new Size(49, 19);
            castName1.TabIndex = 8;
            castName1.Text = "label2";
            // 
            // castName2
            // 
            castName2.AutoSize = true;
            castName2.Font = new Font("Candara", 12F);
            castName2.Location = new Point(1155, 518);
            castName2.Name = "castName2";
            castName2.Size = new Size(50, 19);
            castName2.TabIndex = 9;
            castName2.Text = "label3";
            // 
            // castName3
            // 
            castName3.AutoSize = true;
            castName3.Font = new Font("Candara", 12F);
            castName3.Location = new Point(1155, 541);
            castName3.Name = "castName3";
            castName3.Size = new Size(51, 19);
            castName3.TabIndex = 10;
            castName3.Text = "label4";
            // 
            // castName4
            // 
            castName4.AutoSize = true;
            castName4.Font = new Font("Candara", 12F);
            castName4.Location = new Point(1155, 565);
            castName4.Name = "castName4";
            castName4.Size = new Size(50, 19);
            castName4.TabIndex = 11;
            castName4.Text = "label5";
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLanguage.Location = new Point(1049, 608);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(81, 19);
            labelLanguage.TabIndex = 12;
            labelLanguage.Text = "Language:";
            // 
            // languageText
            // 
            languageText.AutoSize = true;
            languageText.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            languageText.Location = new Point(1155, 608);
            languageText.Name = "languageText";
            languageText.Size = new Size(42, 19);
            languageText.TabIndex = 13;
            languageText.Text = "label";
            // 
            // helpText
            // 
            helpText.AutoSize = true;
            helpText.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpText.Location = new Point(14, 115);
            helpText.Name = "helpText";
            helpText.Size = new Size(383, 19);
            helpText.TabIndex = 15;
            helpText.Text = "🌸 Click on a show title to display additional information";
            // 
            // officialWebsiteLink
            // 
            officialWebsiteLink.AutoSize = true;
            officialWebsiteLink.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            officialWebsiteLink.LinkColor = Color.DeepPink;
            officialWebsiteLink.Location = new Point(1049, 643);
            officialWebsiteLink.Name = "officialWebsiteLink";
            officialWebsiteLink.Size = new Size(114, 19);
            officialWebsiteLink.TabIndex = 16;
            officialWebsiteLink.TabStop = true;
            officialWebsiteLink.Text = "Official Website";
            officialWebsiteLink.LinkClicked += officialWebsiteLink_LinkClicked;
            // 
            // webBrowser1
            // 
            webBrowser1.AllowExternalDrop = true;
            webBrowser1.CreationProperties = null;
            webBrowser1.DefaultBackgroundColor = Color.White;
            webBrowser1.ForeColor = Color.Gray;
            webBrowser1.Location = new Point(245, 537);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new Size(578, 227);
            webBrowser1.TabIndex = 17;
            webBrowser1.ZoomFactor = 1D;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 780);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 18;
            label5.Text = "⚡ Powered by ";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DeepPink;
            linkLabel1.Location = new Point(101, 780);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 15);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "TV Maze API";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1441, 806);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(webBrowser1);
            Controls.Add(officialWebsiteLink);
            Controls.Add(helpText);
            Controls.Add(languageText);
            Controls.Add(labelLanguage);
            Controls.Add(castName4);
            Controls.Add(castName3);
            Controls.Add(castName2);
            Controls.Add(castName1);
            Controls.Add(labelStarring);
            Controls.Add(pictureBoxShow);
            Controls.Add(description);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "TV Shows Now";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)webBrowser1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label description;
        private PictureBox pictureBoxShow;
        private Label labelStarring;
        private Label castName1;
        private Label castName2;
        private Label castName3;
        private Label castName4;
        private Label labelLanguage;
        private Label languageText;
        private Label helpText;
        private LinkLabel officialWebsiteLink;
        private Microsoft.Web.WebView2.WinForms.WebView2 webBrowser1;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}
