using micro_lotto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace micro_lotto.Services.DTOService.Models
{
    public class DrawDTO
    {
        public Draw DrawnBalls { get; set; }
        public int Winnings { get; set; }
    }
}
