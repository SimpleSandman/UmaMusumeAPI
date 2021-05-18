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
    public class DailyRaceNpcController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DailyRaceNpcController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DailyRaceNpc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyRaceNpc>>> GetDailyRaceNpcs()
        {
            return await _context.DailyRaceNpcs.ToListAsync();
        }

        // GET: api/DailyRaceNpc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyRaceNpc>> GetDailyRaceNpc(int id)
        {
            var dailyRaceNpc = await _context.DailyRaceNpcs.FindAsync(id);

            if (dailyRaceNpc == null)
            {
                return NotFound();
            }

            return dailyRaceNpc;
        }
    }
}
