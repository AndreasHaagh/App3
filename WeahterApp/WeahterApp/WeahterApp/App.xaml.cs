using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeahterApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (!Application.Current.Properties.ContainsKey("color"))
            {
                Application.Current.Properties["color"] = "#FFFFFF";
            }

            var contentPageStyle1 = new Style(typeof(ContentPage))
            {
                Setters =
                {
                    new Setter {Property = ContentPage.BackgroundColorProperty, Value = Color.FromHex(Application.Current.Properties["color"].ToString())}
                }
            };

            Resources = new ResourceDictionary();
            Resources.Add("ContentPageStyle", contentPageStyle1);

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
