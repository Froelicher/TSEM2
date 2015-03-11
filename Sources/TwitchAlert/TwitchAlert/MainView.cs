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
            this._user.AccessToken = "mg4dak98dvpogi0ogcu0e7l8btgj1i";
            this._user.FillStreamsFollowed();
            this.NotifModel = new NotificationModel(_user);
            this.NotifController = new NotificationController(this, this.NotifModel);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();

            //TEST DU CURL : OK
            /*_cmdCurl = new Curl();
            Users strim = _cmdCurl.SendRequest<Users>("https://api.twitch.tv/kraken/user", "GET", "4v9qec0rqdq4g5p1wmj6xyuin3ig30");
            MessageBox.Show(strim.display_name);    */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Configuration d'un Notification windows
            popupNotifier1.TitleText = "NOM DU STREAM";
            popupNotifier1.ContentText = "NOM DU JEUX \nNOM DE LA CHAINE \nNB VIEWERS";
            popupNotifier1.ContentPadding = new Padding(1);
            popupNotifier1.TitlePadding = new Padding(1);
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("http://static-cdn.jtvnw.net/previews-ttv/live_user_ogaminglol-320x180.jpg");
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

            //Redimmensionnement pour une image de base de 320x180
            System.Drawing.Size sizeimg = new System.Drawing.Size(150, 82);

            popupNotifier1.Image = img;
            popupNotifier1.ImagePadding = new Padding(5);
            popupNotifier1.ImageSize = sizeimg;

            popupNotifier1.Popup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timerCheckNewStream_Tick(object sender, EventArgs e)
        {
            this.FillNotif(this.NotifController.CheckNewStreamOnline());
        }

        private void FillNotif(List<string> listInfo)
        {
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
    }
}
