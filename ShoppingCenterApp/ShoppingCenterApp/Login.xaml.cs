using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShoppingCenterApp
{
    public partial class Login : ContentPage
    {
        async void signin_Clicked(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new Login());
        }


        async void Login_Clicked(object sender, EventArgs eventArgs)
        {
            if (await ValidarFormulario())
            {
                await DisplayAlert("Exito", "Todos tus campos cumplieron las validaciones", "Ok");

            }


        }
        private async Task<bool> ValidarFormulario()
        {
            if (String.IsNullOrWhiteSpace(user.Text))
            {
                await this.DisplayAlert("Advertencia", "El Campo de usuario es obligatorio", "Ok");
                return false;

            }
            else if (String.IsNullOrWhiteSpace(user.Text))
            {
                await this.DisplayAlert("Advertencia", "Ingrese su Contraseña", "Ok");
                return false;

            }
            return true;

        }


    }
}
