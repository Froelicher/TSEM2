/*
 * Author : JP. Froelicher
 * Description : Receive information by API Twitch formatted in Json.
 * Date : 18 / 03 / 2015
 */ 
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

namespace TwitchAlert
{
    class JsonSerializer
    {
        /// <summary>
        /// Serialize a API Twitch result
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="url">url for get the result</param>
        /// <returns>variable with a generic type</returns>
        public T Serialize<T>(string url)
        {
            //Create a new generic object
            T obj = default(T);
            try
            {
                WebClient wc = new WebClient();
                //Download the result in a string
                string strJson = wc.DownloadString(url);

                //Serialize the result
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(System.Text.UTF8Encoding.Unicode.GetBytes(strJson));
                
                //Read and add to generic object the result
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
