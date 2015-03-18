/*
 * Author : JP. Froelicher
 * Description : Send a html request with cURL
 * Date : 18 / 03 / 2015
 */ 
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace TwitchAlert
{
    class Curl
    {
        /// <summary>
        /// Send a request http with cURL
        /// </summary>
        /// <typeparam name="T">Return generic type</typeparam>
        /// <param name="urlRequest">request url</param>
        /// <param name="p_method">method to use</param>
        /// <param name="p_acces_token">access token for authentificated request</param>
        /// <returns></returns>
        public T SendRequest<T>(string urlRequest, string p_method, string p_acces_token)
        {
            try
            {
                //Create a new http request
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlRequest);

                //Init the http request
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Accept = "application/vnd.twitchtv.v3+json";
                httpWebRequest.Method = p_method;
                httpWebRequest.Headers.Add("Authorization: OAuth " + p_acces_token);
                if (p_method == "PUT")
                    httpWebRequest.ContentLength = 0;

                //Create a http response
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                //Read the response
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //Add to the generics variable the result
                    T answer = JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
                    return answer;
                }
            }
            catch (WebException e)
            {
                return default(T);
            }
        }
    }
}
