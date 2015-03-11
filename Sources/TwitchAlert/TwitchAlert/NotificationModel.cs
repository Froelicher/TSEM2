using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            this.StreamOnline = new List<Stream>();
        }

        /// <summary>
        /// Fill the list of online stream with the list of followed stream
        /// </summary>
        public void FillStreamOnline()
        {
            this.User.FillStreamsFollowed();
            for (int i = 0; i < this.User.StreamsFollowed.Count()-1; i++)
            {
                if(this.User.StreamsFollowed[i] != null)
                {
                    this.StreamOnline.Add(this.User.StreamsFollowed[i]);
                }
            }
        }


        public void CheckNewStreamOnline()
        {
            List<Stream> oldStreamOnline = this.StreamOnline;
            this.FillStreamOnline();

            var DifferencesList = oldStreamOnline.Where(x => !this.StreamOnline.Any(x1 => x1._id == x._id))
            .Union(this.StreamOnline.Where(x => !oldStreamOnline.Any(x1 => x1._id == x._id)));



        }
    }
}
