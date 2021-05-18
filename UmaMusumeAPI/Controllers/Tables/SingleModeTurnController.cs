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
    public class SingleModeTurnController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTurnController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTurn
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTurn>>> GetSingleModeTurns()
        {
            return await _context.SingleModeTurns.ToListAsync();
        }

        // GET: api/SingleModeTurn/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTurn>> GetSingleModeTurn(int id)
        {
            var singleModeTurn = await _context.SingleModeTurns.FindAsync(id);

            if (singleModeTurn == null)
            {
                return NotFound();
            }

            return singleModeTurn;
        }
    }
}
