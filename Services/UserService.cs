using micro_lotto.Data;
using micro_lotto.Data.Contracts;
using micro_lotto.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace micro_lotto.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext appDbContext;

        public UserService(AppDbContext appDbContext)
        {
            try
            {
                this.appDbContext = appDbContext;
            }
            catch (Exception ex)
            {
                // Should log exception to db
                throw ex;
            }
        }

        public async Task<User> GetUserById()
        {
            try
            {
                return await appDbContext.User.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                // Should log exception to db
                throw ex;
            }
        }
    }
}
