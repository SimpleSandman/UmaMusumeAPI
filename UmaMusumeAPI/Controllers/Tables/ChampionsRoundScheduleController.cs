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
    public class ChampionsRoundScheduleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsRoundScheduleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsRoundSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsRoundSchedule>>> GetChampionsRoundSchedules()
        {
            return await _context.ChampionsRoundSchedules.ToListAsync();
        }

        // GET: api/ChampionsRoundSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsRoundSchedule>> GetChampionsRoundSchedule(int id)
        {
            var championsRoundSchedule = await _context.ChampionsRoundSchedules.FindAsync(id);

            if (championsRoundSchedule == null)
            {
                return NotFound();
            }

            return championsRoundSchedule;
        }
    }
}
