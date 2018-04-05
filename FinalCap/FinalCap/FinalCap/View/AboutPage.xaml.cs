using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalCap.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();

            /** Because the viewmodel class is instantiated once in the App class, it maintains
             * the information for the duration of the application. Each new instance of the classes
             * can then simply access the properties and set the viewmodel object to its BindingContext.
             */
		    
		    SignInfoModel modelInfo = ((App) Application.Current).ModelInfo;
		    BindingContext = modelInfo;

           
		}

	    //protected override bool OnBackButtonPressed()
	    //{
	    //    return ! Info.IsValid || base.OnBackButtonPressed();
	    //}

	    //private async void ButtonDone_OnClicked(object sender, EventArgs e)
	    //{
	    //    await Navigation.PopModalAsync();
	    //    SendBackButtonPressed();
	    //}
	}
}