using System;
using FinalCap.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalCap.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNewCoursePage : ContentPage
	{
        public CoursesModel CoursesModel { get; set; }
		public AddNewCoursePage ()
		{
			InitializeComponent ();
            CoursesModel = new CoursesModel
            {
                Id = "Course ID",
                HeadLines = "Course Name"
            };

		    BindingContext = this;
		}

	    private async void OnSave_Clicked(object sender, EventArgs e)
	    {
	        MessagingCenter.Send(this, "AddCourse", CoursesModel);
	        await Navigation.PopToRootAsync();
	    }
	}
}