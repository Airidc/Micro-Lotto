using micro_lotto.Data;
using micro_lotto.Data.Contracts;
using micro_lotto.Data.Entities;
using micro_lotto.Services.DTOService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace micro_lotto.Services
{
    public class DrawService : IDrawService
    {
        private readonly AppDbContext appDbContext;
        private readonly IDTOService dtoService;
        public DrawService(AppDbContext appDbContext, IDTOService dtoService)
        {
            this.appDbContext = appDbContext;
            this.dtoService = dtoService;
        }

        public async Task<DrawDTO> MakeDraw(List<int> selectedNumbers, int userId)
        {
            List<int> drawnBalls = new List<int>();

            while (drawnBalls.Count < 5)
            {
                int ballNumber = RandomNumberGenerator.GetInt32(50);

                if (drawnBalls.Contains(ballNumber) || ballNumber == 0) continue;

                drawnBalls.Add(ballNumber);
            }


            Draw draw = await SaveDrawNumbers(drawnBalls);

            DrawDTO drawDTO = dtoService.DrawToDrawDTO(draw, drawnBalls, selectedNumbers);

            // Check if user won anything and update balance
            if(drawDTO.Winnings != 0)
            {
                User user = await appDbContext.User.FirstOrDefaultAsync(u => u.Id == userId);
                user.Balance += drawDTO.Winnings;
                appDbContext.User.Update(user);
                await appDbContext.SaveChangesAsync();
            }

            return drawDTO;
        }

        public async Task<Draw> SaveDrawNumbers(List<int> numbers)
        {
            try
            {
                Draw draw = new Draw
                {
                    FirstNumber = numbers[0],
                    SecondNumber = numbers[1],
                    ThirdNumber = numbers[2],
                    FourthNumber = numbers[3],
                    FifthNumber = numbers[4],
                    ISOTime = DateTime.UtcNow.ToString(),
                };

                appDbContext.Draw.Add(draw);
                await appDbContext.SaveChangesAsync();
                await appDbContext.Entry(draw).GetDatabaseValuesAsync();
                return draw;
            }
            catch (Exception ex)
            {
                // Should log exception to db
                throw ex;
            }
        }
    }
}
