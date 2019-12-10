using System;
using System.Collections.Generic;
using System.Text;

namespace WeahterApp.Models
{
    public class RootObject
    {
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
        public string name { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }
}
