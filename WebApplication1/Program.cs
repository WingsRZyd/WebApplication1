using System.Net;
using System.IO;
using Newtonsoft.Json;
using WebApplication1;
using WeatherWebApplication;
using Microsoft.AspNetCore.Builder;

class Program
{
    public static void Main()
    {
        string url_1 = "http://dataservice.accuweather.com/currentconditions/v1/351194?apikey=94ekwXGskbGrS1AuHfFVCEZPxiVj5kq5";
        string url_2 = "http://api.openweathermap.org/data/2.5/weather?appid=443e5432e0d636d4fe215850b1079afb&units=metric&q=dallas";
        string url_4 = "http://api.weatherapi.com/v1/current.json?key=e8d17374e93d45718ef13055220706&q=Dallas&aqi=no";

        //Request<WeatherResponse> request = new Request<WeatherResponse>();
        //Request<MainClass> request1 = new Request<MainClass>();
        Request<MainClassApi> request2 = new Request<MainClassApi>();
        //MainClass list = new MainClass();
        List<MainClass> mainClasses = new List<MainClass>();
        WeatherResponse mainClass = new WeatherResponse();


        MainClassApi list = request2.GetTemperature(url_4);
        //MainClassApi mainClassApi = request2.GetTemperature(url_2);
        //List<MainClassApi> mainClasses1 = request2.GetTemperatureYa(url_1);



        // mainClass = request.GetTemperature(url_2);
        //mainClasses = request1.GetTemperatureYa(url_1);


        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        app.MapGet("/", () => /*mainClasses1[0].Temperature.Metric.Value);//mainClassApi.Main.Temp);//*/list.Current.Temp_c);//mainClasses1[0].Temperature.Metric.Value);
        Console.WriteLine(/*mainClasses[0].Temperature.Metric.Value.ToString(), mainClass.Main.Temp*/);
        app.Run();
    }
}

