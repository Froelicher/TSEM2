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

        public LoginView() : this(null)
        {
            InitializeComponent();
        }

        public LoginView(MainView mainView)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {
           
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

            }
        }   
    }
}
