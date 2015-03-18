/*
 * Author : JP. Froelicher
 * Description : Model of stream
 * Date : 18 / 03 / 2015
 */ 
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

        /// <summary>
        /// Constructor
        /// </summary>
        public StreamModel()
        {
            this.CmdCurl = new Curl();
            this.Js = new JsonSerializer();
        }

        /// <summary>
        /// Get the popular stream
        /// </summary>
        /// <returns></returns>
        public Streams GetStreamsPopoular()
        {
            Streams streams = this.Js.Serialize<Streams>(URL_API + "streams/");
            return streams;
        }

        /// <summary>
        /// Get the search streams
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SearchStreams GetStreamsSearch(string request)
        {
            SearchStreams streamsSearch = this.Js.Serialize<SearchStreams>(URL_API + "search/streams?q=" + request);
            return streamsSearch;
        }

        /// <summary>
        /// Get the game search
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SearchGames GetGamesSearch(string request)
        {
            SearchGames gamesSearch = this.Js.Serialize<SearchGames>(URL_API + "search/games?q=" + request + "&type=suggest");
            return gamesSearch;
        }

        /// <summary>
        /// Get all infos streams
        /// </summary>
        /// <param name="channel_name">channel name</param>
        /// <returns>Streams</returns>
        public Streams GetAllInfosStream(string channel_name)
        {
            Streams currentStream = this.Js.Serialize<Streams>(URL_API + "streams/" + channel_name);
            return currentStream;
        }
    }
}
