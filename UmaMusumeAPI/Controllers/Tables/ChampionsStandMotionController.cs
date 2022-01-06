using System.Collections.Generic;
using System.Linq;
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
        [HttpGet("{charaId}")]
        public async Task<ActionResult<IEnumerable<ChampionsStandMotion>>> GetChampionsStandMotion(int charaId)
        {
            var championsStandMotion = await _context.ChampionsStandMotions
                .Where(c => c.CharaId == charaId)
                .ToListAsync();

            if (championsStandMotion == null)
            {
                return NotFound();
            }

            return championsStandMotion;
        }
    }
}
