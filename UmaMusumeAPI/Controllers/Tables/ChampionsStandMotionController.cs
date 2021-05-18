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
    public class ChampionsStandMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsStandMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsStandMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsStandMotion>>> GetChampionsStandMotions()
        {
            return await _context.ChampionsStandMotions.ToListAsync();
        }

        // GET: api/ChampionsStandMotion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsStandMotion>> GetChampionsStandMotion(int id)
        {
            var championsStandMotion = await _context.ChampionsStandMotions.FindAsync(id);

            if (championsStandMotion == null)
            {
                return NotFound();
            }

            return championsStandMotion;
        }
    }
}
