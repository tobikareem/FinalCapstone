using FinalCap.Model;
using FinalCap.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CoursePage : ContentPage
	{
	    private CoursesViewModel coursesView;
		public CoursePage ()
		{
			InitializeComponent ();
		}
        

	    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        var item = e.SelectedItem as CoursesModel;
            if(item == null)
                return;
	        
	    }
	}
}