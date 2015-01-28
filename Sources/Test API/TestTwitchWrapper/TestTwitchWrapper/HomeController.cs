using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Twitch.Net.Interfaces;
using Twitch.Net.Model;

namespace TestTwitchWrapper
{
    class HomeController : Controller
    {
        private readonly ITwitchStaticClient _staticClient;

        public HomeController(ITwitchStaticClient staticClient)
        {
            _staticClient = staticClient;
        }

        public Channel Index()
        {
            Channel channel = _staticClient.GetChannel("ogaminglol");
            return channel;
        }
    }
}
