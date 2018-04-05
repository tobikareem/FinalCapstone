using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using FinalCap.Model;
using FinalCap.View;
using Xamarin.Forms;

namespace FinalCap.ViewModel
{
    class CoursesViewModel : BaseViewModel
    {
        public ObservableCollection<CoursesModel> CourseCollection { get; set; }
        public Command LoadCourseCommand { get; set; }

        public CoursesViewModel()
        {
            Title = "Courses";
            CourseCollection = new ObservableCollection<CoursesModel>();
            LoadCourseCommand = new Command(async () => await ExecuteLoadCoursesCommand());

            MessagingCenter.Subscribe<AddNewCoursePage, CoursesModel>(this, "AddCourse", async (obj, item) =>
            {
                var course = item as CoursesModel;
                CourseCollection.Add(course);
                await DataStore.AddItemAsync(course);
            });
        }

        private async Task ExecuteLoadCoursesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                CourseCollection.Clear();
                var courses = await DataStore.GetItemsAsync(true);
                foreach (var item in courses)
                {
                    CourseCollection.Add(item);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
