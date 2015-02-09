using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class ControlStreams
    {
        private const string URL_API = "http://api.twitch.tv/kraken/";

        private JsonSerializer _js;
        private string _profilTwitch;

        public string ProfilTwitch
        {
            get { return _profilTwitch; }
            set { _profilTwitch = value; }
        }

        internal JsonSerializer Js
        {
            get { return _js; }
            set { _js = value; }
        }

        public ControlStreams()
        {
            this.Js = new JsonSerializer();
        }

        public Streams GetStreamsFollowed(string channel_name)
        {
            //FAUX CODE
            return this.Js.Serialize<Streams>(URL_API + "streams/"+channel_name);
        }
    }
}
