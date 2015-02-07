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
        public MainView()
        {
            InitializeComponent();

            WebClient strJson = new WebClient();
            string test = strJson.DownloadString("https://api.twitch.tv/kraken/streams/ogaminglol");
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Streams));
            
            MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes(test));

            Streams fireBall = (Streams)js.ReadObject(ms);
            //label1.Text = "Title : " + fireBall.game;
            ms.Close();

        }
    }
}
