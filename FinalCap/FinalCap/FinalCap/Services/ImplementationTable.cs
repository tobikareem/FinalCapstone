
//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using FinalCap.Annotations;
//using Newtonsoft.Json;
//using TobChatWeb.Models;

//namespace FinalCap.Services
//{
//    //This class implements the ICloudTable
//    public class ImplementationTable<T> : ICloudTable<T>
//    {
//        private readonly HttpClient _client;

//        public ImplementationTable()
//        {
//            _client = new HttpClient { BaseAddress = new Uri($"{App.DepartmentUrl}/") };

//        }
//        public async Task<bool> CreateItemAsync(T item)
//        {
//            if (item == null)
//                return false;
//            var json = JsonConvert.SerializeObject(item);

//            var response = await _client.PostAsync($"api/item", new StringContent(json, Encoding.UTF8, "application/json"));
//            return response.IsSuccessStatusCode;

//        }

//        [ItemNotNull]
//        public async Task<T> ReadItemAsync(string id)
//        {
//            var json = await _client.GetStringAsync($"api/Department/{id}");
//            return await Task.Run((() => JsonConvert.DeserializeObject<T>(json)));

//        }

//        public async Task<bool> UpdateItemAsync(int id, T item)
//        {
//            if (item == null)
//                return false;
//            var serializedItem = JsonConvert.SerializeObject(item);
//            var buffer = Encoding.UTF8.GetBytes((serializedItem));
//            var byteContent = new ByteArrayContent(buffer);
//            var response = await _client.PutAsync(new Uri($"api/Department/{id}"), byteContent);
//            return response.IsSuccessStatusCode;
//        }

//        public async Task<bool> DeleteItemAsync(string id)
//        {
//            if (string.IsNullOrEmpty(id))
//                return false;
//            var response = await _client.DeleteAsync($"api/Department/{id}");
//            return response.IsSuccessStatusCode;
//        }

//        public async Task<IEnumerable<T>> GetItemsAsync()
//        {
//            var json = await _client.GetStringAsync($"api/Department");
//            return await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<T>>(json));
//        }
//    }
//}
