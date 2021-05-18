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
    public class ChampionsBgmController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsBgmController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsBgm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsBgm>>> GetChampionsBgms()
        {
            return await _context.ChampionsBgms.ToListAsync();
        }

        // GET: api/ChampionsBgm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsBgm>> GetChampionsBgm(int id)
        {
            var championsBgm = await _context.ChampionsBgms.FindAsync(id);

            if (championsBgm == null)
            {
                return NotFound();
            }

            return championsBgm;
        }
    }
}
