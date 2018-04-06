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

		    ListView.ItemSelected +=  async (sender,  e) =>
		    {
		        if (!(e.SelectedItem is CoursesModel item))
		            return;

		        await Navigation.PushAsync(new CourseDetailPage(new CourseDetailViewModel(item)));

		    };

		}

	    protected override void OnAppearing()
	    {
            base.OnAppearing();
            if(_viewModel.CourseCollection.Count == 0)
                _viewModel.LoadCourseCommand.Execute(null);
	    }
	}
}