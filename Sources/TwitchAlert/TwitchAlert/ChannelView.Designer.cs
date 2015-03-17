namespace TwitchAlert
{
    partial class ChannelView
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
            this.webChannel = new System.Windows.Forms.WebBrowser();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_channel_name = new System.Windows.Forms.Label();
            this.lbl_playing = new System.Windows.Forms.Label();
            this.lbl_game = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_info_game = new System.Windows.Forms.Label();
            this.lbl_info_status = new System.Windows.Forms.Label();
            this.lbl_info_viewers = new System.Windows.Forms.Label();
            this.lbl_info_stream_created_at = new System.Windows.Forms.Label();
            this.lbl_info_channel_name = new System.Windows.Forms.Label();
            this.lbl_info_display_name = new System.Windows.Forms.Label();
            this.lbl_info_followers = new System.Windows.Forms.Label();
            this.lbl_info_views = new System.Windows.Forms.Label();
            this.lbl_info_channel_created_at = new System.Windows.Forms.Label();
            this.lbl_info_updated_at = new System.Windows.Forms.Label();
            this.link_lbl_info_channel_url = new System.Windows.Forms.LinkLabel();
            this.lbl_info_partner = new System.Windows.Forms.Label();
            this.lbl_info_mature = new System.Windows.Forms.Label();
            this.lbl_info_delay = new System.Windows.Forms.Label();
            this.lbl_info_id = new System.Windows.Forms.Label();
            this.lbl_info_broad_language = new System.Windows.Forms.Label();
            this.lbl_info_language = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // webChannel
            // 
            this.webChannel.Location = new System.Drawing.Point(12, 97);
            this.webChannel.MinimumSize = new System.Drawing.Size(20, 20);
            this.webChannel.Name = "webChannel";
            this.webChannel.ScrollBarsEnabled = false;
            this.webChannel.Size = new System.Drawing.Size(888, 593);
            this.webChannel.TabIndex = 0;
            this.webChannel.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Location = new System.Drawing.Point(12, 1);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(90, 90);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(108, 4);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(791, 71);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "NOM DU STREAM EN COURS";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_channel_name
            // 
            this.lbl_channel_name.AutoSize = true;
            this.lbl_channel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_channel_name.Location = new System.Drawing.Point(112, 75);
            this.lbl_channel_name.Name = "lbl_channel_name";
            this.lbl_channel_name.Size = new System.Drawing.Size(129, 16);
            this.lbl_channel_name.TabIndex = 3;
            this.lbl_channel_name.Text = "Nom de la chaîne";
            // 
            // lbl_playing
            // 
            this.lbl_playing.AutoSize = true;
            this.lbl_playing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playing.Location = new System.Drawing.Point(247, 75);
            this.lbl_playing.Name = "lbl_playing";
            this.lbl_playing.Size = new System.Drawing.Size(52, 16);
            this.lbl_playing.TabIndex = 4;
            this.lbl_playing.Text = "playing";
            // 
            // lbl_game
            // 
            this.lbl_game.AutoSize = true;
            this.lbl_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game.Location = new System.Drawing.Point(305, 75);
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(86, 16);
            this.lbl_game.TabIndex = 5;
            this.lbl_game.Text = "Nom du jeu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Game :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 768);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Viewers :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 800);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Created at :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 706);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Channel name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 722);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Display name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 738);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Followers :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 754);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Views";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 770);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Created at :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 786);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Updated at :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(709, 711);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Partner :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(709, 727);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Mature :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(710, 743);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Delay :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(710, 759);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "id :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(356, 802);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "URL :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(709, 775);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Broadcaster language : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(710, 791);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Language :";
            // 
            // lbl_info_game
            // 
            this.lbl_info_game.AutoSize = true;
            this.lbl_info_game.Location = new System.Drawing.Point(98, 707);
            this.lbl_info_game.Name = "lbl_info_game";
            this.lbl_info_game.Size = new System.Drawing.Size(62, 13);
            this.lbl_info_game.TabIndex = 24;
            this.lbl_info_game.Text = "game name";
            // 
            // lbl_info_status
            // 
            this.lbl_info_status.Location = new System.Drawing.Point(98, 723);
            this.lbl_info_status.Name = "lbl_info_status";
            this.lbl_info_status.Size = new System.Drawing.Size(252, 44);
            this.lbl_info_status.TabIndex = 25;
            this.lbl_info_status.Text = "Status";
            this.lbl_info_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_info_viewers
            // 
            this.lbl_info_viewers.AutoSize = true;
            this.lbl_info_viewers.Location = new System.Drawing.Point(98, 770);
            this.lbl_info_viewers.Name = "lbl_info_viewers";
            this.lbl_info_viewers.Size = new System.Drawing.Size(58, 13);
            this.lbl_info_viewers.TabIndex = 26;
            this.lbl_info_viewers.Text = "nb viewers";
            // 
            // lbl_info_stream_created_at
            // 
            this.lbl_info_stream_created_at.AutoSize = true;
            this.lbl_info_stream_created_at.Location = new System.Drawing.Point(98, 800);
            this.lbl_info_stream_created_at.Name = "lbl_info_stream_created_at";
            this.lbl_info_stream_created_at.Size = new System.Drawing.Size(55, 13);
            this.lbl_info_stream_created_at.TabIndex = 27;
            this.lbl_info_stream_created_at.Text = "created at";
            // 
            // lbl_info_channel_name
            // 
            this.lbl_info_channel_name.AutoSize = true;
            this.lbl_info_channel_name.Location = new System.Drawing.Point(443, 706);
            this.lbl_info_channel_name.Name = "lbl_info_channel_name";
            this.lbl_info_channel_name.Size = new System.Drawing.Size(74, 13);
            this.lbl_info_channel_name.TabIndex = 28;
            this.lbl_info_channel_name.Text = "channel name";
            // 
            // lbl_info_display_name
            // 
            this.lbl_info_display_name.AutoSize = true;
            this.lbl_info_display_name.Location = new System.Drawing.Point(443, 722);
            this.lbl_info_display_name.Name = "lbl_info_display_name";
            this.lbl_info_display_name.Size = new System.Drawing.Size(68, 13);
            this.lbl_info_display_name.TabIndex = 29;
            this.lbl_info_display_name.Text = "display name";
            // 
            // lbl_info_followers
            // 
            this.lbl_info_followers.AutoSize = true;
            this.lbl_info_followers.Location = new System.Drawing.Point(443, 738);
            this.lbl_info_followers.Name = "lbl_info_followers";
            this.lbl_info_followers.Size = new System.Drawing.Size(63, 13);
            this.lbl_info_followers.TabIndex = 30;
            this.lbl_info_followers.Text = "nb followers";
            // 
            // lbl_info_views
            // 
            this.lbl_info_views.AutoSize = true;
            this.lbl_info_views.Location = new System.Drawing.Point(443, 754);
            this.lbl_info_views.Name = "lbl_info_views";
            this.lbl_info_views.Size = new System.Drawing.Size(49, 13);
            this.lbl_info_views.TabIndex = 31;
            this.lbl_info_views.Text = "nb views";
            // 
            // lbl_info_channel_created_at
            // 
            this.lbl_info_channel_created_at.AutoSize = true;
            this.lbl_info_channel_created_at.Location = new System.Drawing.Point(443, 770);
            this.lbl_info_channel_created_at.Name = "lbl_info_channel_created_at";
            this.lbl_info_channel_created_at.Size = new System.Drawing.Size(55, 13);
            this.lbl_info_channel_created_at.TabIndex = 32;
            this.lbl_info_channel_created_at.Text = "created at";
            // 
            // lbl_info_updated_at
            // 
            this.lbl_info_updated_at.AutoSize = true;
            this.lbl_info_updated_at.Location = new System.Drawing.Point(443, 786);
            this.lbl_info_updated_at.Name = "lbl_info_updated_at";
            this.lbl_info_updated_at.Size = new System.Drawing.Size(58, 13);
            this.lbl_info_updated_at.TabIndex = 33;
            this.lbl_info_updated_at.Text = "updated at";
            // 
            // link_lbl_info_channel_url
            // 
            this.link_lbl_info_channel_url.AutoSize = true;
            this.link_lbl_info_channel_url.Location = new System.Drawing.Point(443, 802);
            this.link_lbl_info_channel_url.Name = "link_lbl_info_channel_url";
            this.link_lbl_info_channel_url.Size = new System.Drawing.Size(18, 13);
            this.link_lbl_info_channel_url.TabIndex = 34;
            this.link_lbl_info_channel_url.TabStop = true;
            this.link_lbl_info_channel_url.Text = "url";
            // 
            // lbl_info_partner
            // 
            this.lbl_info_partner.AutoSize = true;
            this.lbl_info_partner.Location = new System.Drawing.Point(828, 711);
            this.lbl_info_partner.Name = "lbl_info_partner";
            this.lbl_info_partner.Size = new System.Drawing.Size(40, 13);
            this.lbl_info_partner.TabIndex = 35;
            this.lbl_info_partner.Text = "partner";
            // 
            // lbl_info_mature
            // 
            this.lbl_info_mature.AutoSize = true;
            this.lbl_info_mature.Location = new System.Drawing.Point(828, 727);
            this.lbl_info_mature.Name = "lbl_info_mature";
            this.lbl_info_mature.Size = new System.Drawing.Size(39, 13);
            this.lbl_info_mature.TabIndex = 36;
            this.lbl_info_mature.Text = "mature";
            // 
            // lbl_info_delay
            // 
            this.lbl_info_delay.AutoSize = true;
            this.lbl_info_delay.Location = new System.Drawing.Point(828, 743);
            this.lbl_info_delay.Name = "lbl_info_delay";
            this.lbl_info_delay.Size = new System.Drawing.Size(32, 13);
            this.lbl_info_delay.TabIndex = 37;
            this.lbl_info_delay.Text = "delay";
            // 
            // lbl_info_id
            // 
            this.lbl_info_id.AutoSize = true;
            this.lbl_info_id.Location = new System.Drawing.Point(828, 759);
            this.lbl_info_id.Name = "lbl_info_id";
            this.lbl_info_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_info_id.TabIndex = 38;
            this.lbl_info_id.Text = "id";
            // 
            // lbl_info_broad_language
            // 
            this.lbl_info_broad_language.AutoSize = true;
            this.lbl_info_broad_language.Location = new System.Drawing.Point(828, 775);
            this.lbl_info_broad_language.Name = "lbl_info_broad_language";
            this.lbl_info_broad_language.Size = new System.Drawing.Size(57, 13);
            this.lbl_info_broad_language.TabIndex = 39;
            this.lbl_info_broad_language.Text = "broad lang";
            // 
            // lbl_info_language
            // 
            this.lbl_info_language.AutoSize = true;
            this.lbl_info_language.Location = new System.Drawing.Point(828, 791);
            this.lbl_info_language.Name = "lbl_info_language";
            this.lbl_info_language.Size = new System.Drawing.Size(51, 13);
            this.lbl_info_language.TabIndex = 40;
            this.lbl_info_language.Text = "language";
            // 
            // ChannelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 831);
            this.Controls.Add(this.lbl_info_language);
            this.Controls.Add(this.lbl_info_broad_language);
            this.Controls.Add(this.lbl_info_id);
            this.Controls.Add(this.lbl_info_delay);
            this.Controls.Add(this.lbl_info_mature);
            this.Controls.Add(this.lbl_info_partner);
            this.Controls.Add(this.link_lbl_info_channel_url);
            this.Controls.Add(this.lbl_info_updated_at);
            this.Controls.Add(this.lbl_info_channel_created_at);
            this.Controls.Add(this.lbl_info_views);
            this.Controls.Add(this.lbl_info_followers);
            this.Controls.Add(this.lbl_info_display_name);
            this.Controls.Add(this.lbl_info_channel_name);
            this.Controls.Add(this.lbl_info_stream_created_at);
            this.Controls.Add(this.lbl_info_viewers);
            this.Controls.Add(this.lbl_info_status);
            this.Controls.Add(this.lbl_info_game);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_game);
            this.Controls.Add(this.lbl_playing);
            this.Controls.Add(this.lbl_channel_name);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.webChannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChannelView";
            this.Text = "1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webChannel;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_channel_name;
        private System.Windows.Forms.Label lbl_playing;
        private System.Windows.Forms.Label lbl_game;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_info_game;
        private System.Windows.Forms.Label lbl_info_status;
        private System.Windows.Forms.Label lbl_info_viewers;
        private System.Windows.Forms.Label lbl_info_stream_created_at;
        private System.Windows.Forms.Label lbl_info_channel_name;
        private System.Windows.Forms.Label lbl_info_display_name;
        private System.Windows.Forms.Label lbl_info_followers;
        private System.Windows.Forms.Label lbl_info_views;
        private System.Windows.Forms.Label lbl_info_channel_created_at;
        private System.Windows.Forms.Label lbl_info_updated_at;
        private System.Windows.Forms.LinkLabel link_lbl_info_channel_url;
        private System.Windows.Forms.Label lbl_info_partner;
        private System.Windows.Forms.Label lbl_info_mature;
        private System.Windows.Forms.Label lbl_info_delay;
        private System.Windows.Forms.Label lbl_info_id;
        private System.Windows.Forms.Label lbl_info_broad_language;
        private System.Windows.Forms.Label lbl_info_language;
    }
}