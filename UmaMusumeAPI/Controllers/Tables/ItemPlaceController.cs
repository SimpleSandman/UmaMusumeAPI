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
    public class ItemPlaceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ItemPlaceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemPlace
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemPlace>>> GetItemPlace()
        {
            return await _context.ItemPlaces.ToListAsync();
        }

        // GET: api/ItemPlace/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ItemPlace>>> GetItemPlace(int id)
        {
            var itemPlace = await _context.ItemPlaces
                .Where(c => c.Id == id)
                .ToListAsync();

            if (itemPlace == null)
            {
                return NotFound();
            }

            return itemPlace;
        }
    }
}
