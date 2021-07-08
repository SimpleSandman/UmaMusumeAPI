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
    public class MainStoryRaceBonusController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryRaceBonusController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryRaceBonus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryRaceBonus>>> GetMainStoryRaceBonus()
        {
            return await _context.MainStoryRaceBonus.ToListAsync();
        }

        // GET: api/MainStoryRaceBonus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryRaceBonus>> GetMainStoryRaceBonus(int id)
        {
            var mainStoryRaceBonus = await _context.MainStoryRaceBonus.FindAsync(id);

            if (mainStoryRaceBonus == null)
            {
                return NotFound();
            }

            return mainStoryRaceBonus;
        }
    }
}
