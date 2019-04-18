using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppFinanceiro.Controller;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppFinanceiro
{
    public partial class App : Application
    {
        public static String dbPath;

        public static DBFinanca TbFinancas { get; set; }
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        public App(String path)
        {
            InitializeComponent();
            TbFinancas = new DBFinanca(dbPath);
            dbPath = Path;
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
