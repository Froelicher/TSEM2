/*
 * Author : JP. Froelicher
 * Description : Model of notification
 * Date : 18 / 03 / 2015
 */ 
using System.Collections.Generic;
using System.Linq;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class NotificationModel
    {
        private UserModel _user;
        private List<Stream> _streamOnline;

        internal List<Stream> StreamOnline
        {
            get { return _streamOnline; }
            set { _streamOnline = value; }
        }

        internal UserModel User
        {
            get { return _user; }
            set { _user = value; }
        }

        public NotificationModel(UserModel usr)
        {
            this.User = usr;
            this.StreamOnline = this.User.StreamsFollowed;
        }

        public void UpdateStreamsOnline()
        {
            this.User.FillStreamsFollowed();
            this.StreamOnline = this.User.StreamsFollowed;
        }

        /// <summary>
        /// Check the new online stream
        /// </summary>
        /// <returns>list of new online stream</returns>
        public List<Stream> CheckNewStreamOnline()
        {
			//List of new streams online
            List<Stream> diff = null;

            if(this.StreamOnline != null)
            {
				//Create a new list with the current online streams
                List<Stream> oldStreamOnline = new List<Stream>(this.StreamOnline);
				
				//Update the current online streams
                this.UpdateStreamsOnline();
				
				//Create a new list with the current online streams
                diff = new List<Stream>(this.StreamOnline);
				
				//Compare the two list
                for (int i = 0; i < this.StreamOnline.Count(); i++)
                {
                    for (int j = 0; j < oldStreamOnline.Count(); j++)
                    {
                        if (this.StreamOnline[i]._id == oldStreamOnline[j]._id)
                        {
							//remove if the current stream is in the old list stream
                            diff.Remove(StreamOnline[i]);
                        }
                    }
                }
            }
            else
            {
                this.UpdateStreamsOnline();
            }
            return diff;
        }

    }
}
