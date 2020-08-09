using micro_lotto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace micro_lotto.Data.Contracts
{
    public interface IUserService
    {
        Task<User> GetUserById();
    }
}
