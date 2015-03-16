using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class NotificationController
    {
        private MainView _view;
        private NotificationModel _notifModel;

        internal NotificationModel NotifModel
        {
            get { return _notifModel; }
            set { _notifModel = value; }
        }

        public MainView View
        {
            get { return _view; }
            set { _view = value; }
        }

        public NotificationController(MainView view, NotificationModel model)
        {
            this.NotifModel = model;
            this.View = view;
        }

        public List<string> CheckNewStreamOnline()
        {
            List<string> result = new List<string>();
            List<Stream> newStream = this.NotifModel.CheckNewStreamOnline();

            if(newStream != null)
            {
                if (newStream.Count() != 0)
                {
                    for (int i = 0; i < newStream.Count(); i++)
                    {
                        result.Add(newStream[i].channel.status);
                        result.Add(newStream[i].game);
                        result.Add(newStream[i].channel.name);
                        result.Add(newStream[i].viewers.ToString());
                        result.Add(newStream[i].preview.medium);
                    }
                    return result;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
