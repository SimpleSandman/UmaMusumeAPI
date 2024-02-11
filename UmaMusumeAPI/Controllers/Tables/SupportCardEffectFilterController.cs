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
    public class SupportCardEffectFilterController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardEffectFilterController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardEffectFilter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardEffectFilter>>> GetSupportCardEffectFilters()
        {
            return await _context.SupportCardEffectFilters.ToListAsync();
        }

        // GET: api/SupportCardEffectFilter/5
        [HttpGet("{type}")]
        public async Task<ActionResult<SupportCardEffectFilter>> GetSupportCardEffectFilter(int type)
        {
            var supportCardEffectFilter = await _context.SupportCardEffectFilters.FindAsync(type);

            if (supportCardEffectFilter == null)
            {
                return NotFound();
            }

            return supportCardEffectFilter;
        }
    }
}
