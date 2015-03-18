/*
 * Author : JP. Froelicher
 * Description : Controller of stream
 * Date : 18 / 03 / 2015
 */ 
using System.Linq;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class StreamController
    {

        private const int NB_INFOS_STREAM = 6;

        private MainView _view;
        private StreamModel _model;

        internal StreamModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public MainView View
        {
            get { return _view; }
            set { _view = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">Main view</param>
        /// <param name="model">Stream model</param>
        public StreamController(MainView view, StreamModel model)
        {
            this.Model = model;
            this.View = view;
        }

        /// <summary>
        /// Get infos to display list popular streams
        /// </summary>
        /// <returns>infos</returns>
        public string[,] GetInfosDisplayStreams()
        {
            Stream[] arrayStreams = this.Model.GetStreamsPopoular().streams;
            string[,] arrayInfosStreams = new string[arrayStreams.Count(), NB_INFOS_STREAM];

            for (int i = 0; i < arrayStreams.Count(); i++)
            {
                arrayInfosStreams[i, 0] = arrayStreams[i].preview.medium;
                arrayInfosStreams[i, 1] = arrayStreams[i].channel.status;
                arrayInfosStreams[i, 2] = arrayStreams[i].channel.display_name;
                arrayInfosStreams[i, 3] = arrayStreams[i].game;
                arrayInfosStreams[i, 4] = arrayStreams[i].viewers.ToString();
                arrayInfosStreams[i, 5] = arrayStreams[i].channel.name;
            }
            return arrayInfosStreams;
        }
        
        /// <summary>
        /// Get infos to display list of search stream
        /// </summary>
        /// <param name="request">search request</param>
        /// <returns>infos</returns>
        public string[,] GetInfosDisplayStreamsSearch(string request)
        {
            Stream[] arrayStreams = this.Model.GetStreamsSearch(request).streams;
            string[,] arrayInfosStreams = new string[arrayStreams.Count(), NB_INFOS_STREAM];

            for (int i = 0; i < arrayStreams.Count(); i++)
            {
                arrayInfosStreams[i, 0] = arrayStreams[i].preview.medium;
                arrayInfosStreams[i, 1] = arrayStreams[i].channel.status;
                arrayInfosStreams[i, 2] = arrayStreams[i].channel.display_name;
                arrayInfosStreams[i, 3] = arrayStreams[i].game;
                arrayInfosStreams[i, 4] = arrayStreams[i].viewers.ToString();
                arrayInfosStreams[i, 5] = arrayStreams[i].channel.name;
            }
            return arrayInfosStreams;
        }

        /// <summary>
        /// Get nb stream search
        /// </summary>
        /// <param name="request">search request</param>
        /// <returns>count</returns>
        public int GetNbStreamsSearch(string request)
        {
            return this.Model.GetStreamsSearch(request).streams.Length;
        }

        /// <summary>
        /// Get nb popular streams
        /// </summary>
        /// <returns>count</returns>
        public int GetNbStreamsPopular()
        {
            return this.Model.GetStreamsPopoular().streams.Length;
        }
    }
}
