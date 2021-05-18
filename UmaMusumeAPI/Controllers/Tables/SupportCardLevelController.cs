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
    public class SupportCardLevelController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardLevelController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardLevel
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardLevel>>> GetSupportCardLevels()
        {
            return await _context.SupportCardLevels.ToListAsync();
        }

        // GET: api/SupportCardLevel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardLevel>> GetSupportCardLevel(int id)
        {
            var supportCardLevel = await _context.SupportCardLevels.FindAsync(id);

            if (supportCardLevel == null)
            {
                return NotFound();
            }

            return supportCardLevel;
        }
    }
}
