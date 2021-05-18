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

        // PUT: api/ItemPack/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemPack(int id, ItemPack itemPack)
        {
            if (id != itemPack.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemPack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemPackExists(id))
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

        // POST: api/ItemPack
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemPack>> PostItemPack(ItemPack itemPack)
        {
            _context.ItemPacks.Add(itemPack);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ItemPackExists(itemPack.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetItemPack", new { id = itemPack.Id }, itemPack);
        }

        // DELETE: api/ItemPack/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemPack(int id)
        {
            var itemPack = await _context.ItemPacks.FindAsync(id);
            if (itemPack == null)
            {
                return NotFound();
            }

            _context.ItemPacks.Remove(itemPack);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemPackExists(int id)
        {
            return _context.ItemPacks.Any(e => e.Id == id);
        }
    }
}
