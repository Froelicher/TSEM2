using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twitch.Net;

namespace TestTwitchWrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Twitch.Net.Model.Stream yolo = new Twitch.Net.Model.Stream();
            
        }
    }
}
