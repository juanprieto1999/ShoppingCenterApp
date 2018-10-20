using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ShoppingCenterApp.Droid
{
<<<<<<< HEAD
    [Activity(Label = "ShoppingCenterApp", 
               Icon = "@drawable/icon", 
               Theme = "@style/MainTheme",
                ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]


=======
    [Activity(Label = "ShoppingCenterApp", Icon = "@drawable/Icono", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
>>>>>>> a8e4cb928efc5b3321cb911d554539bfc48fbefb
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

