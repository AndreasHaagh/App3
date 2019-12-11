using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using WeahterApp.Models;
using WeahterApp.Interfaces;
using System.Net;
using Newtonsoft.Json;

namespace WeahterApp.Services
{
    class DataService : IDataService
    {
        public RootObject GetWeatherData(string url)
        {
            string apiKey = "4b1af0d041c21213986aedce3052cb9e";
            url += $"&appid={apiKey}";
            using (WebClient wc = new WebClient())
            {
                try
                {
                    var json = wc.DownloadString(url);
                    Console.WriteLine(json);
                    RootObject data = JsonConvert.DeserializeObject<RootObject>(json);
                    return data;
                }
                catch (WebException)
                {
                    return new RootObject();
                }
            }
        }
    }
}
