using System.Net;
using System.IO;
using Newtonsoft.Json;
using WebApplication1;

namespace WebApplication1
{
    public class WeatherOpenMap
    {
        public static void WeatherOpenMap1()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=dallas&appid=443e5432e0d636d4fe215850b1079afb";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = sr.ReadToEnd();
            }

            List<MainClass> mainClass = (List<MainClass>)JsonConvert.DeserializeObject(response, typeof(List<MainClass>));
        }
        
    }
}
