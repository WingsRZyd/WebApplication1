using System.Net;
using System.IO;
using Newtonsoft.Json;
using WebApplication1;
using WeatherWebApplication;

class Program
{
    public static void Main()
    {
        string url_1 = "http://dataservice.accuweather.com/currentconditions/v1/351194?apikey=94ekwXGskbGrS1AuHfFVCEZPxiVj5kq5";
        string url_2 = "https://api.openweathermap.org/data/2.5/weather?q=dallas&appid=443e5432e0d636d4fe215850b1079afb";


        Request<MainClass> request = new Request<MainClass>();
        List<MainClass> list = new List<MainClass>();
        List<MainClass> mainClasses = new List<MainClass>();

        //mainClasses = request.GetTemperature(url_1);
        list = request.GetTemperature(url_2);
 

        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        app.MapGet("/", () => mainClasses[0].Temperature.Metric.Value);

        app.Run();
    }
}

