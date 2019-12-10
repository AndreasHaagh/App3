using System;
using System.Collections.Generic;
using System.Text;
using WeahterApp.Interfaces;
using WeahterApp.Models;
using Xamarin.Essentials;

namespace WeahterApp.Services
{
    class GPSWeatherService : IWeatherService
    {
        public RootObject GetData(object input)
        {
            Location location = (Location) (input);
            Console.WriteLine("Latitude: " + location.Latitude);
            
            throw new NotImplementedException();
        }
    }
}
