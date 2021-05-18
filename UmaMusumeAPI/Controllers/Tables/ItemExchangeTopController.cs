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
    public class ItemExchangeTopController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ItemExchangeTopController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemExchangeTop
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemExchangeTop>>> GetItemExchangeTops()
        {
            return await _context.ItemExchangeTops.ToListAsync();
        }

        // GET: api/ItemExchangeTop/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemExchangeTop>> GetItemExchangeTop(int id)
        {
            var itemExchangeTop = await _context.ItemExchangeTops.FindAsync(id);

            if (itemExchangeTop == null)
            {
                return NotFound();
            }

            return itemExchangeTop;
        }
    }
}
