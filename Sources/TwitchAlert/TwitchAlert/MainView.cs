using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using TwitchAlert.TwitchModels;
using System.Timers;

namespace TwitchAlert
{
    public partial class MainView : Form
    {
        private UserModel _user;
        private UserController _usrController;
        private NotificationModel _notifModel;
        private StreamModel _strmModel;
        private NotificationController _notifController;
        private ChannelController _chanController;
        private StreamController _strmController;

        internal UserModel User
        {
            get { return _user; }
            set { _user = value; }
        }

        internal UserController UsrController
        {
            get { return _usrController; }
            set { _usrController = value; }
        }

        internal StreamController StrmController
        {
            get { return _strmController; }
            set { _strmController = value; }
        }

        internal StreamModel StrmModel
        {
            get { return _strmModel; }
            set { _strmModel = value; }
        }

        internal ChannelController ChanController
        {
            get { return _chanController; }
            set { _chanController = value; }
        }

        internal NotificationController NotifController
        {
            get { return _notifController; }
            set { _notifController = value; }
        }

        internal NotificationModel NotifModel
        {
            get { return _notifModel; }
            set { _notifModel = value; }
        }


        public MainView()
        {
            InitializeComponent();
            this.User = new UserModel();
            this.UsrController = new UserController(this.User, this);
            this.ChanController = new ChannelController(this, this.User);        
            this.StrmModel = new StreamModel();
            this.StrmController = new StreamController(this, this.StrmModel);
            this.NotifModel = new NotificationModel(this.User);
            this.NotifController = new NotificationController(this, this.NotifModel);
            this.cmbSearch.SelectedIndex = 0;
            //this.InitTimer();
        }

        private void InitTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(CheckNewStreamOnlineTick);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
        }

        private void CheckNewStreamOnlineTick(object source, ElapsedEventArgs e)
        {
            if (this.UsrController.IsConnected())
                this.FillNotif();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.UsrController.IsConnected())
            {
                MessageBox.Show("Vous êtes déjà connecté");        
            }else{
                LoginView loginView = new LoginView(this, this.User);
                loginView.Show();
            }
        }

        private void btnStreamsOnline_Click(object sender, EventArgs e)
        {
            if(this.UsrController.IsConnected())
                this.DisplayStreamsOnline(this.ChanController.GetInfosDisplayStreamsOnline());
            else
                MessageBox.Show("Vous devez être connecté");
        }

        private void btnChannel_Click(object sender, EventArgs e)
        {
            if (this.UsrController.IsConnected())
                this.DisplayChannelsFollowed(this.ChanController.GetInfosDisplayChannels());
            else
                MessageBox.Show("Vous devez être connecté");
        }

        private void timerCheckNewStream_Tick(object sender, EventArgs e)
        {
            if (this.UsrController.IsConnected())
                this.FillNotif();
        }

        private void FillNotif()
        {
            List<string> listInfo = this.NotifController.CheckNewStreamOnline();

            if (listInfo != null)
            {
                popNotifStreams.TitleText = listInfo[0];
                popNotifStreams.ContentText = listInfo[1] + " \n" + listInfo[2] + " \n" + listInfo[3];
                popNotifStreams.ContentPadding = new Padding(1);
                popNotifStreams.TitlePadding = new Padding(1);
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(listInfo[4]);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                //Redimmensionnement pour une image de base de 320x180
                System.Drawing.Size sizeimg = new System.Drawing.Size(150, 82);

                popNotifStreams.Image = img;
                popNotifStreams.ImagePadding = new Padding(5);
                popNotifStreams.ImageSize = sizeimg;
                popNotifStreams.Click += (s, e) =>
                {
                    ChannelView channelView = new ChannelView(listInfo[2]);
                    channelView.Show();
                }; 
                popNotifStreams.Popup();
            }
        }

        private void DisplayStreamsOnline(string[,] listStream)
        {
            this.CreatePanelStreams(this.ChanController.GetNbStreamOnline(), listStream);    
        }

        private void DisplayStreamsPopular(string[,] listStream)
        {
            this.CreatePanelStreams(this.StrmController.GetNbStreamsPopular(), listStream);
        }

        private void DisplayStreamsSearch(string[,] listStream, string request)
        {
            this.CreatePanelStreams(this.StrmController.GetNbStreamsSearch(request), listStream);
        }

        private void CreatePanelStreams(int nbPanel, string[,] listStreams)
        {
            this.panelStreams.Controls.Clear();
            int space = 10;
            int spaceHeightPanel = 0;

            for (int i = 0; i < nbPanel; i++)
            {
                int test = i;
                //CREATE PANEL
                Panel gPanel = new Panel();
                gPanel.Size = new Size(460, 145);
                if (i == 0)
                {
                    gPanel.Location = new Point(10, 10);
                }
                else
                {
                    spaceHeightPanel = space * (i + 1) + (145 * (i));
                    gPanel.Location = new Point(10, spaceHeightPanel);
                }
                gPanel.BackColor = Color.White;

                //CREATE PICTUREBOX
                PictureBox preview = new PictureBox();
                preview.Location = new Point(15, 35);
                preview.Size = new Size(150, 82);
                preview.SizeMode = PictureBoxSizeMode.StretchImage;
                preview.Load(listStreams[i, 0]);

                //CREATE LABEL_TITLE
                Label title = new Label();
                title.Location = new Point(15, 10);
                title.Font = new Font("Microsoft Sans Serif", 9f);
                title.Text = listStreams[i, 1];
                title.Size = new Size(400, 20);
               

                //CREATE LABEL_CHANNEL_NAME
                Label channel = new Label();
                channel.Location = new Point(180, 35);
                channel.Text = listStreams[i, 2];
                channel.Size = new Size(200, 20);

                //CREATE LABEL_GAME
                Label game = new Label();
                game.Location = new Point(180, 70);
                game.Text = listStreams[i, 3];
                game.Size = new Size(200, 20);

                //CREATE LABEL_VIEWERS
                Label viewers = new Label();
                viewers.Location = new Point(180, 105);
                viewers.Text = listStreams[i, 4];
                viewers.Size = new Size(200, 20);

                //CREATE BTN_FOLLOW
                Button follow = new Button();
                follow.Location = new Point(380, 35);
                follow.Size = new Size(60, 30);
                follow.BackColor = Color.FromArgb(100, 65, 165);
                follow.ForeColor = Color.White;
                follow.FlatStyle = FlatStyle.Flat;
                follow.FlatAppearance.BorderSize = 0;

                if (!this.UsrController.CheckIsFollowed(listStreams[i, 2]))
                {
                    follow.Text = "Follow";
                    follow.Click += (s, e) =>
                    {
                        this.ChanController.FollowChannel(listStreams[test, 2]);
                        follow.Text = "Unfollow";
                        this.Invalidate();
                    }; 
                }
                else
                {
                    follow.Text = "Unfollow";
                    follow.Click += (s, e) =>
                    {
                        this.ChanController.UnFollowChannel(listStreams[test, 2]);
                        follow.Text = "Follow";
                        this.Invalidate();
                    }; 
                }



                gPanel.Controls.Add(follow);
                //CREATE BTN_CHANNEL_VIEW
                Button play = new Button();
                play.Location = new Point(380, 90);
                play.Size = new Size(60, 30);
                play.Text = "Play";
                play.BackColor = Color.FromArgb(100, 65, 165);
                play.ForeColor = Color.White;
                play.FlatAppearance.BorderSize = 0;
                play.FlatStyle = FlatStyle.Flat;
                play.Click += (s, e) => { ChannelView channelView = new ChannelView(listStreams[test, 2]);
                                          channelView.Show();
                                        };
                gPanel.Controls.Add(play);

                //ADD CONTROLS TO PANEL STREAMS
                gPanel.Controls.Add(viewers);
                gPanel.Controls.Add(game);
                gPanel.Controls.Add(channel);
                gPanel.Controls.Add(title);
                gPanel.Controls.Add(preview);
                panelStreams.Controls.Add(gPanel);
            }
        }

        private void DisplayChannelsFollowed(string[,] listChannels)
        {
            this.panelStreams.Controls.Clear();
            int space = 10;
            int spaceHeightPanel = 0;
            for (int i = 0; i < this.ChanController.GetNbChannelFollowed(); i++)
            {
                //CREATE PANEL
                Panel gPanel = new Panel();
                gPanel.Size = new Size(460, 145);
                if (i == 0)
                {
                    gPanel.Location = new Point(10, 10);
                }
                else
                {
                    spaceHeightPanel = space * (i + 1) + (145 * (i));
                    gPanel.Location = new Point(10, spaceHeightPanel);
                }
                gPanel.BackColor = Color.White;


                //CREATE PICTUREBOX
                PictureBox preview = new PictureBox();
                preview.Location = new Point(15, 35);
                preview.Size = new Size(150, 82);
                preview.SizeMode = PictureBoxSizeMode.StretchImage;
                preview.Load(listChannels[i, 0]);

                //CREATE LABEL_CHANNEL_NAME
                Label channel = new Label();
                channel.Location = new Point(180, 35);
                channel.Text = listChannels[i, 1];
                channel.Size = new Size(200, 20);

                //CREATE LABEL_FOLLOWERS
                Label followers = new Label();
                followers.Location = new Point(180, 70);
                followers.Text = listChannels[i, 2];
                followers.Size = new Size(200, 20);

                //CREATE LABEL_VIEWERS
                Label views = new Label();
                views.Location = new Point(180, 105);
                views.Text = listChannels[i, 3];
                views.Size = new Size(200, 20);

                //ADD CONTROLS TO PANEL STREAMS
                gPanel.Controls.Add(views);
                gPanel.Controls.Add(channel);
                gPanel.Controls.Add(followers);
                gPanel.Controls.Add(preview);
                panelStreams.Controls.Add(gPanel);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.UsrController.IsConnected())
            {
                if (cmbSearch.SelectedIndex == 0)
                {   
                    this.DisplayStreamsSearch(this.StrmController.GetInfosDisplayStreamsSearch(this.tbxSearch.Text), this.tbxSearch.Text);
                }

                if (cmbSearch.SelectedIndex == 1)
                {

                }
            }
            else
            {
                MessageBox.Show("Vous devez être connecté");
            }
            
        }

        private void btnStreamsPopular_Click(object sender, EventArgs e)
        {
            if(this.UsrController.IsConnected())
                this.DisplayStreamsPopular(this.StrmController.GetInfosDisplayStreams());
            else
                MessageBox.Show("Vous devez être connecté");
        }

        private void MainView_Resize(object sender, EventArgs e)
        {
            IconTwitchAlert.BalloonTipTitle = "Twitch Alert is reduced";
            IconTwitchAlert.BalloonTipText = "Double click to icon to open the main window";
            
            if(FormWindowState.Minimized == this.WindowState)
            {
                IconTwitchAlert.Visible = true;
                IconTwitchAlert.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                IconTwitchAlert.Visible = false;
            }
        }

        private void IconTwitchAlert_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

    }
}
