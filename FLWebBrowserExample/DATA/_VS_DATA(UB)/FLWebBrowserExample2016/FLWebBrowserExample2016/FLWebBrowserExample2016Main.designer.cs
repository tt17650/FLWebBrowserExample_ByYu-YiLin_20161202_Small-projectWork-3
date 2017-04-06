namespace FLWebBrowserExample
{
    partial class FLWebBrowserExample2016Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLWebBrowserExample2016Main));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelRightBorder = new System.Windows.Forms.Panel();
            this.panelLeftBorder = new System.Windows.Forms.Panel();
            this.panelCent = new System.Windows.Forms.Panel();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddFavorites = new System.Windows.Forms.Button();
            this.btnEditFavorites = new System.Windows.Forms.Button();
            this.wwwComBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClosePage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebURL = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4.SuspendLayout();
            this.panelCent.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "製作者：Farm-Long (Yu-Yi Lin)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(758, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "--程式資訊--　　版本：FL_V.a.006.0　　更新日期：2016.12";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 630);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1084, 32);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 13);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(289, 16);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 14;
            // 
            // panelRightBorder
            // 
            this.panelRightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightBorder.Location = new System.Drawing.Point(1074, 87);
            this.panelRightBorder.Name = "panelRightBorder";
            this.panelRightBorder.Size = new System.Drawing.Size(10, 543);
            this.panelRightBorder.TabIndex = 23;
            // 
            // panelLeftBorder
            // 
            this.panelLeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBorder.Location = new System.Drawing.Point(0, 87);
            this.panelLeftBorder.Name = "panelLeftBorder";
            this.panelLeftBorder.Size = new System.Drawing.Size(10, 543);
            this.panelLeftBorder.TabIndex = 24;
            // 
            // panelCent
            // 
            this.panelCent.Controls.Add(this.panelHelp);
            this.panelCent.Controls.Add(this.webBrowser1);
            this.panelCent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCent.Location = new System.Drawing.Point(10, 87);
            this.panelCent.Name = "panelCent";
            this.panelCent.Size = new System.Drawing.Size(1064, 543);
            this.panelCent.TabIndex = 25;
            // 
            // panelHelp
            // 
            this.panelHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHelp.Controls.Add(this.textBox1);
            this.panelHelp.Controls.Add(this.label5);
            this.panelHelp.Controls.Add(this.label4);
            this.panelHelp.Location = new System.Drawing.Point(0, -1);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(1047, 564);
            this.panelHelp.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(45, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(894, 311);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(18, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(961, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "此為簡單的瀏覽器，請於上方選擇「--連結網址--」下拉選單 或 於右上方的「網址列」輸入網址使用。";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(891, 51);
            this.label4.TabIndex = 0;
            this.label4.Text = "歡迎使用 FL_WebBrowser (簡易瀏覽器)";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1064, 531);
            this.webBrowser1.TabIndex = 31;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 87);
            this.panel1.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 85);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.btnAddFavorites);
            this.groupBox5.Controls.Add(this.btnEditFavorites);
            this.groupBox5.Controls.Add(this.wwwComBox);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(760, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 84);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "書籤 function：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(9, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "書籤選單：";
            // 
            // btnAddFavorites
            // 
            this.btnAddFavorites.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddFavorites.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddFavorites.Location = new System.Drawing.Point(210, 14);
            this.btnAddFavorites.Name = "btnAddFavorites";
            this.btnAddFavorites.Size = new System.Drawing.Size(100, 25);
            this.btnAddFavorites.TabIndex = 16;
            this.btnAddFavorites.Text = "加入書籤";
            this.btnAddFavorites.UseVisualStyleBackColor = true;
            this.btnAddFavorites.Click += new System.EventHandler(this.btnAddFavorites_Click);
            // 
            // btnEditFavorites
            // 
            this.btnEditFavorites.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditFavorites.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditFavorites.Location = new System.Drawing.Point(98, 14);
            this.btnEditFavorites.Name = "btnEditFavorites";
            this.btnEditFavorites.Size = new System.Drawing.Size(100, 25);
            this.btnEditFavorites.TabIndex = 14;
            this.btnEditFavorites.Text = "書籤管理";
            this.btnEditFavorites.UseVisualStyleBackColor = true;
            this.btnEditFavorites.Click += new System.EventHandler(this.btnEditFavorites_Click);
            // 
            // wwwComBox
            // 
            this.wwwComBox.FormattingEnabled = true;
            this.wwwComBox.Location = new System.Drawing.Point(99, 48);
            this.wwwComBox.Name = "wwwComBox";
            this.wwwComBox.Size = new System.Drawing.Size(216, 20);
            this.wwwComBox.TabIndex = 11;
            this.wwwComBox.Text = "　-- 網站連結 --";
            this.wwwComBox.SelectedIndexChanged += new System.EventHandler(this.wwwComBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.helpBtn);
            this.groupBox1.Controls.Add(this.forwardBtn);
            this.groupBox1.Controls.Add(this.backBtn);
            this.groupBox1.Controls.Add(this.refreshBtn);
            this.groupBox1.Controls.Add(this.stopBtn);
            this.groupBox1.Controls.Add(this.homeBtn);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本功能";
            // 
            // helpBtn
            // 
            this.helpBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.helpBtn.Image = ((System.Drawing.Image)(resources.GetObject("helpBtn.Image")));
            this.helpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.Location = new System.Drawing.Point(224, 48);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(105, 33);
            this.helpBtn.TabIndex = 12;
            this.helpBtn.Text = "　幫助";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.forwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("forwardBtn.Image")));
            this.forwardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.forwardBtn.Location = new System.Drawing.Point(116, 13);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(105, 33);
            this.forwardBtn.TabIndex = 1;
            this.forwardBtn.Text = "　下一頁";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(9, 14);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 33);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "　上一頁";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.Location = new System.Drawing.Point(224, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(105, 33);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "　重新整理";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopBtn.Location = new System.Drawing.Point(9, 48);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(105, 33);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "　停止";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(116, 48);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(105, 33);
            this.homeBtn.TabIndex = 4;
            this.homeBtn.Text = "　首頁";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.btnClosePage);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtWebURL);
            this.groupBox2.Controls.Add(this.goBtn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(336, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WEB function：";
            // 
            // btnClosePage
            // 
            this.btnClosePage.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClosePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClosePage.Location = new System.Drawing.Point(7, 21);
            this.btnClosePage.Name = "btnClosePage";
            this.btnClosePage.Size = new System.Drawing.Size(75, 50);
            this.btnClosePage.TabIndex = 16;
            this.btnClosePage.Text = "關閉目前Web頁面";
            this.btnClosePage.UseVisualStyleBackColor = true;
            this.btnClosePage.Click += new System.EventHandler(this.btnClosePage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(87, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "網址：";
            // 
            // txtWebURL
            // 
            this.txtWebURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebURL.Location = new System.Drawing.Point(95, 41);
            this.txtWebURL.Name = "txtWebURL";
            this.txtWebURL.Size = new System.Drawing.Size(260, 22);
            this.txtWebURL.TabIndex = 6;
            this.txtWebURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWebURL_KeyUp);
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.goBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goBtn.Image = ((System.Drawing.Image)(resources.GetObject("goBtn.Image")));
            this.goBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goBtn.Location = new System.Drawing.Point(361, 37);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(57, 30);
            this.goBtn.TabIndex = 7;
            this.goBtn.Text = "前往";
            this.goBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FLWebBrowserExample2016Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.panelCent);
            this.Controls.Add(this.panelRightBorder);
            this.Controls.Add(this.panelLeftBorder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLWebBrowserExample2016Main";
            this.Text = "FL_WebBrowser(簡易瀏覽器)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelCent.ResumeLayout(false);
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panelRightBorder;
        private System.Windows.Forms.Panel panelLeftBorder;
        private System.Windows.Forms.Panel panelCent;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddFavorites;
        private System.Windows.Forms.Button btnEditFavorites;
        private System.Windows.Forms.ComboBox wwwComBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClosePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebURL;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label6;
    }
}

