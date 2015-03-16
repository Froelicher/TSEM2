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
            T obj = default(T);
            try
            {
                WebClient wc = new WebClient();
                string strJson = wc.DownloadString(url);
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(System.Text.UTF8Encoding.Unicode.GetBytes(strJson));
                obj = (T)js.ReadObject(ms);
                ms.Close(); 
            }
            catch(WebException e)
            {
               
            }

            return obj;
        }
    }
}
