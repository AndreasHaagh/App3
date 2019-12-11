using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeahterApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        MainPage main;
        public SettingsPage(MainPage main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Apply_BTN_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["backgroundColor"] = background_entry.Text;
            Application.Current.Properties["textColor"] = text_entry.Text;
            Navigation.PopModalAsync();
        }
    }
}