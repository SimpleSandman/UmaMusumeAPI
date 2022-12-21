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
    public class MetaCController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MetaCController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MetaC
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaC>>> GetMetaC()
        {
            return await _context.MetaCs.ToListAsync();
        }

        // GET: api/MetaC/root
        [HttpGet("{n}")]
        public async Task<ActionResult<MetaC>> GetMetaC(string n)
        {
            var metaC = await _context.MetaCs.FirstAsync(m => m.N == "//" + n);

            if (metaC == null)
            {
                return NotFound();
            }

            return metaC;
        }
    }
}
