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
    public class ItemPackController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ItemPackController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemPack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemPack>>> GetItemPacks()
        {
            return await _context.ItemPacks.ToListAsync();
        }

        // GET: api/ItemPack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemPack>> GetItemPack(int id)
        {
            var itemPack = await _context.ItemPacks.FindAsync(id);

            if (itemPack == null)
            {
                return NotFound();
            }

            return itemPack;
        }
    }
}
