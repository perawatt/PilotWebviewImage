using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iOSWebViewDefault.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            GetHtml().GetAwaiter();
        }

        private async Task GetHtml()
        {
            var http = new HttpClient();
            var html = "<div style='margin: 50px 15% 0'><div style='background-color: #ECEBF1; color: #ECEBF1; height: 250;'>default</div><p style='background-color: #ECEBF1; color: #ECEBF1; margin: 25px 0'>default</p><p style='background-color: #ECEBF1; color: #ECEBF1; margin: 25px 0'>default</p><p style='background-color: #ECEBF1; color: #ECEBF1; margin: 25px 0'>default</p></div>";
            hybrid.Source = new HtmlWebViewSource
            {
                Html = html
            };
            html = await http.GetStringAsync("http://google.com");

            //System.Threading.Thread.Sleep(3000);
            
            hybrid.Source = new HtmlWebViewSource
            {
                Html = html
            };
            //webview.Source = new HtmlWebViewSource
            //{
            //    Html = html
            //};
        }
    }
}