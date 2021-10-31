using System;
using Xamarin.Forms;
using IDA.App.ViewModels;
using IDA.App.Views;
using Xamarin.Forms.Xaml;

namespace IDA.App
{
    public partial class App : Application
    {
        public static bool IsDevEnv
        {
            get
            {
                return true; //change this before release!
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new TheMainTabbedPage();
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
