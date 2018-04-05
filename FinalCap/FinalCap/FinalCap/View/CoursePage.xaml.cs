using FinalCap.Model;
using FinalCap.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CoursePage : ContentPage
    {
        private readonly CoursesViewModel _viewModel;
		public CoursePage ()
		{
			InitializeComponent ();
		    
		    BindingContext = _viewModel = new CoursesViewModel();
		}
        

	    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        var item = e.SelectedItem as CoursesModel;
            if(item == null)
                return;
	        
	    }

	    protected override void OnAppearing()
	    {
            base.OnAppearing();
            if(_viewModel.CourseCollection.Count == 0)
                _viewModel.LoadCourseCommand.Execute(null);
	    }
	}
}