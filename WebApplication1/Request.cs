using System;
using System.Net;
using Newtonsoft.Json;

namespace WeatherWebApplication
{
    public class Request<T>
    {
        public T GetTemperature(string url)
        {
            string response;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = sr.ReadToEnd();
            }

            //List<T> mainClass = (List<T>)JsonConvert.DeserializeObject(response, typeof(List<T>));
            T mainClass = (T)JsonConvert.DeserializeObject(response, typeof(T));
            return mainClass;
        }
        public List<T> GetTemperatureYa(string url)
        {
            string response;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Headers.Add("X-Yandex-API-Key: a055ff1f-4d69-416d-b018-76efd34c294f");

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