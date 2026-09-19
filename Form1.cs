using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace IFASBrowserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetIE11Emulation();

            // IFAS BROWSER Icon அமைப்பது
            if (System.IO.File.Exists("logo.ico"))
            {
                this.Icon = new System.Drawing.Icon("logo.ico");
            }
        }

        // IE11 Mode & ActiveX அனுமதி
        private void SetIE11Emulation()
        {
            try
            {
                string appName = System.IO.Path.GetFileName(Application.ExecutablePath);
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION"))
                {
                    if (key != null)
                    {
                        key.SetValue(appName, 11001, RegistryValueKind.DWord);
                    }
                }
            }
            catch (Exception)
            {
                // Registry அனுமதி பிழைகள் புறக்கணிக்கப்படும்
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url)) return;

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            ieBrowser.Navigate(url);
        }
    }
}
