
using System;
using FinalCap.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignIn : ContentPage
	{
		public SignIn ()
		{
			InitializeComponent ();

		    switch (Device.RuntimePlatform)
		    {
		        case Device.iOS:
		            Padding = new Thickness(0, 20, 0, 0);
		            break;
		        case Device.Android:
		            Padding = new Thickness(0, 20, 0, 0);
		            break;
		        case Device.WinPhone:
		            Padding = new Thickness(0, 20, 0, 0);
		            break;

		        default:
		            Padding = new Thickness(0, 20, 0, 0);
		            break;
		    }

		    /** Because the viewmodel class is instantiated once in the App class, it maintains
             * the information for the duration of the application. Each new instance of the classes
             * can then simply access the properties and set the viewmodel object to its BindingContext.
             */

            SignInfoModel signModel = ((App) Application.Current).ModelInfo;
		    BindingContext = signModel;

		    /** Unfortunately, the picker items property is not backed by a bindable property and hence, it is not bindable
		     * populate picker items list
		     */

            foreach (var departments in Info.Departments)
		    {
		        PickerDepartment.Items.Add(departments);
		    }

        }

	    private async void ButtonSignIn_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new CoursePage());
	    }
	}
    
}