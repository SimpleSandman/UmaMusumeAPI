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
    public class RaceEnvDefineController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceEnvDefineController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceEnvDefine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceEnvDefine>>> GetRaceEnvDefines()
        {
            return await _context.RaceEnvDefines.ToListAsync();
        }

        // GET: api/RaceEnvDefine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceEnvDefine>> GetRaceEnvDefine(int id)
        {
            var raceEnvDefine = await _context.RaceEnvDefines.FindAsync(id);

            if (raceEnvDefine == null)
            {
                return NotFound();
            }

            return raceEnvDefine;
        }
    }
}
