using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class ChannelController
    {
        private const int NB_INFOS_STREAM = 5;
        private const int NB_INFOS_CHANNEL = 4;

        private UserModel _usrModel;
        private MainView _view;

        public MainView View
        {
            get { return _view; }
            set { _view = value; }
        }

        internal UserModel UsrModel
        {
            get { return _usrModel; }
            set { _usrModel = value; }
        }

        public ChannelController(MainView view, UserModel usrModel)
        {
            this.View = view;
            this.UsrModel = usrModel;
        }

        public string[,] GetInfosDisplayStreamsOnline()
        {
            List<Stream> listStream = this.UsrModel.StreamsFollowed;
            string[,] arrayInfosStreams = new string[listStream.Count(), NB_INFOS_STREAM];

            for (int i = 0; i < listStream.Count();i++ )
            {
                arrayInfosStreams[i, 0] = listStream[i].preview.medium;
                arrayInfosStreams[i, 1] = listStream[i].channel.status;
                arrayInfosStreams[i, 2] = listStream[i].channel.display_name;
                arrayInfosStreams[i, 3] = listStream[i].game;
                arrayInfosStreams[i, 4] = listStream[i].viewers.ToString();
            }
            return arrayInfosStreams;
        }

        public int GetNbStreamOnline()
        {
            return this.UsrModel.StreamsFollowed.Count();
        }

        public int GetNbChannelFollowed()
        {
            return this.UsrModel.ChannelsFollowed.Count();
        }

        public string[,] GetInfosDisplayChannels()
        {
            List<Follow> listChannels = this.UsrModel.ChannelsFollowed;
            string[,] arrayInfosChannels = new string[listChannels.Count(), NB_INFOS_CHANNEL];

            for (int i = 0; i < listChannels.Count(); i++)
            {
                arrayInfosChannels[i, 0] = listChannels[i].channel.logo;
                arrayInfosChannels[i, 1] = listChannels[i].channel.display_name;
                arrayInfosChannels[i, 2] = listChannels[i].channel.followers.ToString();
                arrayInfosChannels[i, 3] = listChannels[i].channel.views.ToString();
            }
            return arrayInfosChannels;
        }
    }
}
