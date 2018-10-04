using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCenterApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
        void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

		public Home ()
		{
			InitializeComponent ();
		}
	}
}