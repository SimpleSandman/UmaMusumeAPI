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
    public class ChampionsScheduleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsScheduleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsSchedule>>> GetChampionsSchedules()
        {
            return await _context.ChampionsSchedules.ToListAsync();
        }

        // GET: api/ChampionsSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsSchedule>> GetChampionsSchedule(int id)
        {
            var championsSchedule = await _context.ChampionsSchedules.FindAsync(id);

            if (championsSchedule == null)
            {
                return NotFound();
            }

            return championsSchedule;
        }
    }
}
