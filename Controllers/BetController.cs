using micro_lotto.Data.Contracts;
using micro_lotto.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace micro_lotto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        private readonly IBetService betService;
        public BetController(IBetService betService)
        {
            this.betService = betService;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<List<Bet>>> GetAllBetsByUserId(int userId)
        {
            try
            {
                return await betService.GetAllBetsByUserId(userId);
            }
            catch (Exception)
            {
                return StatusCode(500, "Unable to save bet");
            }
        }

        [HttpPost("save")]
        public async Task<ActionResult> SaveBet([FromBody] BetDTO betDTO)
        {
            try
            {
                await betService.SaveBet(betDTO);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "Unable to save bet");
            }
        }
    }
}