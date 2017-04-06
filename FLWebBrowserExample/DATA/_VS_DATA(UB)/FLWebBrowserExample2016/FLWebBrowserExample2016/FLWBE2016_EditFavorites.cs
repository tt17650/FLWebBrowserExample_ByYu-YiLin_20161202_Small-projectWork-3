using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FLWebBrowserExample {
    public partial class FLWBE2016_EditFavorites : Form {
        private TextBox txtBoxFilePath;
        private ListBox listBoxContent;
        public Boolean MainAdd = false;
        public string AddtbCont_Name, AddtbCont_Url;
        public FLWBE2016_AddFavorites addFrm = new FLWBE2016_AddFavorites();
        public FLWebBrowserExample2016Main MainForm;

        public FLWBE2016_EditFavorites() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //FLWebBrowserExample2016Main main = (FLWebBrowserExample2016Main)this.Owner;
            ReadFile(txtBox_ReadPath, listBoxCon);
        }

        private void btn_ReadL_Click(object sender, EventArgs e) {
            listBoxCon.Items.Clear();
            OpenReadFile(txtBox_ReadPath, listBoxCon);
        }

        private void btn_Del_Click(object sender, EventArgs e) {
            listBoxCon.Items.Remove(listBoxCon.SelectedItem);
            //MainForm.Upadta_wwwComBoxALData();
        }

        public void btn_Add_Click(object sender, EventArgs e) {
            if (MainAdd !=true) {
                addFrm.txtName.Clear();
                addFrm.txtURL.Clear();
            }
            if (addFrm.ShowDialog() == DialogResult.OK) {
                AddtbCont_Name = addFrm.txtName.Text;
                AddtbCont_Url = addFrm.txtURL.Text;
                string addStr = addFrm.txtName.Text + "," + addFrm.txtURL.Text;
                listBoxCon.Items.Add(addStr);
                //MainForm.Upadta_wwwComBoxALData();
            }
            this.MainAdd = false;
        }

        public void btn_Save_Click(object sender, EventArgs e) {
            SaveWriteFile(txtBox_ReadPath, listBoxCon);
            MainForm.Upadta_wwwComBoxALData();
        }

        private void btn_SaveClose_Click(object sender, EventArgs e) {
            SaveWriteFile(txtBox_ReadPath, listBoxCon);
            MainForm.Upadta_wwwComBoxALData();
            this.Hide();
        }

        private void btn_CancelClose_Click(object sender, EventArgs e) {
            listBoxCon.Items.Clear();
            ReadFile(txtBox_ReadPath, listBoxCon);
            this.Hide();
        }

        private void btn_ReNew_Click(object sender, EventArgs e) {
            listBoxCon.Items.Clear();
            string addStr = "--網站連結--" + ",";
            listBoxCon.Items.Add(addStr);
        }

        private void btn_Help_Click(object sender, EventArgs e) {
            FLWBE2016_EditFavorites_Help editHelp = new FLWBE2016_EditFavorites_Help();
            editHelp.Show();
            editHelp.Focus();
        }

        /// <summary>
        /// 【Function】讀取檔案(開啟舊檔)
        /// </summary>
        /// <param name="txtBxRP">存檔路徑(抓取TextBox，只需給到資料夾)</param>
        /// <param name="txtBxC">文字檔案的內容(顯示在TextBox)</param>
        private void OpenReadFile(TextBox txtBxRP, ListBox txtBxC) {
            //讀取檔案(開啟舊檔)
            txtBoxFilePath = txtBxRP;
            listBoxContent = txtBxC;
            using (OpenFileDialog OFD = new OpenFileDialog()) {
                try {
                    OFD.InitialDirectory = System.Windows.Forms.Application.StartupPath;  //設置預設目錄路徑
                    OFD.Filter = "文字檔(*.txt)|*.txt|PO翻譯檔(*.po)|*.po|所有檔案(*.*)|*.*";  //設置文件檔類型
                                                                                     //OFD.ShowDialog();
                    DialogResult result = OFD.ShowDialog();  //接收Dialog對話方塊的回傳值
                    if (result != DialogResult.OK) { return; }  //判斷回傳值(result)如果不是OK(Cancel)，就回傳空字串
                    txtBoxFilePath.Text = OFD.FileName;
                    ReadFile(txtBxRP, txtBxC);
                }
                catch {
                }
            }
        }

        private void ReadFile(TextBox txtBxRP, ListBox txtBxC) {
            string line, nameStr, urlStr;
            txtBoxFilePath = txtBxRP;
            listBoxContent = txtBxC;
            StreamReader SReader = new StreamReader(txtBoxFilePath.Text, Encoding.UTF8);  //StreamWriter(path,encoding),資料流讀取器
            while ((line = SReader.ReadLine()) != null) {
                string SpecKey = ",";
                int nameStrIndex = 0, nameStrLength = line.IndexOf(SpecKey) - nameStrIndex;
                int urlStrIndex = line.IndexOf(SpecKey), urlStrLength = line.Length - nameStrLength;
                nameStr = line.Substring(nameStrIndex, nameStrLength);
                urlStr = line.Substring(urlStrIndex, urlStrLength);

                listBoxCon.Items.Add(line);
            }
            listBoxContent.Text = SReader.ReadToEnd();
            SReader.Close();
        }

        /// <summary>
        /// 【Function】寫入檔案(另存存檔)
        /// </summary>
        /// <param name="txtBxWP">存檔路徑(抓取TextBox，只需給到資料夾)</param>
        /// <param name="txtBxC">文字檔案的內容(抓取TextBox)</param>
        private void SaveWriteFile(TextBox txtBxWP, ListBox txtBxC) {
            //寫入檔案(另存存檔)
            txtBoxFilePath = txtBxWP;
            listBoxContent = txtBxC;

            if (txtBxWP == null) {
                using (SaveFileDialog SFD = new SaveFileDialog()) {
                    try {
                        SFD.InitialDirectory = System.Windows.Forms.Application.StartupPath;  //設置預設目錄路徑
                        SFD.Filter = "文字檔(*.txt)|*.txt|PO翻譯檔(*.po)|*.po|所有檔案(*.*)|*.*";  //設置文件檔類型
                                                                                         //SFD.ShowDialog();
                        DialogResult result = SFD.ShowDialog();  //接收Dialog對話方塊的回傳值
                        if (result != DialogResult.OK) { return; }  //判斷回傳值(result)如果不是OK(Cancel)，就回傳空字串
                        txtBoxFilePath.Text = SFD.FileName;
                        WriteFile(txtBxWP, txtBxC);
                    }
                    catch {
                    }
                }
            }
            else {
                WriteFile(txtBxWP, txtBxC);
            }
        }

        private void WriteFile(TextBox txtBxWP, ListBox txtBxC) {
            txtBoxFilePath = txtBxWP;
            listBoxContent = txtBxC;
            StreamWriter SWriter = new StreamWriter(txtBoxFilePath.Text); //StreamWriter(path),資料流寫入器
            foreach (object item in listBoxCon.Items) {
                SWriter.WriteLine(item.ToString());
            }
            SWriter.Close();
        }

        public void setAddtbCont(string name, string url) {
            //MessageBox.Show("Name： " + name + " , URL： " + url);
            addFrm.txtName.Text = name;
            addFrm.txtURL.Text = url;
        }

        private void FLWBE2016_EditFavorites_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }
    }
}
