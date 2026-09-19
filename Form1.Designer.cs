namespace IFASBrowserApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.WebBrowser ieBrowser;
        private System.Windows.Forms.Panel topPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.ieBrowser = new System.Windows.Forms.WebBrowser();

            // Form Title & Unicode Font (எல்லா மொழிகளுக்கும்)
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Text = "🪏 IFAS BROWSER - Multi-Language Camera Viewer";
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            // Top Panel
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Height = 50;

            // TextBox (IP Address)
            this.txtUrl.Location = new System.Drawing.Point(15, 12);
            this.txtUrl.Size = new System.Drawing.Size(400, 25);
            this.txtUrl.Text = "192.168.1.108";

            // Open Button (அனைத்து மொழி எழுத்துகளையும் ஆதரிக்கும்)
            this.btnGo.Location = new System.Drawing.Point(425, 10);
            this.btnGo.Size = new System.Drawing.Size(90, 28);
            this.btnGo.Text = "திற / Open";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);

            // Panel Controls Add
            this.topPanel.Controls.Add(this.txtUrl);
            this.topPanel.Controls.Add(this.btnGo);
            this.Controls.Add(this.topPanel);

            // Browser Engine
            this.ieBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(this.ieBrowser);
            this.ieBrowser.BringToFront();
        }
    }
}
