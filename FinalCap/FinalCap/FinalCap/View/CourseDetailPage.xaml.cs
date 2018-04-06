using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalCap.Model;
using FinalCap.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CourseDetailPage : ContentPage
	{
	    private readonly CourseDetailViewModel viewModel;

		public CourseDetailPage ()
		{
			InitializeComponent ();

		    var course = new CoursesModel
		    {
		        HeadLines = "This is a course code",
		        HeadLinesDesc = "This is a course description"
		    };

            viewModel = new CourseDetailViewModel(course);
		    BindingContext = viewModel;
		}

	    public CourseDetailPage(CourseDetailViewModel viewModel)
	    {
            InitializeComponent();

	        BindingContext = this.viewModel = viewModel;
	    }
	}
}