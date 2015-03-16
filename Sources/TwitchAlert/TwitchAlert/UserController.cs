using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAlert
{
    class UserController
    {
        private UserModel _model;
        private LoginView _logView;
        private MainView _mView;

        public MainView MView
        {
            get { return _mView; }
            set { _mView = value; }
        }

        public LoginView LogView
        {
            get { return _logView; }
            set { _logView = value; }
        }

        internal UserModel Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public UserController(UserModel model, MainView view)
        {
            this.Model = model;
            this.MView = view;
        }

        public UserController(UserModel model, LoginView view)
        {
            this.Model = model;
            this.LogView = view;
        }

        public void FetchAccessToken(string url)
        {
            this.Model.FetchAccessToken(url);
        }
        
        public bool CheckIsFollowed(string channel_name)
        {
            return this.Model.CheckIsFollowed(channel_name);
        }

        public bool IsConnected()
        {
            return this.Model.IsConnected();
        }
    }
}
