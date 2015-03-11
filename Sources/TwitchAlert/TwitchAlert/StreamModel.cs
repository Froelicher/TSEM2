using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class StreamModel
    {
        private const string URL_API = "https://api.twitch.tv/kraken/";

        private Curl _cmdCurl;
        private JsonSerializer _js;

        internal JsonSerializer Js
        {
            get { return _js; }
            set { _js = value; }
        }

        internal Curl CmdCurl
        {
            get { return _cmdCurl; }
            set { _cmdCurl = value; }
        }

        public StreamModel()
        {
            this.CmdCurl = new Curl();
            this.Js = new JsonSerializer();
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
