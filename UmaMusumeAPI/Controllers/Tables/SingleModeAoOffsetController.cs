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
    public class SingleModeAoOffsetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAoOffsetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAoOffset
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAoOffset>>> GetSingleModeAoOffsets()
        {
            return await _context.SingleModeAoOffsets.ToListAsync();
        }

        // GET: api/SingleModeAoOffset/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAoOffset>> GetSingleModeAoOffset(int id)
        {
            var singleModeAoOffset = await _context.SingleModeAoOffsets.FindAsync(id);

            if (singleModeAoOffset == null)
            {
                return NotFound();
            }

            return singleModeAoOffset;
        }
    }
}
