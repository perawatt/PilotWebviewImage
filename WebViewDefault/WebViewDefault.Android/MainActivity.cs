using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Services.Geolocation;

namespace WebViewDefault.Droid
{
    [Activity(Label = "WebViewDefault", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            var container = new SimpleContainer();
            container.Register<IDevice>(t => AndroidDevice.CurrentDevice);
            container.Register<IGeolocator, Geolocator>();
            Resolver.SetResolver(container.GetResolver());

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

