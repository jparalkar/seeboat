using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SeeboatApp
{
	public partial class App : Application
	{
        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }
        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#085DAD"), BarTextColor = Color.White }; ;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
