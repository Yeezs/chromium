using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chromium
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser chromiumBrowser = null;
        List<ChromiumWebBrowser> chromiumBrowsers = new List<ChromiumWebBrowser>();
        public Form1()
        {
            InitializeComponent();
            InitializeBrowswer();
        }

        public void InitializeBrowswer()
        {
            var settings = new CefSettings();
            Cef.Initialize(settings);
            chromiumBrowser = new ChromiumWebBrowser("https://google.com");
            BrowserTabs.TabPages[0].Controls.Add(chromiumBrowser);
            chromiumBrowser.Dock = DockStyle.Fill;

            chromiumBrowser = new ChromiumWebBrowser("https://google.com");
            BrowserTabs.TabPages[1].Controls.Add(chromiumBrowser);
            chromiumBrowser.Dock = DockStyle.Fill;

        }

        private void Go_Click(object sender, EventArgs e)
        {
            string text;
            text = searchbox.Text;

            TabPage tabPage = new TabPage();
            tabPage.Text = "BrowserPage";

            chromiumBrowser = new ChromiumWebBrowser($"https://google.com/search?q={text}");
            tabPage.Controls.Add(chromiumBrowser);
            chromiumBrowser.Dock = DockStyle.Fill;

            BrowserTabs.TabPages.Add(tabPage);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddBrowserTab();
        }

        private void AddBrowserTab()
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "BrowserPage";

            chromiumBrowser = new ChromiumWebBrowser("https://google.com");
            tabPage.Controls.Add(chromiumBrowser);
            chromiumBrowser.Dock = DockStyle.Fill;

            BrowserTabs.TabPages.Add(tabPage);
        }

        private void removeBrowserTab_Click(object sender, EventArgs e)
        {
            try
            {
                if(BrowserTabs.TabCount > 1)
                {
                    BrowserTabs.TabPages.Remove(BrowserTabs.SelectedTab);
                }
                else
                {
                    AddBrowserTab();
                }
            }
            catch(Exception)
            {

            }
        }
    }
}
