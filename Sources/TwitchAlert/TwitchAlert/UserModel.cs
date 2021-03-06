﻿/*
 * Author : JP. Froelicher
 * Description : Model of user
 * Date : 18 / 03 / 2015
 */ 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    public class UserModel
    {
        private string _accessToken;
        private JsonSerializer _js;
        private Curl _cmdCurl;
        private List<Stream> _streamsFollowed;
        private List<Follow> _channelsFollowed;
        private Users _currentUser;

        internal List<Follow> ChannelsFollowed
        {
            get { return _channelsFollowed; }
            set { _channelsFollowed = value; }
        }

        internal Users CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        internal List<Stream> StreamsFollowed
        {
            get { return _streamsFollowed; }
            set { _streamsFollowed = value; }
        }

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
            set { _accessToken = value;
                  this.FillUser();
                  this.FillStreamsFollowed();
                  this.FillChannelsFollowed();
                }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public UserModel()
        {
            this.CmdCurl = new Curl();
            this.Js = new JsonSerializer();
            this.AccessToken = "";
        }

        /// <summary>
        /// If the user is connected
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsConnected()
        {
            if(this.AccessToken != "")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Fill the list with the stream followed by user
        /// </summary>
        public void FillStreamsFollowed()
        {
            if(this.IsConnected())
            {
                Streams streamsFollowed = this.CmdCurl.SendRequest<Streams>("https://api.twitch.tv/kraken/streams/followed", "GET", this.AccessToken);
                if(streamsFollowed != null)
                    this.StreamsFollowed = new List<Stream>(streamsFollowed.streams);
            }
        }

        /// <summary>
        /// Fill the list with the channel followed by user
        /// </summary>
        public void FillChannelsFollowed()
        {
            if (this.IsConnected())
            {
                Follows channelsFollowed = this.Js.Serialize<Follows>("https://api.twitch.tv/kraken/users/" + this.CurrentUser.name + "/follows/channels");
                if(channelsFollowed != null)
                    this.ChannelsFollowed = new List<Follow>(channelsFollowed.follows);
            }
        }

        /// <summary>
        /// To fill user with the information of api
        /// </summary>
        private void FillUser()
        {
            if (this.IsConnected())
            {
                this.CurrentUser = this.CmdCurl.SendRequest<Users>("https://api.twitch.tv/kraken/user", "GET", this.AccessToken);
            }
        }

        /// <summary>
        /// Fetch the access token in the url
        /// </summary>
        /// <param name="url">url with the access token</param>
        public void FetchAccessToken(string url)
        {
            bool inToken = false;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < url.Length; i++)
            {
                if (inToken)
                {
                    if (url[i] != '&')
                        result.Append(url[i]);
                    else
                        break;
                }

                if (url[i] == '=')
                {
                    inToken = true;
                }

            }
            this.AccessToken = result.ToString();
        }


        /// <summary>
        /// To follow a channel
        /// </summary>
        /// <param name="channel_name">channel name</param>
        public void FollowChannel(string channel_name)
        {
            if (this.IsConnected())
            {
                this.CmdCurl.SendRequest<Follow>("https://api.twitch.tv/kraken/users/" + this.CurrentUser.name + "/follows/channels/" + channel_name, "PUT", this.AccessToken);
                this.FillStreamsFollowed();
            }
        }

        /// <summary>
        /// To unfollow a channel
        /// </summary>
        /// <param name="channel_name"></param>
        public void UnFollowChannel(string channel_name)
        {
            if (this.IsConnected())
            {
                this.CmdCurl.SendRequest<Follow>("https://api.twitch.tv/kraken/users/" + this.CurrentUser.name + "/follows/channels/" + channel_name, "DELETE", this.AccessToken);
                this.FillStreamsFollowed();
            }
        }

        /// <summary>
        /// Check if the channel is followed
        /// </summary>
        /// <param name="channel_name">channel name</param>
        /// <returns>true or false</returns>
        public bool CheckIsFollowed(string channel_name)
        {
            for (int i = 0; i < this.ChannelsFollowed.Count(); i++)
            {
                if (this.ChannelsFollowed[i].channel.name == channel_name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
