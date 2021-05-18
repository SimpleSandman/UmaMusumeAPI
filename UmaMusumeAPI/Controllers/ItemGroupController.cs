using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers
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

        // PUT: api/ItemGroup/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemGroup(int id, ItemGroup itemGroup)
        {
            if (id != itemGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemGroupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ItemGroup
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemGroup>> PostItemGroup(ItemGroup itemGroup)
        {
            _context.ItemGroups.Add(itemGroup);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ItemGroupExists(itemGroup.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetItemGroup", new { id = itemGroup.Id }, itemGroup);
        }

        // DELETE: api/ItemGroup/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemGroup(int id)
        {
            var itemGroup = await _context.ItemGroups.FindAsync(id);
            if (itemGroup == null)
            {
                return NotFound();
            }

            _context.ItemGroups.Remove(itemGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemGroupExists(int id)
        {
            return _context.ItemGroups.Any(e => e.Id == id);
        }
    }
}
