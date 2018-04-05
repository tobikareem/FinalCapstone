using FinalCap.Model;
using FinalCap.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentView
	{
	    private CoursesViewModel _viewModel;
		public HomePage ()
		{
			InitializeComponent ();
		    BindingContext = _viewModel = new CoursesViewModel();
		}
        
	}
}