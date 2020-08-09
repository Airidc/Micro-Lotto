using micro_lotto.Data.Contracts;
using micro_lotto.Data.Entities;
using micro_lotto.Services.DTOService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace micro_lotto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawController : ControllerBase
    {
        private readonly IDrawService drawService;
        public DrawController(IDrawService drawService)
        {
            this.drawService = drawService;
        }

        [HttpPost]
        public async Task<ActionResult<DrawDTO>> DrawBalls([FromBody]List<int> selectedNumbers, [FromQuery(Name = "userId")] int userId)
        {
            try
            {
                return await drawService.MakeDraw(selectedNumbers, userId);
            }
            catch (Exception)
            {
                return StatusCode(500, "Unable make a draw");
            }
        }
    }
}