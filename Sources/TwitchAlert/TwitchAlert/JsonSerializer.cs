using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using TwitchAlert.TwitchModels;

namespace TwitchAlert
{
    class JsonSerializer
    {
        public T Serialize<T>(string url)
        {
            WebClient wc = new WebClient();
            string strJson = wc.DownloadString(url);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes(strJson));
            T obj = (T)js.ReadObject(ms);
            ms.Close();

            return obj;
        }
    }
}
