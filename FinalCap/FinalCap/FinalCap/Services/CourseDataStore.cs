using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalCap.Model;

namespace FinalCap.Services
{
    class CourseDataStore : IDataStore<CoursesModel>
    {
        private List<CoursesModel> courses;

        public CourseDataStore()
        {
            
            courses = new List<CoursesModel>();
            var courseItems = new List<CoursesModel>
            {
                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " Semester Hours: 3 - CSC 2601",
                    HeadLines = "INTRODUCTION TO ALGORITHM ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Posted by: Vincent Costa" + Environment.NewLine +
                                    "The Advanced Operating System begins on Tuesday, January 26. In Preparation for the class. please" +
                                    "do the following: " + Environment.NewLine + "1. Obtain the textbook"
                },

                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " Semester Hours: 3 - CSC 300-K",
                    HeadLines = "INDEPENDENT PROJECTS ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Permission of department and the completion of 21 graduate credits. Credit gigen for only one of " +
                                    "CSC 300, CSC 301, and CSC 302 0r CSC 303 "
                },

                new CoursesModel
                {
                    HeadTitle = " Semester Hours: 3 - CSC 188-01",
                    HeadLines = "INTRO TO NETWORK SECURITY ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "The Advanced Operating System begins on Tuesday, January 26. In Preparation for the class. please" +
                                    "do the following: " + Environment.NewLine + "1. Obtain the textbook"
                },

                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " Semester Hours: 3 - CSC 258-01",
                    HeadLines = " MOBILE DEVICE PROGRAMMING ",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4.........Small " +
                                    "samples based on your scenario. Please review my project and let us know "
                },

                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " Semester Hours: 3 - CSC 188-01",
                    HeadLines = "  INFORMATION RETREIVAL",
                    ProfileImage = "hofstra_image.png",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4.........Small " +
                                    "samples based on your scenario. Please review my project and let us know "
                },

                new CoursesModel
                {
                    Id = Guid.NewGuid().ToString(),
                    HeadTitle = " Semester Hours: 3 - CSC 188-01",
                    HeadLines = "PROGRAMMING LANG ",
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
