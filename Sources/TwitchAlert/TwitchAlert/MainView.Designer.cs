namespace TwitchAlert
{
    partial class MainView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panelTwitch = new System.Windows.Forms.Panel();
            this.btnStreamsPopular = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnStreamsOnline = new System.Windows.Forms.Button();
            this.btnChannel = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.panelStreams = new System.Windows.Forms.Panel();
            this.popNotifStreams = new NotificationWindow.PopupNotifier();
            this.timerCheckNewStream = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelTwitch.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTwitch
            // 
            this.panelTwitch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelTwitch.Controls.Add(this.btnStreamsPopular);
            this.panelTwitch.Controls.Add(this.btnLogin);
            this.panelTwitch.Controls.Add(this.btnStreamsOnline);
            this.panelTwitch.Controls.Add(this.btnChannel);
            this.panelTwitch.Location = new System.Drawing.Point(13, 12);
            this.panelTwitch.Name = "panelTwitch";
            this.panelTwitch.Size = new System.Drawing.Size(495, 36);
            this.panelTwitch.TabIndex = 0;
            // 
            // btnStreamsPopular
            // 
            this.btnStreamsPopular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(165)))));
            this.btnStreamsPopular.FlatAppearance.BorderSize = 0;
            this.btnStreamsPopular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStreamsPopular.ForeColor = System.Drawing.Color.White;
            this.btnStreamsPopular.Location = new System.Drawing.Point(10, 7);
            this.btnStreamsPopular.Name = "btnStreamsPopular";
            this.btnStreamsPopular.Size = new System.Drawing.Size(93, 23);
            this.btnStreamsPopular.TabIndex = 3;
            this.btnStreamsPopular.Text = "Streams popular";
            this.btnStreamsPopular.UseVisualStyleBackColor = false;
            this.btnStreamsPopular.Click += new System.EventHandler(this.btnStreamsPopular_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(165)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(336, 7);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnStreamsOnline
            // 
            this.btnStreamsOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(165)))));
            this.btnStreamsOnline.FlatAppearance.BorderSize = 0;
            this.btnStreamsOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStreamsOnline.ForeColor = System.Drawing.Color.White;
            this.btnStreamsOnline.Location = new System.Drawing.Point(139, 7);
            this.btnStreamsOnline.Name = "btnStreamsOnline";
            this.btnStreamsOnline.Size = new System.Drawing.Size(93, 23);
            this.btnStreamsOnline.TabIndex = 1;
            this.btnStreamsOnline.Text = "Streams online";
            this.btnStreamsOnline.UseVisualStyleBackColor = false;
            this.btnStreamsOnline.Click += new System.EventHandler(this.btnStreamsOnline_Click);
            // 
            // btnChannel
            // 
            this.btnChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(62)))), ((int)(((byte)(168)))));
            this.btnChannel.FlatAppearance.BorderSize = 0;
            this.btnChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChannel.ForeColor = System.Drawing.Color.White;
            this.btnChannel.Location = new System.Drawing.Point(238, 7);
            this.btnChannel.Name = "btnChannel";
            this.btnChannel.Size = new System.Drawing.Size(92, 23);
            this.btnChannel.TabIndex = 0;
            this.btnChannel.Text = "Channel Followed";
            this.btnChannel.UseVisualStyleBackColor = false;
            this.btnChannel.Click += new System.EventHandler(this.btnChannel_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.tbxSearch);
            this.panelSearch.Controls.Add(this.cmbSearch);
            this.panelSearch.Location = new System.Drawing.Point(13, 54);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(495, 44);
            this.panelSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(430, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(133, 13);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(291, 20);
            this.tbxSearch.TabIndex = 1;
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Stream name",
            "Game name"});
            this.cmbSearch.Location = new System.Drawing.Point(10, 12);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(117, 21);
            this.cmbSearch.TabIndex = 0;
            // 
            // panelStreams
            // 
            this.panelStreams.AutoScroll = true;
            this.panelStreams.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelStreams.Location = new System.Drawing.Point(12, 104);
            this.panelStreams.Name = "panelStreams";
            this.panelStreams.Size = new System.Drawing.Size(496, 399);
            this.panelStreams.TabIndex = 2;
            // 
            // popNotifStreams
            // 
            this.popNotifStreams.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            this.popNotifStreams.ContentText = null;
            this.popNotifStreams.Image = null;
            this.popNotifStreams.OptionsMenu = null;
            this.popNotifStreams.Size = new System.Drawing.Size(400, 100);
            this.popNotifStreams.TitleFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.popNotifStreams.TitleText = null;
            // 
            // timerCheckNewStream
            // 
            this.timerCheckNewStream.Enabled = true;
            this.timerCheckNewStream.Interval = 10000;
            this.timerCheckNewStream.Tick += new System.EventHandler(this.timerCheckNewStream_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(520, 515);
            this.Controls.Add(this.panelStreams);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelTwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainView";
            this.Text = "Twitch Alert";
            this.Resize += new System.EventHandler(this.MainView_Resize);
            this.panelTwitch.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTwitch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelStreams;
        private System.Windows.Forms.Button btnChannel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnStreamsOnline;
        private NotificationWindow.PopupNotifier popNotifStreams;
        private System.Windows.Forms.Timer timerCheckNewStream;
        private System.Windows.Forms.Button btnStreamsPopular;
        private System.Windows.Forms.NotifyIcon notifyIcon1;

    }
}

