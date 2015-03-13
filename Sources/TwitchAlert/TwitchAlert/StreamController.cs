using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class StreamController
    {

        private const int NB_INFOS_STREAM = 5;

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

        public StreamController(MainView view, StreamModel model)
        {
            this.Model = model;
            this.View = view;
        }

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
            }
            return arrayInfosStreams;
        }

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
            }
            return arrayInfosStreams;
        }

        public int GetNbStreamsSearch(string request)
        {
            return this.Model.GetStreamsSearch(request).streams.Length;
        }

        public int GetNbStreamsPopular()
        {
            return this.Model.GetStreamsPopoular().streams.Length;
        }
    }
}
