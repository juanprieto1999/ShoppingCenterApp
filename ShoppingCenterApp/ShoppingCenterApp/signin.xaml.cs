using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShoppingCenterApp
{
    public partial class signin : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Registro", "Registro Correctamente", "Ok");
           
        }

        public signin()
        {
            InitializeComponent();
        }
    }
}
