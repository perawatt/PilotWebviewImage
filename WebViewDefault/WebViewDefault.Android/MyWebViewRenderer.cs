using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using WebViewDefault.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.WebView), typeof(MyWebViewRenderer))]
namespace WebViewDefault.Droid
{
    public class MyWebViewRenderer : Xamarin.Forms.Platform.Android.WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                this.Control.SetWebViewClient(new Client(this));
            }
        }

        private class Client : WebViewClient
        {
            private readonly WeakReference<MyWebViewRenderer> webHybrid;

            public Client(MyWebViewRenderer webHybrid)
            {
                this.webHybrid = new WeakReference<MyWebViewRenderer>(webHybrid);
            }

            public override void OnLoadResource(Android.Webkit.WebView view, string url)
            {
                base.OnLoadResource(view, url);
            }

            public override WebResourceResponse ShouldInterceptRequest(Android.Webkit.WebView view, IWebResourceRequest request)
            {
                //if (request.Method == "POST")
                //{
                //    view.StopLoading();
                //}
                return base.ShouldInterceptRequest(view, request);
            }

            private class ChromeClient : WebChromeClient
            {
                public override void OnRequestFocus(Android.Webkit.WebView view)
                {
                    base.OnRequestFocus(view);
                }
            }

        }
    }
}