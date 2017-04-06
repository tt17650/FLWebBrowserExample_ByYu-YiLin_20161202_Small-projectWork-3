namespace FLWebBrowserExample {
    partial class FLWBE2016_EditFavorites {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLWBE2016_EditFavorites));
            this.txtBox_ReadPath = new System.Windows.Forms.TextBox();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lab_txtBoxReadPath = new System.Windows.Forms.Label();
            this.listBoxCon = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_SaveClose = new System.Windows.Forms.Button();
            this.btn_ReNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CancelClose = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.lab_ConName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_ReadPath
            // 
            this.txtBox_ReadPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox_ReadPath.Location = new System.Drawing.Point(100, 17);
            this.txtBox_ReadPath.Name = "txtBox_ReadPath";
            this.txtBox_ReadPath.Size = new System.Drawing.Size(294, 29);
            this.txtBox_ReadPath.TabIndex = 0;
            this.txtBox_ReadPath.Text = "FavoritesData.txt";
            // 
            // btn_Read
            // 
            this.btn_Read.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Read.Image = ((System.Drawing.Image)(resources.GetObject("btn_Read.Image")));
            this.btn_Read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Read.Location = new System.Drawing.Point(400, 14);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Read.Size = new System.Drawing.Size(110, 30);
            this.btn_Read.TabIndex = 3;
            this.btn_Read.Text = "讀取檔案";
            this.btn_Read.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_ReadL_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(516, 14);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Save.Size = new System.Drawing.Size(110, 30);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "確認存檔";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lab_txtBoxReadPath
            // 
            this.lab_txtBoxReadPath.AutoSize = true;
            this.lab_txtBoxReadPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_txtBoxReadPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_txtBoxReadPath.Location = new System.Drawing.Point(7, 20);
            this.lab_txtBoxReadPath.Name = "lab_txtBoxReadPath";
            this.lab_txtBoxReadPath.Size = new System.Drawing.Size(89, 20);
            this.lab_txtBoxReadPath.TabIndex = 6;
            this.lab_txtBoxReadPath.Text = "檔案路徑：";
            // 
            // listBoxCon
            // 
            this.listBoxCon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBoxCon.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxCon.FormattingEnabled = true;
            this.listBoxCon.ItemHeight = 20;
            this.listBoxCon.Location = new System.Drawing.Point(19, 103);
            this.listBoxCon.Name = "listBoxCon";
            this.listBoxCon.Size = new System.Drawing.Size(539, 344);
            this.listBoxCon.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(7, 17);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Add.Size = new System.Drawing.Size(110, 50);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "增加書籤";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Del.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Del.Image = ((System.Drawing.Image)(resources.GetObject("btn_Del.Image")));
            this.btn_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Del.Location = new System.Drawing.Point(7, 73);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Del.Size = new System.Drawing.Size(110, 50);
            this.btn_Del.TabIndex = 9;
            this.btn_Del.Text = "刪除書籤";
            this.btn_Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_SaveClose
            // 
            this.btn_SaveClose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SaveClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SaveClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveClose.Location = new System.Drawing.Point(8, 17);
            this.btn_SaveClose.Name = "btn_SaveClose";
            this.btn_SaveClose.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_SaveClose.Size = new System.Drawing.Size(110, 50);
            this.btn_SaveClose.TabIndex = 10;
            this.btn_SaveClose.Text = "存檔＆關閉";
            this.btn_SaveClose.UseVisualStyleBackColor = true;
            this.btn_SaveClose.Click += new System.EventHandler(this.btn_SaveClose_Click);
            // 
            // btn_ReNew
            // 
            this.btn_ReNew.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ReNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ReNew.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReNew.Image")));
            this.btn_ReNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReNew.Location = new System.Drawing.Point(7, 129);
            this.btn_ReNew.Name = "btn_ReNew";
            this.btn_ReNew.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_ReNew.Size = new System.Drawing.Size(110, 50);
            this.btn_ReNew.TabIndex = 11;
            this.btn_ReNew.Text = "重新產生";
            this.btn_ReNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ReNew.UseVisualStyleBackColor = true;
            this.btn_ReNew.Click += new System.EventHandler(this.btn_ReNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_Read);
            this.groupBox1.Controls.Add(this.txtBox_ReadPath);
            this.groupBox1.Controls.Add(this.lab_txtBoxReadPath);
            this.groupBox1.Location = new System.Drawing.Point(19, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 51);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "檔案管理工具";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ReNew);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(575, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 188);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "網頁書籤管理工具";
            // 
            // btn_CancelClose
            // 
            this.btn_CancelClose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CancelClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CancelClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelClose.Location = new System.Drawing.Point(8, 73);
            this.btn_CancelClose.Name = "btn_CancelClose";
            this.btn_CancelClose.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_CancelClose.Size = new System.Drawing.Size(110, 50);
            this.btn_CancelClose.TabIndex = 14;
            this.btn_CancelClose.Text = "取消＆關閉";
            this.btn_CancelClose.UseVisualStyleBackColor = true;
            this.btn_CancelClose.Click += new System.EventHandler(this.btn_CancelClose_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.Location = new System.Drawing.Point(669, 20);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(30, 30);
            this.btn_Help.TabIndex = 15;
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // lab_ConName
            // 
            this.lab_ConName.AutoSize = true;
            this.lab_ConName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ConName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_ConName.Location = new System.Drawing.Point(19, 80);
            this.lab_ConName.Name = "lab_ConName";
            this.lab_ConName.Size = new System.Drawing.Size(543, 21);
            this.lab_ConName.TabIndex = 16;
            this.lab_ConName.Text = "書籤檔案內容(列表)：                                   (內容單行標準格式：Name,URL)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CancelClose);
            this.groupBox3.Controls.Add(this.btn_SaveClose);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(575, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 130);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "視窗關閉功能區";
            // 
            // FLWBE2016_EditFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lab_ConName);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxCon);
            this.Name = "FLWBE2016_EditFavorites";
            this.Text = "網頁書籤管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLWBE2016_EditFavorites_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Label lab_txtBoxReadPath;
        private System.Windows.Forms.ListBox listBoxCon;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.TextBox txtBox_ReadPath;
        public System.Windows.Forms.Button btn_Del;
        public System.Windows.Forms.Button btn_SaveClose;
        private System.Windows.Forms.Button btn_ReNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btn_CancelClose;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Label lab_ConName;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}