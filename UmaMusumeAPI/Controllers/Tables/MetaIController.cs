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
    public class MetaIController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MetaIController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MetaI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaI>>> GetMetaI()
        {
            return await _context.MetaIs.ToListAsync();
        }

        // GET: api/MetaI/version
        [HttpGet("{k}")]
        public async Task<ActionResult<MetaI>> GetMetaI(string k)
        {
            var metaI = await _context.MetaIs.FirstAsync(m => m.K == k);

            if (metaI == null)
            {
                return NotFound();
            }

            return metaI;
        }
    }
}
