using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewDefault.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IndexPage : ContentPage
	{
		public IndexPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoadingPage());
        }
    }
}