using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalCap.Services
{
    /** The ICloudTable interface is a database CRUD interface into table. 
      * It does this asynchronously
     * */

    public interface ICloudTable<T>
    {
        Task<bool> CreateItemAsync(T item);
        Task<bool> UpdateItemAsync(int id, T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> ReadItemAsync(string id);
        

        //This returns the collection of all the items
        Task<IEnumerable<T>> GetItemsAsync();
    }
}