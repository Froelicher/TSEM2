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
            string test = strJson.DownloadString("https://api.twitch.tv/kraken/search/games?q=star&type=suggest");
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SearchGames));
            
            MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes(test));

            SearchGames fireBall = (SearchGames)js.ReadObject(ms);
            //label1.Text = "Title : " + fireBall.game;
            ms.Close();

        }
    }
}
