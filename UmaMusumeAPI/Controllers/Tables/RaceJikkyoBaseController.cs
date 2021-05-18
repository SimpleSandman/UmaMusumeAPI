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
    public class RaceJikkyoBaseController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoBaseController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoBase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoBase>>> GetRaceJikkyoBases()
        {
            return await _context.RaceJikkyoBases.ToListAsync();
        }

        // GET: api/RaceJikkyoBase/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoBase>> GetRaceJikkyoBase(int id)
        {
            var raceJikkyoBase = await _context.RaceJikkyoBases.FindAsync(id);

            if (raceJikkyoBase == null)
            {
                return NotFound();
            }

            return raceJikkyoBase;
        }
    }
}
