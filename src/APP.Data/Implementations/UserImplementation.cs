using System.Threading.Tasks;
using APP.Data.Context;
using APP.Data.Repository;
using APP.Domain.Entities;
using APP.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace APP.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;
        public UserImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<UserEntity>();
        }
        public async Task<UserEntity> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(
                u => u.Email.Equals(email)
            );
        }
    }
}
