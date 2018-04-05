

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HelloPage : ContentPage
	{
		public HelloPage ()
		{
			InitializeComponent ();
		}

	    private async void Modeless(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new ModelessPage());
	    }

	    private async void Modal(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new AboutPage(), true);
	    }
	}
}