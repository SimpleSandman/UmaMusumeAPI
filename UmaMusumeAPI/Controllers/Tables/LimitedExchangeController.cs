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
    public class LimitedExchangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LimitedExchangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LimitedExchange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LimitedExchange>>> GetLimitedExchanges()
        {
            return await _context.LimitedExchanges.ToListAsync();
        }

        // GET: api/LimitedExchange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LimitedExchange>> GetLimitedExchange(int id)
        {
            var limitedExchange = await _context.LimitedExchanges.FindAsync(id);

            if (limitedExchange == null)
            {
                return NotFound();
            }

            return limitedExchange;
        }
    }
}
