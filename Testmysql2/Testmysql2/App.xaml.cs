using System;
using Testmysql2.Services;
using Testmysql2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testmysql2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
