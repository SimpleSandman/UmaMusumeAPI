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
    public class MetaRController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MetaRController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MetaR
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaR>>> GetMetaR()
        {
            return await _context.MetaRs.ToListAsync();
        }

        // GET: api/MetaR/5
        [HttpGet("{f}")]
        public async Task<ActionResult<IEnumerable<MetaR>>> GetMetaR(int? f)
        {
            var metaR = await _context.MetaRs
                .Where(m => m.F == f)
                .ToListAsync();

            if (metaR == null)
            {
                return NotFound();
            }

            return metaR;
        }
    }
}
