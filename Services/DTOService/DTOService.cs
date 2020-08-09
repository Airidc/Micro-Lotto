using micro_lotto.Data;
using micro_lotto.Data.Contracts;
using micro_lotto.Data.Entities;
using micro_lotto.Services.DTOService.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace micro_lotto.Services.DTOService
{
    public class DTOService : IDTOService
    {
        private readonly AppDbContext appDbContext;
        public DTOService(AppDbContext appDbContext)
        { 
            this.appDbContext = appDbContext;
        }
        public async Task<Bet> BetDTOtoBet(BetDTO betDTO)
        {
            User user = await appDbContext.User.FirstOrDefaultAsync(usr => usr.Id == betDTO.UserId);
            Bet bet = new Bet
            {
                ISOTime = betDTO.ISOTime,
                FirstNumber = betDTO.FirstNumber,
                SecondNumber = betDTO.SecondNumber,
                ThirdNumber = betDTO.ThirdNumber,
                FourthNumber = betDTO.FourthNumber,
                FifthNumber = betDTO.FifthNumber,
                User = user
            };

            return bet;
        }

        public DrawDTO DrawToDrawDTO(Draw draw, List<int> drawnBalls, List<int> selectedNumbers)
        {
            // For simplicity of the task, the winnings are hardcoded
            // And winning definately should not be calculated in DTO
            Dictionary<int, int> winningsTable = new Dictionary<int, int>
            {
                [0] = 0,
                [1] = 0,
                [2] = 2,
                [3] = 100,
                [4] = 1000,
                [5] = 1000000,
             };

            int matchingNumbers = drawnBalls.FindAll(ball => selectedNumbers.Contains(ball)).Count;
            return new DrawDTO
            {
                DrawnBalls = draw,
                Winnings = winningsTable[matchingNumbers],
            };
        }
    }
}
