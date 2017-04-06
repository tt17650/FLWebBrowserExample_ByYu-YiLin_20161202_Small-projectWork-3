using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FLWebBrowserExample {
    public partial class FLWebBrowserExample2016Main : Form {
        FLWBE2016_EditFavorites Favorites = new FLWBE2016_EditFavorites();
        private ArrayList wwwComBoxFavoritesArrayListData = new ArrayList();
        #region Flog(Boolean)
        Boolean isUpadta_wwwComBoxALData = false;
        #endregion

        public FLWebBrowserExample2016Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Favorites.Owner = this;
            webBrowser1.Hide();   //隱藏webBrowser1元件
            panelHelp.Hide();   //隱藏panel1元件
            this.Text = "Welcome to FL_WebBrowser";
            txtWebURL.Clear();
            ReadFavoritesFile();
            initCbxCity();
            progressBar1.Visible = false;
            progressBar1.Hide();
        }

        #region Web_Button_Click
        private void backBtn_Click(object sender, EventArgs e) {
            // 上一頁
            webBrowser1.GoBack();
        }

        private void forwardBtn_Click(object sender, EventArgs e) {
            // 下一頁
            webBrowser1.GoForward();
        }

        private void refreshBtn_Click(object sender, EventArgs e) {
            // 重新整理
            webBrowser1.Refresh();
        }

        private void stopBtn_Click(object sender, EventArgs e) {
            // 停止
            webBrowser1.Stop();
        }

        private void homeBtn_Click(object sender, EventArgs e) {
            // 首頁
            webBrowser1.GoHome();
        }

        private void helpBtn_Click(object sender, EventArgs e) {
            //幫助
            webBrowser1.Hide();   //隱藏webBrowser1元件
            panelHelp.Show();   //顯示panel1元件
        }

        private void goBtn_Click(object sender, EventArgs e) {
            //前往
            panelHelp.Hide();   //隱藏panel1元件
            webBrowser1.Show();   //顯示webBrowser1元件
            // 前往網址輸入框中的網址
            webBrowser1.Navigate(txtWebURL.Text);
            // 顯示ProgressBar
            progressBar1.Visible = true;
            progressBar1.Show();
        }
        #endregion

        #region Web_simButton_Click
        private void btnClosePage_Click(object sender, EventArgs e) {
            txtWebURL.Clear();
            webBrowser1.Hide();   //隱藏webBrowser1元件
            webBrowser1.Navigate("about:blank");   //設定webBrowser到指定url(空白頁)
            this.Text = "Welcome to FL_WebBrowser";
            panelHelp.Hide();   //隱藏panel1元件
            wwwComBox.SelectedIndex = 0;
        }

        private void btnEditFavorites_Click(object sender, EventArgs e) {
            Favorites.MainForm = this;
            Favorites.Opacity = 1.0;
            Favorites.Show();
            Favorites.Focus();
        }

        private void btnAddFavorites_Click(object sender, EventArgs e) {
            Favorites.MainAdd = true;
            Favorites.Opacity = 0.0;
            Favorites.Show();
            Favorites.setAddtbCont(webBrowser1.DocumentTitle, txtWebURL.Text);
            Favorites.btn_Add_Click(sender, e);
            if (Favorites.addFrm.DialogResult == DialogResult.OK) {
                Favorites.btn_Save_Click(sender, e);
                //Upadta_wwwComBoxALData();
            }
            Favorites.Hide();
        }
        #endregion

        public void Upadta_wwwComBoxALData() {
            isUpadta_wwwComBoxALData = true;
           
                wwwComBoxFavoritesArrayListData.Clear();
                wwwComBox.DataSource = null;
                //wwwComBox.Items.Clear();
                ReadFavoritesFile();
                initCbxCity();
        }

        private void txtWebURL_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                panelHelp.Hide();   //隱藏panel1元件
                webBrowser1.Show();   //顯示webBrowser1元件
                // 如果在網址輸入框中按下 Enter 則前往網址輸入框中的網址
                webBrowser1.Navigate(txtWebURL.Text);
                // 顯示ProgressBar
                progressBar1.Visible = true;
                progressBar1.Show();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            // WebBrowser 控制項完成文件的載入時。
            // 隱藏ProgressBar
            progressBar1.Visible = false;
            progressBar1.Hide();
            // 把目前的網址顯示在網址輸入框中
            txtWebURL.Text = webBrowser1.Url.ToString();

            if (txtWebURL.Text == "about:blank") {
                // 把視窗標題設為指定字串
                this.Text = "FL_WebBrowser(簡易瀏覽器)";
            }
            else {
                // 把目前的網頁標題顯示在視窗標題中
                this.Text = webBrowser1.DocumentTitle;
            }  
        }

        private void ReadFavoritesFile() {
            string line;
            String nameStr, urlStr;
            StreamReader SReader = new StreamReader(Favorites.txtBox_ReadPath.Text, Encoding.UTF8);  //StreamWriter(path,encoding),資料流讀取器
            while ((line = SReader.ReadLine()) != null) {
                string SpecKey = ",";
                int nameStrIndex = 0, nameStrLength = line.IndexOf(SpecKey) - nameStrIndex;
                int urlStrIndex = line.IndexOf(SpecKey), urlStrLength = line.Length - 1 - nameStrLength;
                nameStr = line.Substring(nameStrIndex, nameStrLength);
                urlStr = line.Substring(urlStrIndex + 1, urlStrLength);
                AddwwwComBoxALData(nameStr, urlStr);
            }
            SReader.Close();
        }

        private void AddwwwComBoxALData(string nameStr, string urlStr) {
            wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry(nameStr, urlStr));
        }

        private void initCbxCity() {
            //wwwComBoxFavoritesArrayListData = new ArrayList();
            #region StartFavoritesData(一開始的Favorites資料)
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("--網站連結--",""));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("Bing - www.bing.com", "www.bing.com"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("Google台灣 - www.google.com.tw", "www.google.com.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("Yahoo!奇摩 - tw.yahoo.com", "tw.yahoo.com"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("Facebook - www.facebook.com", "www.facebook.com"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("Yes123人力銀行 - www.Yes123.com.tw", "www.Yes123.com.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("104人力銀行 - www.104.com.tw", "www.104.com.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("518人力銀行 - www.518.com.tw", "www.518.com.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("1111人力銀行 - www.1111.com.tw", "www.1111.com.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("台灣就業通 - www.taiwanjobs.gov.tw", "www.taiwanjobs.gov.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("中央氣象局 - www.cwb.gov.tw", "www.cwb.gov.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("臺中市政府 - www.taichung.gov.tw", "www.taichung.gov.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("iTaiwan 無線上網 - itaiwan.gov.tw", "itaiwan.gov.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("電子發票整合服務平台 - www.einvoice.nat.gov.tw", "www.einvoice.nat.gov.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("HAPPY GO Card - www.happygocard.com.tw", "www.happygocard.com.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("HAPPY Cash Card - www.happycashcard.com.tw", "www.happycashcard.com.tw"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("Code.org(遊戲學程式) - studio.code.org", "studio.code.org"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("CodeCombat(遊戲學程式) - codecombat.com", "codecombat.com"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("多邻国(遊戲學英語) - www.duolingo.com", "www.duolingo.com"));
            //wwwComBoxFavoritesArrayListData.Add(new DictionaryEntry("-空白頁-", "about:blank"));
            #endregion

            wwwComBox.DisplayMember = "Key";
            wwwComBox.ValueMember = "Value";
            wwwComBox.DataSource = wwwComBoxFavoritesArrayListData;
        }

        public void wwwComBoxSetWB(int index) {
            //整合的comboBox觸發動作
            Object selectedItem = index;
            MessageBox.Show("既將前往．．．\n\n 您所選擇的項目：\n" + wwwComBox.Text + " (" + index + ")",
                "動作確認...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Text = wwwComBox.Text;
            webBrowser1.Navigate(wwwComBox.SelectedValue.ToString());
            // 顯示ProgressBar
            progressBar1.Visible = true;
            progressBar1.Show();
        }

        private void wwwComBox_SelectedIndexChanged(object sender, EventArgs e) {
            //MessageBox.Show(wwwCBX.Text + " (" + wwwCBX.SelectedValue + ")");
            if (wwwComBox.DataSource != null && isUpadta_wwwComBoxALData == false) {
                int selectedIndex = wwwComBox.SelectedIndex;
                panelHelp.Hide();   //隱藏panel1元件
                webBrowser1.Show();   //顯示webBrowser1元件
                if (selectedIndex == 0) {
                    webBrowser1.Hide();   //隱藏webBrowser1元件
                    panelHelp.Show();   //顯示panel1元件
                }
                else if (selectedIndex <= wwwComBoxFavoritesArrayListData.Count) {
                    wwwComBoxSetWB(selectedIndex);
                    this.Text = wwwComBox.Text;
                    webBrowser1.Navigate(wwwComBox.SelectedValue.ToString());
                    // 顯示ProgressBar
                    progressBar1.Visible = true;
                    progressBar1.Show();
                }
            }
            else if (wwwComBox.DataSource != null && isUpadta_wwwComBoxALData == true) {
                MessageBox.Show("書籤(MyFavorites),更新成功!");
                isUpadta_wwwComBoxALData = false;
            }
        }
    }
}
