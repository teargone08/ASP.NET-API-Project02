using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WeatherAPIApp.Models
{
    public class Weather
    {
        public Object getWeatherForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Chicago&APPID=540f5454a97090f89c35e45e85b5304b&units=imperial";
            //synchronous client.
            //var client = new WebClient();
            //var content = client.DownloadString(url);
            //var serializer = new JavaScriptSerializer();
            //var jsonContent = serializer.Deserialize<Object>(content);
            //return jsonContent;
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}