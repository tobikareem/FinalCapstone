using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalCap.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SchoolPage : ContentPage
	{
		public SchoolPage ()
		{
			InitializeComponent ();
            BindingContext = new SchoolViewModel();
		}

	    private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
            Student student = e.SelectedItem as Student;

	        if (student != null)
	        {
	            ListView.SelectedItem = null;
                //await Navigation.PushAsync(new Stude)
	        }
	         
	    }
	}
}