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
    public class RaceBgmCutinExtensionTimeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceBgmCutinExtensionTimeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceBgmCutinExtensionTime
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceBgmCutinExtensionTime>>> GetRaceBgmCutinExtensionTimes()
        {
            return await _context.RaceBgmCutinExtensionTimes.ToListAsync();
        }

        // GET: api/RaceBgmCutinExtensionTime/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceBgmCutinExtensionTime>> GetRaceBgmCutinExtensionTime(int id)
        {
            var raceBgmCutinExtensionTime = await _context.RaceBgmCutinExtensionTimes.FindAsync(id);

            if (raceBgmCutinExtensionTime == null)
            {
                return NotFound();
            }

            return raceBgmCutinExtensionTime;
        }
    }
}
