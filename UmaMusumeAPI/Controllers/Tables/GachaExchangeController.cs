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
    public class GachaExchangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaExchangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaExchange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaExchange>>> GetGachaExchanges()
        {
            return await _context.GachaExchanges.ToListAsync();
        }

        // GET: api/GachaExchange/5
        [HttpGet("{gachaId}")]
        public async Task<ActionResult<IEnumerable<GachaExchange>>> GetGachaExchange(int gachaId)
        {
            var gachaExchange = await _context.GachaExchanges
                .Where(c => c.GachaId == gachaId)
                .ToListAsync();

            if (gachaExchange == null)
            {
                return NotFound();
            }

            return gachaExchange;
        }
    }
}
