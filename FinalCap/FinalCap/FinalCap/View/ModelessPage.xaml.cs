using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ModelessPage : ContentPage
	{
		public ModelessPage ()
		{
			InitializeComponent ();
		    switch (Device.RuntimePlatform)
		    {
                case Device.iOS:
                    NavigationPage.SetTitleIcon(this, "hofstra_bd.jpg");
                    break;
                case Device.Android:
                    NavigationPage.SetTitleIcon(this, "hofstra_bd.jpg");
                    break;
                default:
                    NavigationPage.SetTitleIcon(this, "hofstra_bd.jpg");
                    break;
            }
		}

	    private async void GoBackToMain(object sender, EventArgs e)
	    {
	        await Navigation.PopAsync();
	    }
	}
}