using System.Threading.Tasks;
using APP.Domain.Entities;
using APP.Domain.Interfaces;

namespace APP.Domain.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string email);
    }
}
