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

        public ControlChannelUser() : this("")
        {
            // no code ...
        }

        public ControlChannelUser(string urlWithToken)
        {
            this.Js = new JsonSerializer();
            this.CmdCurl = new Curl();
            this.AccessToken = this.FetchAccessToken(urlWithToken);
        }

        public bool GetAccessToken()
        {
            return false;
        }

        public bool AddChannelFollowed(string p_channelName)
        {
            return false;
        }

        public string FetchAccessToken(string urlWithToken)
        {
            bool inToken = false;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < urlWithToken.Length; i++)
            {
                if(urlWithToken[i] == '=')
                {
                    inToken = true;
                }

                if(inToken)
                {
                    if (urlWithToken[i] != '&')
                        result.Append(urlWithToken[i]);
                    else
                        break;
                }
            }
            return result.ToString();
        }
    }
}
