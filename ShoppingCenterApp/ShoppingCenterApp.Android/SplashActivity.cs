using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ShoppingCenterApp.Droid
{
<<<<<<< HEAD
    [Activity(Theme = "@style/Theme.splash.jpg", //Indicamos el tema que usaremos en esta actividad
              MainLauncher = true, //Lo inicializamos como pantalla de inicio
              NoHistory = true)] //No generamos historial para que no nos regrese a esta pantalla
=======
    [Activity(Theme = "@style/Theme.Splash",
         MainLauncher = true,
         NoHistory = true)]
>>>>>>> a8e4cb928efc5b3321cb911d554539bfc48fbefb
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
<<<<<<< HEAD

            // Create your application here

            System.Threading.Thread.Sleep(3000); //Esperamos 3 segundos...
            this.StartActivity(typeof(MainActivity));
=======
            System.Threading.Thread.Sleep(3000);
            StartActivity(typeof(MainActivity));

            // Create your application here
>>>>>>> a8e4cb928efc5b3321cb911d554539bfc48fbefb
        }
    }
}