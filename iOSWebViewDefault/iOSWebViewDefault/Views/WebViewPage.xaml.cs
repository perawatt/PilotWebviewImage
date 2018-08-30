using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iOSWebViewDefault.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage (string html)
		{
			InitializeComponent ();
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "local.html");
            string text;
            byte[] a;
            if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "downloaded.png")))
                DownloadImage();
            else
                a = File.ReadAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "downloaded.png"));
            if (File.Exists(fileName)) {
                text = File.ReadAllText(fileName);
            }
            else
            {
                File.WriteAllText(fileName, $"<html><head><title>Xamarin Forms</title></head><body><h1>Xamrin.Forms</h1><p>This is an iOS web page.</p><img src='{Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "downloaded.png")}' /><img src='https://www.w3schools.com/w3css/img_lights.jpg' /></body></html>");
                text = File.ReadAllText(fileName);
            }

            hybrid.Source = new HtmlWebViewSource
            {
                Html = text
            };
        }

        public void DownloadImage()
        {
            var webClient = new WebClient();
            webClient.DownloadDataCompleted += (s, e) => {
                var bytes = e.Result; // get the downloaded data
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string localFilename = "downloaded.png";
                string localPath = Path.Combine(documentsPath, localFilename);
                File.WriteAllBytes(localPath, bytes); // writes to local storage
            };
            var url = new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png");
            webClient.DownloadDataAsync(url);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}