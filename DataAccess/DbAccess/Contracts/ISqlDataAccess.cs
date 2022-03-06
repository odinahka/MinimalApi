
namespace DataAccess.DbAccess.Contracts;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
    Task SaveDataAsync<T>(string storedProcedure, T parameter, string connectionId = "Default");
}