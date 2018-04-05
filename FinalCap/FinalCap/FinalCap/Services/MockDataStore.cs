using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCap.Model;

namespace FinalCap.Services
{
    class MockDataStore : IDataStore<CoursesModel>
    {
        private List<CoursesModel> courses;

        public MockDataStore()
        {
            courses = new List<CoursesModel>();
            var courseItems = new List<CoursesModel>
            {
                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " 1 day ago - Facebook",
                    HeadLines = "Samsung SM-T#85s with Android 7.0 gets wifi certifies - GSM Arena News ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4.........Small " +
                                    "samples based on your scenario. Please review my project and let us know "
                },

                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " 1 day ago - Facebook",
                    HeadLines = "Samsung SM-T#85s with Android 7.0 gets wifi certifies - GSM Arena News ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4.........Small " +
                                    "samples based on your scenario. Please review my project and let us know "
                },

                new CoursesModel
                {
                    HeadTitle = " 1 day ago - Facebook",
                    HeadLines = "Samsung SM-T#85s with Android 7.0 gets wifi certifies - GSM Arena News ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4.........Small " +
                                    "samples based on your scenario. Please review my project and let us know "
                },

                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " 1 day ago - Facebook",
                    HeadLines = "Samsung SM-T#85s with Android 7.0 gets wifi certifies - GSM Arena News ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4.........Small " +
                                    "samples based on your scenario. Please review my project and let us know "
                },

                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " 1 day ago - Facebook",
                    HeadLines = "Samsung SM-T#85s with Android 7.0 gets wifi certifies - GSM Arena News ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4.........Small " +
                                    "samples based on your scenario. Please review my project and let us know "
                },

                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " 1 day ago - Facebook",
                    HeadLines = "Samsung SM-T#85s with Android 7.0 gets wifi certifies - GSM Arena News ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4.........Small " +
                                    "samples based on your scenario. Please review my project and let us know "
                }
            };

            foreach (var items in courseItems)
            {
                courses.Add(items);
            }
        }

        public async Task<bool> AddItemAsync(CoursesModel item)
        {
            courses.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(CoursesModel item)
        {
            var course = courses.FirstOrDefault(arg => arg.Id == item.Id);
            courses.Remove(course);
            courses.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var course = courses.FirstOrDefault(arg => arg.Id == id);
            courses.Remove(course);
            return await Task.FromResult(true);
        }

        public async Task<CoursesModel> GetItemAsync(string id)
        {
            return await Task.FromResult(courses.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<CoursesModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(courses);
        }
    }
}
