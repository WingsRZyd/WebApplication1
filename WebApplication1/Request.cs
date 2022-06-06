using System;
using System.Net;
using Newtonsoft.Json;

namespace WeatherWebApplication
{
    public class Request<T>
    {
        public List<T> GetTemperature(string url)
        {
            string response;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = sr.ReadToEnd();
            }

            List<T> mainClass = (List<T>)JsonConvert.DeserializeObject(response, typeof(List<T>));

            return mainClass;
        }
    }
}