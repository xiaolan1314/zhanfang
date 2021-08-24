using System;
using CefSharp;
using CefSharp.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
//using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json.Linq;

namespace test2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public static string textbox = string.Empty;
        public static string webview = string.Empty;
        public static string Proxy;
        string fileFullPath = @System.Environment.CurrentDirectory + "\\cache";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void InitializeChromium()
        {
            //MessageBox.Show(a);

            CefSettings settings = new CefSettings()
            {
                UserAgent = "Mozilla/5.0 (Linux; Android 8.0; xiaomi 11 Build/LRX21T) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.3973.203 Chrome/71.0.3273.101 Chrome/83.0.3983.103 Mobile Safari/537.36",
            };

            //Initialize cef with the provided settings

            //CefSharp.CefSettings setting = new CefSharp.CefSettings();
            //
            //Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(textbox);
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.None;

            chromeBrowser.Height = 500;
            chromeBrowser.Width = 1150;



        }

       

        private void chromiumHostControl1_Click(object sender, EventArgs e)
        {

        }

        private void button_star_Click(object sender, EventArgs e)
        {
            //Cef.GetGlobalCookieManager().DeleteCookies("", "");
            textbox = this.textBox_web_url.Text;
            //orm2.a = textbox;
            Form2.a = textbox;
            // MessageBox.Show(textbox);

            // ChromiumWebBrowser webview1 = new ChromiumWebBrowser("");//打开指定的网址
            //ChromiumWebBrowser webview = new ChromiumWebBrowser(textbox);//打开指定的网址

            // webview.KeyboardHandler=new CEF

            //Dock = DockStyle.Fill;
            /*  webview.Dock = DockStyle.None;

              webview.Height = 500;
              webview.Width = 1150;*/
            //webview.Left = 320;
            //webview.Top = 60;
            if (this.textBox_web_url.Text != "")
            {
                //Form2 frm2 = new Form2();
                //frm2.Show();
                Thread a = new Thread(new ThreadStart(fs));
                a.Start();
            }
            else
            {
                MessageBox.Show("");
            }
            Cef.Shutdown();
            ///InitializeChromium();

        }

        delegate void af();
        private void fs()
        {
            this.Invoke(new af(afd));
        }
        private void afd()
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }



        private void chromiumHostControl1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chromeBrowser.GetBrowser().CloseBrowser(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string proxy_api=this.textBox_proxy_api.Text;
            if (proxy_api != "")
            {
                this.button_proxy_get.Text = "正在获取...";
                //string ss = HttpWebRequest_Get("http://proxy.xlhhy.cn/get/?type=https");
                string ss = HttpWebRequest_Get(proxy_api);
                //MessageBox.Show(ss);

                JObject jobj = JObject.Parse(ss);                                       //正则
                string proxy_ip = jobj["proxy"].ToString();
                string last_time = jobj["last_time"].ToString();
                string https = jobj["https"].ToString();
                //MessageBox.Show(https);

                //Form2.Proxy = proxy_ip;
                Form2.Proxy = proxy_ip;

                string https_check;
                if (https == "True")
                {
                    https_check = "是";
                }
                else
                {
                    https_check = "否";
                }
                this.label_proxy_ip.Text = proxy_ip;
                this.label_last_time.Text = last_time;
                this.label_https_check.Text = https_check;
                this.button_proxy_get.Text = "获取成功!";
                
            }
            else
            {
                MessageBox.Show("请输入代理获取api！！");
            }
            //MessageBox.Show("请输入api地址！");
        }
        public static string HttpWebRequest_Get(string url)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            
            //构造一个Web请求的对象
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            

            //获取web请求的响应的内容
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        private void label_last_time_Click(object sender, EventArgs e)
        {

        }

        private void textBox_proxy_api_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.textBox_proxy_api.Text = "http://proxy.xlhhy.cn/get/?type=https";
        }

        private void textBox_ua_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ua_Click(object sender, EventArgs e)
        {
            string autoua=HttpWebRequest_Get("http://8.136.15.120/User-Agent/Edge.php");
            //string web_ua= "Mozilla/5.0 (Linux; Android 5.0; SM-G900P Build/LRX21T) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.103 Mobile Safari/537.36";
            Random rd = new Random();
            int i = rd.Next(1,6);
            switch (i)
            {
                case 1:
                    autoua = HttpWebRequest_Get("http://8.136.15.120/User-Agent/Firefox.php");
                    break;
                case 2:
                    autoua = HttpWebRequest_Get("http://8.136.15.120/User-Agent/Chrome.php");
                    break;
                case 3:
                    autoua = HttpWebRequest_Get("http://8.136.15.120/User-Agent/Safari.php");
                    break;
                case 4:
                    autoua = HttpWebRequest_Get("http://8.136.15.120/User-Agent/Opera.php");
                    break;
                case 5:
                    autoua = HttpWebRequest_Get("http://8.136.15.120/User-Agent/Android Webkit Browser.php");
                    break;
                case 6:
                    autoua = HttpWebRequest_Get("http://8.136.15.120/User-Agent/Edge.php");
                    break;
            }
            

            //Form2.web_ua = web_ua;*/
            this.textBox_ua.Text = autoua;
            Form2.web_ua = autoua;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_showip_Click(object sender, EventArgs e)
        {
            this.textBox_web_url.Text = "http://lzltool.com/MyIp";
        }

        private void button_showxlhhy_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int auto_url_number = rd.Next(1, 48);
            string auto_url = "";
            switch (auto_url_number)
            {

                case 1:
                    
                case 2:
                    
                case 3:auto_url = "https://www.baidu.com/link?url=ppOu2wxFkt8eceSS4SnA4L7MXTYwR-UOiQIYsN2Ftwy&wd=&eqid=a6e2f83400095d6e00000005611e44b7";
                    break;
                    
                case 4:
                    auto_url = "https://www.baidu.com/link?url=b-mh_Gz7ab0nkrkXOxRtj6cCNx6XgebdPXSXU0hGKYMNxn2fqAurRazr-L7emVE5fBPLgASKL44IPT0-XIumd_&wd=&eqid=a6e2f83400095d6e00000005611e44b7";
                    break;
                case 5:
                    
                case 6:auto_url = "https://www.baidu.com/link?url=d-itZtexvAxprPrn1Jm68M4uKRbvq3B-w8G5Ac57i_1Sh8-aRBHOfa5fBw6j8g-4&wd=&eqid=a6e2f83400095d6e00000005611e44b7";
                    break;
                    
                case 7:
                    
                case 8:auto_url = "https://www.baidu.com/link?url=IThf6FX7o6tUlCxjIIUyl48R7vY58mtDBN6Q55Ln1P20E-iJqqP7OpEUPlab3xyh&wd=&eqid=a6e2f83400095d6e00000005611e44b7";
                    break;
                    
                case 9:
                    
                case 10:auto_url = "https://www.baidu.com/link?url=hYNb8J44FJEHiyOmhpmG4W0psxQ3W9A1esKEVQ4_FBWlnVgoZiy0pCYEz8m7zanh&wd=&eqid=f5a8350e000924b300000005611e4511";
                    break;
                    
                case 11:
                    
                case 12:auto_url = "https://www.baidu.com/link?url=TBIDtBDh7o3UfCRC2_f2KBKl33jQPi9Q_nkbRCmzRF6dkf_epD-PorOl4O4DjH3w&wd=&eqid=f5a8350e000924b300000005611e4511";
                    break;
                    
                case 13:
                    
                case 14:auto_url = "https://www.baidu.com/link?url=usVsKSmp8RDyfx9UtX9AVapXR6hUqdLnEI0aHTCUyVCV3mfGR4Ls4lS2Fzfpa2sSbKrNBYFF45WBiAweGiyQqq&wd=&eqid=f5a8350e000924b300000005611e4511";
                    break;
                    
                case 15:
                    
                case 16:auto_url = "https://www.baidu.com/link?url=6It3HF7XYmBYAiRchFYI9kfkNjkOcTlcMirps5sKAeIM5uBJw6kOql0vGaOC5RQH&wd=&eqid=f5a8350e000924b300000005611e4511";
                    break;
                    
                case 17:
                   
                case 18:auto_url = "https://www.baidu.com/link?url=-8tj_9PIIyWlP7Mn1qTzlHQhlx52og67NUjp8reeT_o_z_cZb-t0ZLRUV9WiTk4Z&wd=&eqid=f5a8350e000924b300000005611e4511";
                    break;
                    
                case 19:
                   
                case 20: auto_url = "https://www.baidu.com/link?url=1KyU35blUjd9e2PcQF24fTPydOXdw_1JYNCfUwoVHIPku9-BLVSAfom0Rf0hhIm-&wd=&eqid=f5a8350e000924b300000005611e4511";
                    break;
                    
                case 21:
                    
                case 22:auto_url = "https://www.baidu.com/link?url=RKURNw13eslit_uQiAnHongj5bw0iXNrUlxoNT6qko_xTvFQLJPKvFC38hHV3puF&wd=&eqid=ce63ca9c00095f4f00000005611e4546  ";
                    break;
                   
                case 23:
                    
                case 24:auto_url = "https://www.baidu.com/link?url=44FAZzZKODh39e6ZYVuQ9VleKhQE-ubpS3ESyOegcxCQwjVA-BUT5OnJeLifjcH9&wd=&eqid=cd6a22210009ad0800000005611e4562";
                    break;
                   
                case 25:
                    
                case 26:auto_url = "https://www.baidu.com/link?url=ORNatnb9GYJas8buuxvGocFGzMyQtnSSLA9hgCrPZ5UHDLWB6v_JWbKWu7yAYcrfv_c4CnTkMY6_D8JJsqf2Vq&wd=&eqid=8c1cbbd70009844700000005611e4571";
                    break;
                   
                case 27:
                   
                case 28:
                   
                case 29:auto_url = "https://www.baidu.com/link?url=O3bh_fRWwyW5krZBfMqOOigNXNKKmF16E_OcLNREsbK5u2Gdr_IYbBzt72Y_BOHYkeka9SqC7AL4pxlKTViKAK&wd=&eqid=fadd59670009b07700000005611e45c0";
                    break;
                   
                case 30:
                    
                case 31:
                    auto_url = "https://www.baidu.com/link?url=Q9ZygTYAWHFDxsx53X--FCJWDBNTJawrhYi4OpK8Zu87Tezf-JGZWsP6Rlb9IarZ&wd=&eqid=fadd59670009b07700000005611e45c0";
                    break;
                case 32:
                    
                case 33:
                    
                case 34:
                    auto_url = "https://www.xlhhy.cn/archives/513/";
                    break;
                case 35:
                    
                case 36:
                    
                case 37:auto_url = "https://www.xlhhy.cn/archives/566/";
                    break;
                   
                case 38:
                    
                case 39:
                    
                case 40: auto_url = "https://www.xlhhy.cn/archives/599/";
                    break;
                   
                case 41:
                    
                case 42:
                   
                case 43:
                    auto_url = "https://www.xlhhy.cn/archives/578/";
                    break;
                    
                case 44:
                    auto_url = "https://www.xlhhy.cn/archives/622/";
                    break;
                case 45:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                    auto_url = "https://www.xlhhy.cn/start-page.html";
                    break;
                case 46:
                    auto_url = "https://www.xlhhy.cn/413.html";
                    break;
                case 47:
                    auto_url = "https://www.xlhhy.cn/415.html";
                    break;
                case 48:
                    auto_url = "https://www.xlhhy.cn/417.html";
                    break;
                case 49:
                    auto_url = "https://www.xlhhy.cn/419.html";
                    break;

                
            }


            this.textBox_web_url.Text = auto_url;

        }

        private void button_showbaidu_Click(object sender, EventArgs e)
        {
            this.textBox_web_url.Text = "https://www.baidu.com";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.xlhhy.cn");
        }

        private void button_delete_cache_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(fileFullPath);


            {

                if (Directory.Exists(@fileFullPath))
                {

                    Directory.Delete(fileFullPath, true);
                    this.button_delete_cache.Text="已清空缓存";
                    //Thread.Sleep(500);//睡眠500毫秒，也就是0.5秒
                    
                }

                else

                    this.button_delete_cache.Text = "无缓存";

            }
                //Directory.Delete(fileFullPath, true);
                //MessageBox.Show("删除文件夹成功");


                File.Delete(fileFullPath);
            
            
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            button_getproxy_api.PerformClick();

            button_proxy_get.PerformClick();

            button_ua.PerformClick();

            button_showxlhhy.PerformClick();

            //button_delete_cache.PerformClick();
            MessageBox.Show("初始化成功，立即开始？");

            button_star.PerformClick();
        }
    }       
}
