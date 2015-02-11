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
        private const string URL_API = "https://api.twitch.tv/kraken/";

        private JsonSerializer _js;
        private string _profilTwitch;
        private List<Streams> _listStreams;

        internal List<Streams> ListStreams
        {
            get { return _listStreams; }
            set { _listStreams = value; }
        }

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

        public Streams[] GetStreamsFollowed()
        {
            if (this.ProfilTwitch != "")
            {
                Follows ChannelFollowed = this.Js.Serialize<Follows>(URL_API + "users/" + this.ProfilTwitch + "/follows/channels");
                Streams[] StreamsArray = new Streams[ChannelFollowed.follows.Length];
                for (int i = 0; i < ChannelFollowed.follows.Length - 1; i++)
                {
                    StreamsArray[i] = this.Js.Serialize<Streams>(URL_API + "streams/" + ChannelFollowed.follows[i].channel.name);
                }

                return StreamsArray;
            }

            return null;
        }

        public Streams GetStreamsPopoular()
        {
            Streams streams = this.Js.Serialize<Streams>(URL_API + "streams/");
            return streams;
        }

        public SearchStreams GetStreamsSearch(string request)
        {
            SearchStreams streamsSearch = this.Js.Serialize<SearchStreams>(URL_API + "search/streams?q=" + request);
            return streamsSearch;
        }

        public SearchGames GetGamesSearch(string request)
        {
            SearchGames gamesSearch = this.Js.Serialize<SearchGames>(URL_API + "search/games?q=" + request + "&type=suggest");
            return gamesSearch;
        }
    }
}
