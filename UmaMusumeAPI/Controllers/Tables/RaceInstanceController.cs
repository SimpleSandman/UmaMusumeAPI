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
    public class RaceInstanceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceInstanceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceInstance
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceInstance>>> GetRaceInstances()
        {
            return await _context.RaceInstances.ToListAsync();
        }

        // GET: api/RaceInstance/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceInstance>> GetRaceInstance(int id)
        {
            var raceInstance = await _context.RaceInstances.FindAsync(id);

            if (raceInstance == null)
            {
                return NotFound();
            }

            return raceInstance;
        }
    }
}
