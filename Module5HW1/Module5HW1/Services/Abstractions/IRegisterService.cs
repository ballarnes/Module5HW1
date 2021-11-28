using System.Threading.Tasks;
using Module5HW1.Models;

namespace Module5HW1.Services.Abstractions
{
    public interface IRegisterService
    {
        Task<UserAuthorization> PostRegisterSuccessful();
        Task<UserAuthorization> PostRegisterUnsuccessful();
    }
}