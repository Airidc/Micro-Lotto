using micro_lotto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace micro_lotto.Data.Contracts
{
    public interface IBetService
    {
        Task<List<Bet>> GetAllBetsByUserId(int id);
        Task SaveBet(BetDTO bet);
    }
}
