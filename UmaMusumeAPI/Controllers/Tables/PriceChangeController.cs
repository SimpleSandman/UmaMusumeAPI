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
    public class PriceChangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public PriceChangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/PriceChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PriceChange>>> GetPriceChanges()
        {
            return await _context.PriceChanges.ToListAsync();
        }

        // GET: api/PriceChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PriceChange>> GetPriceChange(int id)
        {
            var priceChange = await _context.PriceChanges.FindAsync(id);

            if (priceChange == null)
            {
                return NotFound();
            }

            return priceChange;
        }
    }
}
