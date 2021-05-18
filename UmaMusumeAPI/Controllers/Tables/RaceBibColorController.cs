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
    public class RaceBibColorController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceBibColorController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceBibColor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceBibColor>>> GetRaceBibColors()
        {
            return await _context.RaceBibColors.ToListAsync();
        }

        // GET: api/RaceBibColor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceBibColor>> GetRaceBibColor(int id)
        {
            var raceBibColor = await _context.RaceBibColors.FindAsync(id);

            if (raceBibColor == null)
            {
                return NotFound();
            }

            return raceBibColor;
        }
    }
}
