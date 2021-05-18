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
    public class SingleModeTopBgController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTopBgController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTopBg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTopBg>>> GetSingleModeTopBgs()
        {
            return await _context.SingleModeTopBgs.ToListAsync();
        }

        // GET: api/SingleModeTopBg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTopBg>> GetSingleModeTopBg(int id)
        {
            var singleModeTopBg = await _context.SingleModeTopBgs.FindAsync(id);

            if (singleModeTopBg == null)
            {
                return NotFound();
            }

            return singleModeTopBg;
        }
    }
}
