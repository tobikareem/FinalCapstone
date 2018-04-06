
using FinalCap.Model;

namespace FinalCap.ViewModel
{
    public class CourseDetailViewModel : BaseViewModel
    {
        public CoursesModel CoursesModel { get; set; }

        public CourseDetailViewModel(CoursesModel courses = null)
        {
            Title = courses?.HeadTitle;
            CoursesModel = courses;
        }
    }
}
