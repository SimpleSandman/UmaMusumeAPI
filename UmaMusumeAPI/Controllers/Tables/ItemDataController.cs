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
    public class ItemDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ItemDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemData>>> GetItemData()
        {
            return await _context.ItemData.ToListAsync();
        }

        // GET: api/ItemData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemData>> GetItemData(int id)
        {
            var itemData = await _context.ItemData.FindAsync(id);

            if (itemData == null)
            {
                return NotFound();
            }

            return itemData;
        }
    }
}
