using System;
using System.Collections.Generic;
using System.Text;
using WeahterApp.Models;

namespace WeahterApp.Interfaces
{
    interface IWeatherService
    {
         RootObject GetData(object input);
    }
}
