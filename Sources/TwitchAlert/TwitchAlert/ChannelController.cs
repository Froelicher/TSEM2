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
        private const int NB_INFOS_STREAM = 6;
        private const int NB_INFOS_CHANNEL = 4;
        private const int NB_INFOS_CHANNEL_VIEW = 18;

        private UserModel _usrModel;
        private MainView _mainView;
        private ChannelView _chanView;
        private StreamModel _strmModel;

        internal StreamModel StrmModel
        {
            get { return _strmModel; }
            set { _strmModel = value; }
        }

        public ChannelView ChanView
        {
            get { return _chanView; }
            set { _chanView = value; }
        }

        public MainView MainView
        {
            get { return _mainView; }
            set { _mainView = value; }
        }

        internal UserModel UsrModel
        {
            get { return _usrModel; }
            set { _usrModel = value; }
        }

        public ChannelController(MainView view, UserModel usrModel)
        {
            this.MainView = view;
            this.UsrModel = usrModel;
        }

        public ChannelController(ChannelView view, StreamModel model)
        {
            this.ChanView = view;
            this.StrmModel = model;
        }

        public int GetNbStreamOnline()
        {
            return this.UsrModel.StreamsFollowed.Count();
        }

        public int GetNbChannelFollowed()
        {
            return this.UsrModel.ChannelsFollowed.Count();
        }

        public string[,] GetInfosDisplayStreamsOnline()
        {
            this.UsrModel.FillStreamsFollowed();
            this.UsrModel.FillChannelsFollowed();
            List<Stream> listStream = this.UsrModel.StreamsFollowed;
            string[,] arrayInfosStreams = new string[listStream.Count(), NB_INFOS_STREAM];

            for (int i = 0; i < listStream.Count();i++ )
            {
                arrayInfosStreams[i, 0] = listStream[i].preview.medium;
                arrayInfosStreams[i, 1] = listStream[i].channel.status;
                arrayInfosStreams[i, 2] = listStream[i].channel.display_name;
                arrayInfosStreams[i, 3] = listStream[i].game;
                arrayInfosStreams[i, 4] = listStream[i].viewers.ToString();
                arrayInfosStreams[i, 5] = listStream[i].channel.name;
            }
            return arrayInfosStreams;
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

        public string[] GetAllInfosChannel(string channel_name)
        {
            Streams currentStream = this.StrmModel.GetAllInfosStream(channel_name);
            string[] arrayInfosStream = new string[NB_INFOS_CHANNEL_VIEW];

            if (currentStream != null)
            {
                arrayInfosStream[0] = currentStream.stream.channel.status;
                arrayInfosStream[1] = currentStream.stream.channel.display_name;
                arrayInfosStream[2] = currentStream.stream.game;
                arrayInfosStream[3] = currentStream.stream.channel.logo;
                arrayInfosStream[4] = currentStream.stream.viewers.ToString();
                arrayInfosStream[5] = currentStream.stream.created_at.ToString();
                arrayInfosStream[6] = currentStream.stream.channel.name;
                arrayInfosStream[7] = currentStream.stream.channel.followers.ToString();
                arrayInfosStream[8] = currentStream.stream.channel.views.ToString();
                arrayInfosStream[9] = currentStream.stream.channel.created_at;
                arrayInfosStream[10] = currentStream.stream.channel.updated_at;
                arrayInfosStream[11] = currentStream.stream.channel.url;
                arrayInfosStream[12] = currentStream.stream.channel.partner;
                arrayInfosStream[13] = currentStream.stream.channel.mature;
                arrayInfosStream[14] = currentStream.stream.channel.delay.ToString();
                arrayInfosStream[15] = currentStream.stream.channel._id.ToString();
                arrayInfosStream[16] = currentStream.stream.channel.broadcaster_language;
                arrayInfosStream[17] = currentStream.stream.channel.language;
            }

            return arrayInfosStream;
        }

        public void FollowChannel(string channel_name)
        {
            if(!this.UsrModel.CheckIsFollowed(channel_name))
            {
                this.UsrModel.FollowChannel(channel_name);
            }
        }

        public void UnFollowChannel(string channel_name)
        {
            if (this.UsrModel.CheckIsFollowed(channel_name))
            {
                this.UsrModel.UnFollowChannel(channel_name);
            }
        }
    }
}
