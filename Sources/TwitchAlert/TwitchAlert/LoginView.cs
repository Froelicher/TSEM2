using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchAlert
{
    public partial class LoginView : Form
    {
        private UserController _usrController;
        private MainView _mView;

        public MainView MView
        {
            get { return _mView; }
            set { _mView = value; }
        }

        internal UserController UsrController
        {
            get { return _usrController; }
            set { _usrController = value; }
        }


        public LoginView() : this(null, null)
        {

        }

        public LoginView(MainView mainView, UserModel model)
        {
            InitializeComponent();
            this.MView = mainView;
            this.timer_checkUrl.Enabled = true;
            this.UsrController = new UserController(model, this);
        }

        private void wbLogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string[] Cookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            foreach (string currentFile in Cookies)
            {
                try
                {
                    System.IO.File.Delete(currentFile);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void timer_checkUrl_Tick(object sender, EventArgs e)
        {
            string search = "access_token";
            if(wbLogin.Url.ToString().IndexOf(search) != -1)
            {
                this.UsrController.FetchAccessToken(wbLogin.Url.ToString());
                this.Close();
            }
        }

        private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer_checkUrl.Enabled = false;
        }   
    }
}
