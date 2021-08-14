using System.Threading.Tasks;
using APP.Domain.Dtos;

namespace APP.Service.Services
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
