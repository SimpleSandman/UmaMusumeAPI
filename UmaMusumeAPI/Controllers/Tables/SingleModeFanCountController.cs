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
    public class SingleModeFanCountController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeFanCountController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeFanCount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeFanCount>>> GetSingleModeFanCounts()
        {
            return await _context.SingleModeFanCounts.ToListAsync();
        }

        // GET: api/SingleModeFanCount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeFanCount>> GetSingleModeFanCount(int id)
        {
            var singleModeFanCount = await _context.SingleModeFanCounts.FindAsync(id);

            if (singleModeFanCount == null)
            {
                return NotFound();
            }

            return singleModeFanCount;
        }
    }
}
