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
    public class ItemExchangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ItemExchangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemExchange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemExchange>>> GetItemExchanges()
        {
            return await _context.ItemExchanges.ToListAsync();
        }

        // GET: api/ItemExchange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemExchange>> GetItemExchange(int id)
        {
            var itemExchange = await _context.ItemExchanges.FindAsync(id);

            if (itemExchange == null)
            {
                return NotFound();
            }

            return itemExchange;
        }
    }
}
