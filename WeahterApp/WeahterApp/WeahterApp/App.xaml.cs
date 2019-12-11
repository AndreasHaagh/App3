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

            if (!Application.Current.Properties.ContainsKey("backgroundColor"))
                Application.Current.Properties["backgroundColor"] = "#FFFFFF";

            if (!Application.Current.Properties.ContainsKey("textColor"))
                Application.Current.Properties["textColor"] = "#000000";


            SetStyleResources();

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

        private void SetStyleResources()
        {
            var contentPageStyle = new Style(typeof(ContentPage))
            {
                Setters =
                {
                    new Setter {Property = ContentPage.BackgroundColorProperty, Value = Color.FromHex(Application.Current.Properties["backgroundColor"].ToString())}
                }
            };

            var labelStyle = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter {Property = Label.TextColorProperty, Value = Color.FromHex(Application.Current.Properties["textColor"].ToString())}
                }
            };

            var buttonStyle = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter {Property = Button.TextColorProperty, Value = Color.FromHex(Application.Current.Properties["textColor"].ToString())}
                }
            };

            var entryStyle = new Style(typeof(Entry))
            {
                Setters =
                {
                    new Setter {Property = Entry.TextColorProperty, Value = Color.FromHex(Application.Current.Properties["textColor"].ToString())}
                }
            };

            Resources = new ResourceDictionary();
            Resources.Add("contentPageStyle", contentPageStyle);
            Resources.Add("labelStyle", labelStyle);
            Resources.Add("buttonStyle", buttonStyle);
            Resources.Add("entryStyle", entryStyle);
        }
    }
}
