/*
 * Author : JP. Froelicher
 * Description : Controller of user
 * Date : 18 / 03 / 2015
 */ 
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

        /// <summary>
        /// Constructor with main view
        /// </summary>
        /// <param name="model">User model</param>
        /// <param name="view">Main view</param>
        public UserController(UserModel model, MainView view)
        {
            this.Model = model;
            this.MView = view;
        }

        /// <summary>
        /// Constructor with login view
        /// </summary>
        /// <param name="model">User model</param>
        /// <param name="view">Login view</param>
        public UserController(UserModel model, LoginView view)
        {
            this.Model = model;
            this.LogView = view;
        }

        /// <summary>
        /// Fetch the access token in url
        /// </summary>
        /// <param name="url">url</param>
        public void FetchAccessToken(string url)
        {
            this.Model.FetchAccessToken(url);
        }
        
        /// <summary>
        /// Check is a channel is followed
        /// </summary>
        /// <param name="channel_name">channel name</param>
        /// <returns>true or false</returns>
        public bool CheckIsFollowed(string channel_name)
        {
            return this.Model.CheckIsFollowed(channel_name);
        }

        /// <summary>
        /// if the user is connected
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsConnected()
        {
            return this.Model.IsConnected();
        }
    }
}
