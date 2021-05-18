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
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaExchange>> GetGachaExchange(int id)
        {
            var gachaExchange = await _context.GachaExchanges.FindAsync(id);

            if (gachaExchange == null)
            {
                return NotFound();
            }

            return gachaExchange;
        }
    }
}
