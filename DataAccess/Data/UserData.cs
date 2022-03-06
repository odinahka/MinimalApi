using DataAccess.Data.Contracts;
using DataAccess.DbAccess.Contracts;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }
    public Task<IEnumerable<UserModel>> GetUsersAsync() => _db.LoadDataAsync<UserModel, dynamic>("dbo.spUser.GetAll", new { });

    public async Task<UserModel?> GetUserAsync(int id)
    {
        var results = await _db.LoadDataAsync<UserModel, dynamic>("dbo.spUser_Get", new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertUserAsync(UserModel user) => _db.SaveDataAsync("dbo.spUser_Insert", new { user.FirstName, user.LastName });

    public Task UpdateUserAsync(UserModel user) => _db.SaveDataAsync("dbo.spUser_Update", user);

    public Task DeleteUserAsync(int id) => _db.SaveDataAsync("dbo.spUser_Delete", new { Id = id });

}
