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
    public class RaceTrophyController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceTrophyController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceTrophy
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceTrophy>>> GetRaceTrophies()
        {
            return await _context.RaceTrophies.ToListAsync();
        }

        // GET: api/RaceTrophy/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceTrophy>> GetRaceTrophy(int id)
        {
            var raceTrophy = await _context.RaceTrophies.FindAsync(id);

            if (raceTrophy == null)
            {
                return NotFound();
            }

            return raceTrophy;
        }
    }
}
