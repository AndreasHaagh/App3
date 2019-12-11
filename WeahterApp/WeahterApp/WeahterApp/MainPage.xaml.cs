using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using WeahterApp.Services;
using WeahterApp.Interfaces;
using WeahterApp.Models;

namespace WeahterApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        IDataService dataService;

        public MainPage()
        {
            dataService = new DataService();
            InitializeComponent();

            test_color.Text = Application.Current.Properties["color"].ToString();
        }

        async private void Get_Weahter_BTN_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string url = "https://api.openweathermap.org/data/2.5/weather?units=metric";

            if (btn.StyleId == "GPS_Weather_BTN")
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);
                url += $"&lat={location.Latitude}&lon={location.Longitude}";
            } else if (btn.StyleId == "City_Weather_BTN")
            {
                url += $"&q={City_Entry.Text}";
            } else
            {
                Console.WriteLine("Error: undefined button");
                return;
            }

            RootObject data = dataService.GetWeatherData(url);
            ClearText();

            if (data.name == null)
            {
                Error_LAB.Text = "Error: City or location not found";
                return;
            }

            City_LAB.Text = data.name;
            Temp_LAB.Text = $"{data.main.temp} \u00B0C";
        }

        private void ClearText()
        {
            City_Entry.Text = "";
            City_LAB.Text = "";
            Temp_LAB.Text = "";
            Error_LAB.Text = "";
        }

        private void Settings_BTN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage(this));
        }

        private void save_color_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["color"] = test_color.Text;
            MainContent.BackgroundColor = Color.FromHex(test_color.Text);
        }
    }
}
