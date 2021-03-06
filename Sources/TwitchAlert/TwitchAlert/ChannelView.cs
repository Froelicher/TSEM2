﻿/*
 * Author : JP. Froelicher
 * Description : View of details channel
 * Date : 18 / 03 / 2015
 */ 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TwitchAlert
{
    public partial class ChannelView : Form
    {
        private ChannelController _chanController;

        internal ChannelController ChanController
        {
            get { return _chanController; }
            set { _chanController = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="channel_name">channel name</param>
        public ChannelView(string channel_name)
        {
            InitializeComponent();
            StreamModel strmModel = new StreamModel();
            this.ChanController = new ChannelController(this, strmModel);
            string[] infos = this.ChanController.GetAllInfosChannel(channel_name);
            this.CompleteView(infos);
            this.lbl_playing.Location = new Point(this.lbl_channel_name.Location.X + 5 + lbl_channel_name.Width, this.lbl_playing.Location.Y);
            this.lbl_game.Location = new Point(this.lbl_playing.Location.X + 5 + lbl_playing.Width, this.lbl_game.Location.Y);
        }

        /// <summary>
        /// Complete the view with infos
        /// </summary>
        /// <param name="infos">infos</param>
        private void CompleteView(string[] infos)
        {
            Uri uri = null;
            if(infos[11] != null)
                uri = new Uri(infos[11] + "/popout", System.UriKind.Absolute);

            if(uri != null)
                this.webChannel.Url = uri;

            if(infos[3] != null)
                this.pbxLogo.Load(infos[3]);

            this.lbl_status.Text = infos[0];
            this.lbl_game.Text = infos[2];
            this.lbl_channel_name.Text = infos[1];

            this.lbl_info_game.Text = infos[2];
            this.lbl_info_status.Text = infos[0];
            this.lbl_info_viewers.Text = infos[4];
            this.lbl_info_stream_created_at.Text = infos[5];

            this.lbl_info_channel_name.Text = infos[6];
            this.lbl_info_display_name.Text = infos[1];
            this.lbl_info_followers.Text = infos[7];
            this.lbl_info_views.Text = infos[8];
            this.lbl_info_channel_created_at.Text = infos[9];
            this.lbl_info_updated_at.Text = infos[10];

            this.link_lbl_info_channel_url.Text = infos[11];
            this.lbl_info_partner.Text = infos[12];
            this.lbl_info_mature.Text = infos[13];
            this.lbl_info_delay.Text = infos[14];
            this.lbl_info_id.Text = infos[15];
            this.lbl_info_broad_language.Text = infos[16];
            this.lbl_info_language.Text = infos[17];
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
