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

namespace TwitchAlert
{
    public partial class MainView : Form
    {
        private Curl _cmdCurl;
        private UserModel _user;
        private NotificationModel _notif;
        private NotificationModel _notifModel;
        private NotificationController _notifController;
        private ChannelController _chanController;

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
            this._user = new UserModel();
            this._user.AccessToken = "xt3q3jcx2xyn0yo9i73s4ooa17ua60";
            this._user.FillStreamsFollowed();
            this._user.FillChannelsFollowed();
            this.ChanController = new ChannelController(this, _user);
            this.NotifModel = new NotificationModel(_user);
            this.NotifController = new NotificationController(this, this.NotifModel);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DisplayStreamsOnline(this.ChanController.GetInfosDisplayStreamsOnline());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DisplayChannelsFollowed(this.ChanController.GetInfosDisplayChannels());
        }

        private void timerCheckNewStream_Tick(object sender, EventArgs e)
        {
            this.FillNotif();
        }

        private void FillNotif()
        {
            List<string> listInfo = this.NotifController.CheckNewStreamOnline();

            if (listInfo != null)
            {
                popupNotifier1.TitleText = listInfo[0];
                popupNotifier1.ContentText = listInfo[1] + " \n" + listInfo[2] + " \n" + listInfo[3];
                popupNotifier1.ContentPadding = new Padding(1);
                popupNotifier1.TitlePadding = new Padding(1);
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(listInfo[4]);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                //Redimmensionnement pour une image de base de 320x180
                System.Drawing.Size sizeimg = new System.Drawing.Size(150, 82);

                popupNotifier1.Image = img;
                popupNotifier1.ImagePadding = new Padding(5);
                popupNotifier1.ImageSize = sizeimg;
                popupNotifier1.Popup();
            }
        }

        private void DisplayStreamsOnline(string[,] listStream)
        {
            this.panelStreams.Controls.Clear();
            int space = 10;
            int spaceHeightPanel = 0;
            for (int i = 0; i < this.ChanController.GetNbStreamOnline(); i++)
            {
                //CREATE PANEL
                Panel gPanel = new Panel();
                gPanel.Size = new Size(460, 145);
                if(i == 0)
                {
                    gPanel.Location = new Point(10, 10);
                }
                else
                {
                    spaceHeightPanel = space * (i + 1) + (145*(i));
                    gPanel.Location = new Point(10, spaceHeightPanel);
                }
                gPanel.BackColor = Color.White;


                //CREATE PICTUREBOX
                PictureBox preview = new PictureBox();
                preview.Location = new Point(15, 35);
                preview.Size = new Size(150, 82);
                preview.SizeMode = PictureBoxSizeMode.StretchImage;
                preview.Load(listStream[i,0]);


                //CREATE LABEL_TITLE
                Label title = new Label();
                title.Location = new Point(15, 10);
                title.Text = listStream[i, 1];
                title.Size = new Size(400, 20);

                //CREATE LABEL_CHANNEL_NAME
                Label channel = new Label();
                channel.Location = new Point(180, 35);
                channel.Text = listStream[i, 2];
                channel.Size = new Size(200, 20);

                //CREATE LABEL_GAME
                Label game = new Label();
                game.Location = new Point(180, 70);
                game.Text = listStream[i, 3];
                game.Size = new Size(200, 20);

                //CREATE LABEL_VIEWERS
                Label viewers = new Label();
                viewers.Location = new Point(180, 105);
                viewers.Text = listStream[i, 4];
                viewers.Size = new Size(200, 20);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
