using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSWebViewDefault.iOS.BaseUrl_iOS))]
namespace iOSWebViewDefault.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}