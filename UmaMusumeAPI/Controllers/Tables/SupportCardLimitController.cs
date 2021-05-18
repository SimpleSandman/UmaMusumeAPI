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
    public class SupportCardLimitController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardLimitController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardLimit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardLimit>>> GetSupportCardLimits()
        {
            return await _context.SupportCardLimits.ToListAsync();
        }

        // GET: api/SupportCardLimit/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardLimit>> GetSupportCardLimit(int id)
        {
            var supportCardLimit = await _context.SupportCardLimits.FindAsync(id);

            if (supportCardLimit == null)
            {
                return NotFound();
            }

            return supportCardLimit;
        }
    }
}
