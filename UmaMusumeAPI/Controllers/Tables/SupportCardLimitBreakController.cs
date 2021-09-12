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
    public class SupportCardLimitBreakController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardLimitBreakController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardLimitBreak
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardLimitBreak>>> GetSupportCardLimitBreaks()
        {
            return await _context.SupportCardLimitBreaks.ToListAsync();
        }

        // GET: api/SupportCardLimitBreak/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardLimitBreak>> GetSupportCardLimitBreak(int id)
        {
            var supportCardLimitBreak = await _context.SupportCardLimitBreaks.FindAsync(id);

            if (supportCardLimitBreak == null)
            {
                return NotFound();
            }

            return supportCardLimitBreak;
        }
    }
}
