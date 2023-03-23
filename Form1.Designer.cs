namespace chromium
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Go = new System.Windows.Forms.ToolStripButton();
            this.addBrowser = new System.Windows.Forms.ToolStripButton();
            this.removeBrowserTab = new System.Windows.Forms.ToolStripButton();
            this.searchbox = new System.Windows.Forms.ToolStripTextBox();
            this.BrowserTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.BrowserTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1200, 658);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Go,
            this.addBrowser,
            this.removeBrowserTab,
            this.searchbox,
            this.RefreshButton,
            this.BackButton,
            this.ForwardButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1200, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.White;
            this.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Go.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Go.Image = ((System.Drawing.Image)(resources.GetObject("Go.Image")));
            this.Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(23, 29);
            this.Go.Text = "Go";
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // addBrowser
            // 
            this.addBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addBrowser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addBrowser.Image = ((System.Drawing.Image)(resources.GetObject("addBrowser.Image")));
            this.addBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBrowser.Name = "addBrowser";
            this.addBrowser.Size = new System.Drawing.Size(29, 29);
            this.addBrowser.Text = "+";
            this.addBrowser.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // removeBrowserTab
            // 
            this.removeBrowserTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeBrowserTab.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.removeBrowserTab.Image = ((System.Drawing.Image)(resources.GetObject("removeBrowserTab.Image")));
            this.removeBrowserTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBrowserTab.Name = "removeBrowserTab";
            this.removeBrowserTab.Size = new System.Drawing.Size(24, 29);
            this.removeBrowserTab.Text = "-";
            this.removeBrowserTab.Click += new System.EventHandler(this.removeBrowserTab_Click);
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(748, 32);
            this.searchbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Browsing_KeyDown);
            // 
            // BrowserTabs
            // 
            this.BrowserTabs.Controls.Add(this.tabPage1);
            this.BrowserTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserTabs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowserTabs.ItemSize = new System.Drawing.Size(600, 25);
            this.BrowserTabs.Location = new System.Drawing.Point(0, 32);
            this.BrowserTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowserTabs.Name = "BrowserTabs";
            this.BrowserTabs.SelectedIndex = 0;
            this.BrowserTabs.Size = new System.Drawing.Size(1200, 626);
            this.BrowserTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1192, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::chromium.Properties.Resources.Refresh_icon;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 29);
            this.RefreshButton.Text = "toolStripButton1";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(23, 29);
            this.ForwardButton.Text = "toolStripButton2";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 29);
            this.BackButton.Text = "toolStripButton3";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.BrowserTabs);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.BrowserTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Go;
        private System.Windows.Forms.ToolStripTextBox searchbox;
        private System.Windows.Forms.TabControl BrowserTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripButton addBrowser;
        private System.Windows.Forms.ToolStripButton removeBrowserTab;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripButton BackButton;
    }
}

