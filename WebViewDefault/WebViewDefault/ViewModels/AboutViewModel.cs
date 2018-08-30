using System;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;

using Xamarin.Forms;

namespace WebViewDefault.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}