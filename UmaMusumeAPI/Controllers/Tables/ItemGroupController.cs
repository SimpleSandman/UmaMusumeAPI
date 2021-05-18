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
    public class ItemGroupController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ItemGroupController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemGroup>>> GetItemGroups()
        {
            return await _context.ItemGroups.ToListAsync();
        }

        // GET: api/ItemGroup/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemGroup>> GetItemGroup(int id)
        {
            var itemGroup = await _context.ItemGroups.FindAsync(id);

            if (itemGroup == null)
            {
                return NotFound();
            }

            return itemGroup;
        }
    }
}
