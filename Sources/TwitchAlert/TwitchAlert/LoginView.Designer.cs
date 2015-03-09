namespace TwitchAlert
{
    partial class LoginView
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
            this.wbLogin = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbLogin
            // 
            this.wbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbLogin.Location = new System.Drawing.Point(0, 0);
            this.wbLogin.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLogin.Name = "wbLogin";
            this.wbLogin.Size = new System.Drawing.Size(473, 333);
            this.wbLogin.TabIndex = 0;
            this.wbLogin.Url = new System.Uri("http://froelicher.github.io/TwitchAlert/test/integration.html", System.UriKind.Absolute);
            this.wbLogin.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbLogin_DocumentCompleted);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 333);
            this.Controls.Add(this.wbLogin);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbLogin;
    }
}