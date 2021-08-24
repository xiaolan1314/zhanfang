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
using System.IO;

namespace test2
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public static ChromiumWebBrowser chromeBrowser;
        public static string a;
        public static string Proxy;
        public static string web_ua;
        private string url_xianshi;

        public Form2()
        {
            InitializeComponent();

            InitializeChromium();


            /*ChromiumWebBrowser webview = new ChromiumWebBrowser(a);//打开指定的网址

            // webview.KeyboardHandler=new CEF

            Dock = DockStyle.Fill;
            *//*  webview.Dock = DockStyle.None;

              webview.Height = 500;
              webview.Width = 1150;*//*
            //webview.Left = 320;
            //webview.Top = 60;;
            this.Controls.Add(webview);*/

        }

        internal class OpenPageSelf : ILifeSpanHandler
        {
            public bool DoClose(IWebBrowser browserControl, IBrowser browser)
            {
                return false;
            }

            public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
            {

            }

            public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
            {

            }

            public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl,
    string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures,
    IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
            {
                newBrowser = null;
                var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;
                chromiumWebBrowser.Load(targetUrl);
                return true; //Return true to cancel the popup creation copyright by codebye.com.
            }
        }




        private void InitializeChromium()
        {
            Random rd = new Random();
            int mulu1 = rd.Next(1, 10000);
            int mulu2 = rd.Next(1, 10000);
            int mulu3 = rd.Next(1, 10000);
            int mulu4 = rd.Next(1, 10000);
            int mulu5 = rd.Next(1, 10000);
            //MessageBox.Show(a);
            //Cef.GetGlobalCookieManager().DeleteCookies("", "");
            var settings = new CefSettings()
            {

                UserAgent = web_ua,
            };
            //settings.CefCommandLineArgs.Add("proxy-server", "222.74.202.244:80");

            settings.CachePath = "cache\\"+mulu1+"\\"+mulu2 + "\\" + mulu3 + "\\" + mulu4 + "\\" + mulu5;
            
            settings.CefCommandLineArgs.Add("proxy-server", Proxy);
            //CefSharp.CefSharpSettings.Proxy = new CefSharp.ProxyOptions("122.237.105.194", "80");
            settings.Locale = "zh-CN";
            settings.AcceptLanguageList = "zh-CN,zh;q=0.8";



            //Initialize cef with the provided settings

            //CefSharp.CefSettings setting = new CefSharp.CefSettings();
            //
            //CefSharp.IRequestHandler request;
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(a)
            {
                BrowserSettings =
                        {
                            DefaultEncoding = "UTF-8"
                        }
            };
            // Add it to the form and fill it to the form window.

            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.LifeSpanHandler = new OpenPageSelf();
            this.Controls.Add(chromeBrowser);
            chromeBrowser.AddressChanged += new EventHandler<AddressChangedEventArgs>(web_Auto_AddressChanged);



        }
        private void web_Auto_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            //e.Address就是网址所在了
            //this.Text = e.Address;
            //this.label_url_xianshi.Text= e.Address;
            SetTxt_Url(e.Address);
        }

        private delegate void str_Delegate(string str);

        private void SetTxt_Url(string str)

        {

            //外线程调用

            if (InvokeRequired)

            {

                Invoke(new str_Delegate(SetTxt_Url), str);

                return;

            }

            this.Text = str;

        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 销毁
            Cef.Shutdown();

           System.Diagnostics.Process.GetCurrentProcess().Kill();


        }

        
            
        
        private void chromiumHostControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.Text = url_xianshi;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cef.Shutdown();

        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            chromeBrowser.GetBrowser().Reload();
        }

    }
}
