using System;
using Xamarin.Forms;
using WebViewDefault.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace WebViewDefault
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();


			MainPage = new NavigationPage(new IndexPage());
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
