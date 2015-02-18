using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class ControlChannelUser
    {
        private string _accessToken;
        private JsonSerializer _js;
        private Curl _cmdCurl;

        internal Curl CmdCurl
        {
            get { return _cmdCurl; }
            set { _cmdCurl = value; }
        }

        internal JsonSerializer Js
        {
            get { return _js; }
            set { _js = value; }
        }

        public string AccessToken
        {
            get { return _accessToken; }
            set { _accessToken = value; }
        }

        public ControlChannelUser()
        {
            this.Js = new JsonSerializer();
            this.CmdCurl = new Curl();
        }

        public bool GetAccessToken()
        {
            return false;
        }

        public bool AddChannelFollowed(string p_channelName)
        {
            return false;
        }
    }
}
