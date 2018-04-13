using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.SqlClient;

using FinalCap.Model;

namespace FinalCap.Services
{
    class UserDataStore : IDataStore<SignInfoModel>
    {
        public List<SignInfoModel> GetStudents;

        public UserDataStore()
        {
            GetStudents = new List<SignInfoModel>();

            var studentInfo = new List<SignInfoModel>
            {
                new SignInfoModel
                {
                    StudentId = 1067,
                    Department = "CSC",
                    Password = "Obed"
                },
                new SignInfoModel
                {
                    StudentId = 1075,
                    Department = "PSY",
                    Password = "Jeremy"
                }
            };
            foreach (var item in studentInfo)
            {
                GetStudents.Add(item);
            }
        }

        //public void Login()
        //{
        //    var connString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;

        //    var conn = new SqlConnection(connString);

        //    SqlDataReader dataReader = null;

        //    try
        //    {
        //        conn.Open();

        //        var cmd = new SqlCommand
        //        {
        //            Connection = conn,
        //            CommandType = CommandType.Text,
        //            CommandText = "SELECT * FROM Student"
        //        };

        //        dataReader = cmd.ExecuteReader();
        //    }
        //    catch (SqlException e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }

        //}

        public async Task<bool> AddItemAsync(SignInfoModel item)
        {
            GetStudents.Add(item);
            return await Task.FromResult(true);
        }

        public Task<bool> UpdateItemAsync(SignInfoModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<SignInfoModel> GetItemAsync(string id)
        {
            return await Task.FromResult(GetStudents.FirstOrDefault(s => s.StudentId.ToString() == id));
        }

        public async Task<IEnumerable<SignInfoModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult((GetStudents));
        }
    }
}
