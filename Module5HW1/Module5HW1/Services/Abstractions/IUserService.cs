using System.Collections.Generic;
using System.Threading.Tasks;
using Module5HW1.Models;

namespace Module5HW1.Services.Abstractions
{
    public interface IUserService
    {
        Task<User> Delete();
        Task<List<User>> GetDelayedResponse();
        Task<List<User>> GetListUsers();
        Task<User> GetSingleUser();
        Task<User> GetSingleUserNotFound();
        Task<User> PatchUpdate();
        Task<User> PostCreate();
        Task<User> PutUpdate();
    }
}