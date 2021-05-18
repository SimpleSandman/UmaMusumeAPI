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
    public class SingleModeOutingSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeOutingSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeOutingSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeOutingSet>>> GetSingleModeOutingSets()
        {
            return await _context.SingleModeOutingSets.ToListAsync();
        }

        // GET: api/SingleModeOutingSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeOutingSet>> GetSingleModeOutingSet(int id)
        {
            var singleModeOutingSet = await _context.SingleModeOutingSets.FindAsync(id);

            if (singleModeOutingSet == null)
            {
                return NotFound();
            }

            return singleModeOutingSet;
        }
    }
}
