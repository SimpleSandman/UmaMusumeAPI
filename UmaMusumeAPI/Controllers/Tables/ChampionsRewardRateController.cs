using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionsRewardRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsRewardRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsRewardRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsRewardRate>>> GetChampionsRewardRates()
        {
            return await _context.ChampionsRewardRates.ToListAsync();
        }

        // GET: api/ChampionsRewardRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsRewardRate>> GetChampionsRewardRate(int id)
        {
            var championsRewardRate = await _context.ChampionsRewardRates.FindAsync(id);

            if (championsRewardRate == null)
            {
                return NotFound();
            }

            return championsRewardRate;
        }
    }
}
