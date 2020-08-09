using micro_lotto.Data;
using micro_lotto.Data.Contracts;
using micro_lotto.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace micro_lotto.Services
{
    public class BetService : IBetService
    {
        private readonly AppDbContext appDbContext;
        private readonly IDTOService dtoService;
        public BetService(AppDbContext appDbContext, IDTOService dtoService)
        {
            this.appDbContext = appDbContext;
            this.dtoService = dtoService;
        }
        public async Task<List<Bet>> GetAllBetsByUserId(int id)
        {
            try
            {
                return await appDbContext.Bet.Where(bet => bet.User.Id == id).ToListAsync();
            }
            catch (Exception ex)
            {
                // Should log exception to db
                throw ex;
            }
        }

        public async Task SaveBet(BetDTO betDTO)
        {
            try
            {
                Bet bet = await dtoService.BetDTOtoBet(betDTO);
                User user = await appDbContext.User.FirstOrDefaultAsync(u => u.Id == betDTO.UserId);
                user.Balance -= 2; // In reality should not be hardcoded.
                appDbContext.User.Update(user);
                await appDbContext.Bet.AddAsync(bet);
                await appDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Should log exception to db
                throw ex;
            }
        }
    }
}
