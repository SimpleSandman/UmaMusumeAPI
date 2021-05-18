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
    public class SingleModeRivalController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRivalController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRival
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRival>>> GetSingleModeRivals()
        {
            return await _context.SingleModeRivals.ToListAsync();
        }

        // GET: api/SingleModeRival/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRival>> GetSingleModeRival(int id)
        {
            var singleModeRival = await _context.SingleModeRivals.FindAsync(id);

            if (singleModeRival == null)
            {
                return NotFound();
            }

            return singleModeRival;
        }
    }
}
