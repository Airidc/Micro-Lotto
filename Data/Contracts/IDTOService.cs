using micro_lotto.Data.Entities;
using micro_lotto.Services.DTOService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace micro_lotto.Data.Contracts
{
    public interface IDTOService
    {
        public Task<Bet> BetDTOtoBet(BetDTO betDTO);
        public DrawDTO DrawToDrawDTO(Draw draw, List<int> drawnBalls, List<int> selectedNumbers);
    }
}
