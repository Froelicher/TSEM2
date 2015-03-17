using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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


        public List<Stream> CheckNewStreamOnline()
        {
            List<Stream> diff = null;

            if(this.StreamOnline != null)
            {
                List<Stream> oldStreamOnline = new List<Stream>(this.StreamOnline);

                this.UpdateStreamsOnline();

                diff = new List<Stream>(this.StreamOnline);

                for (int i = 0; i < this.StreamOnline.Count(); i++)
                {
                    for (int j = 0; j < oldStreamOnline.Count(); j++)
                    {
                        if (this.StreamOnline[i]._id == oldStreamOnline[j]._id)
                        {
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
