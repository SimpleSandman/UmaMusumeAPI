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
    public class SingleModeRouteRaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRouteRaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRouteRace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRouteRace>>> GetSingleModeRouteRaces()
        {
            return await _context.SingleModeRouteRaces.ToListAsync();
        }

        // GET: api/SingleModeRouteRace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRouteRace>> GetSingleModeRouteRace(int id)
        {
            var singleModeRouteRace = await _context.SingleModeRouteRaces.FindAsync(id);

            if (singleModeRouteRace == null)
            {
                return NotFound();
            }

            return singleModeRouteRace;
        }
    }
}
