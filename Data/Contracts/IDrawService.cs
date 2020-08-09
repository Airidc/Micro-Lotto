using micro_lotto.Data.Entities;
using micro_lotto.Services.DTOService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace micro_lotto.Data.Contracts
{
    public interface IDrawService
    {
        Task<Draw> SaveDrawNumbers(List<int> numbers);
        Task<DrawDTO> MakeDraw(List<int> selectedNumbers, int userId);
    }
}
