using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using iOSWebViewDefault.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(WebView), typeof(MyWebViewRenderer))]
namespace iOSWebViewDefault.iOS
{
    class MyWebViewRenderer : Xamarin.Forms.Platform.iOS.WebViewRenderer
    {
        public override void LoadHtmlString(string s, NSUrl baseUrl)
        {
            base.LoadHtmlString(s, baseUrl);
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null) { Delegate = new CustomWebViewDelegate(); }
        }
    }

    internal class CustomWebViewDelegate : UIWebViewDelegate
    {

        #region Event Handlers

        #endregion
    }
}