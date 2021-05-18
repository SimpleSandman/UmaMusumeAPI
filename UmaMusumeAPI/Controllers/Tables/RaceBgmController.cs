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
    public class RaceBgmController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceBgmController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceBgm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceBgm>>> GetRaceBgms()
        {
            return await _context.RaceBgms.ToListAsync();
        }

        // GET: api/RaceBgm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceBgm>> GetRaceBgm(int id)
        {
            var raceBgm = await _context.RaceBgms.FindAsync(id);

            if (raceBgm == null)
            {
                return NotFound();
            }

            return raceBgm;
        }
    }
}
