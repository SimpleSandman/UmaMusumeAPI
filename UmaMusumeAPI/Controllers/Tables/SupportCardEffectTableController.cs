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
    public class SupportCardEffectTableController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardEffectTableController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardEffectTable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardEffectTable>>> GetSupportCardEffectTables()
        {
            return await _context.SupportCardEffectTables.ToListAsync();
        }

        // GET: api/SupportCardEffectTable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<SupportCardEffectTable>>> GetSupportCardEffectTable(int id)
        {
            var supportCardEffectTable = await _context.SupportCardEffectTables
                .Where(c => c.Id == id)
                .ToListAsync();

            if (supportCardEffectTable == null)
            {
                return NotFound();
            }

            return supportCardEffectTable;
        }
    }
}
