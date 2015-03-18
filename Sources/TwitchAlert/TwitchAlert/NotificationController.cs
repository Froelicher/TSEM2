/*
 * Author : JP. Froelicher
 * Description : Controller of notification
 * Date : 18 / 03 / 2015
 */ 
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">Main view</param>
        /// <param name="model">Notification model</param>
        public NotificationController(MainView view, NotificationModel model)
        {
            this.NotifModel = model;
            this.View = view;
        }

        /// <summary>
        /// Check if a new stream has begin
        /// </summary>
        /// <returns>list of new stream</returns>
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
