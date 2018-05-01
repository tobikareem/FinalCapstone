

namespace FinalCap.Services
{
    //This interface is used for initializing the connection to the MVC and getting a table definition
    public interface ICloudService
    {
        //The ICloudTable is a database CRUD interface 
        ICloudTable<T> GetTable<T>();
    }
}
