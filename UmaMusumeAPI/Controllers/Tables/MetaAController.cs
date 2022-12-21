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
    public class MetaAController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MetaAController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MetaA
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetaA>>> GetMetaA()
        {
            return await _context.MetaAs.ToListAsync();
        }

        // GET: api/MetaA/5
        [HttpGet("{i}")]
        public async Task<ActionResult<MetaA>> GetMetaA(int i)
        {
            var metaA = await _context.MetaAs.FindAsync(i);

            if (metaA == null)
            {
                return NotFound();
            }

            return metaA;
        }
    }
}
