using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TwitchAlert
{
    class Curl
    {
        public T SendRequest<T>(string urlRequest, string p_method, string p_acces_token)
        {
            JsonSerializer js = new JsonSerializer();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlRequest);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Method = p_method;
            httpWebRequest.Headers.Add("Accept: application/vnd.twitchtv.v2+json");
            if(p_method != "GET" || p_method != "POST")
            {
                httpWebRequest.Headers.Add("Authorization: OAuth "+p_acces_token);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                T answer = JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                return answer;
            }
        }
    }
}
