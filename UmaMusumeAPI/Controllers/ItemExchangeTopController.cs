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

        // PUT: api/ItemExchangeTop/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemExchangeTop(int id, ItemExchangeTop itemExchangeTop)
        {
            if (id != itemExchangeTop.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemExchangeTop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExchangeTopExists(id))
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

        // POST: api/ItemExchangeTop
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemExchangeTop>> PostItemExchangeTop(ItemExchangeTop itemExchangeTop)
        {
            _context.ItemExchangeTops.Add(itemExchangeTop);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ItemExchangeTopExists(itemExchangeTop.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetItemExchangeTop", new { id = itemExchangeTop.Id }, itemExchangeTop);
        }

        // DELETE: api/ItemExchangeTop/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemExchangeTop(int id)
        {
            var itemExchangeTop = await _context.ItemExchangeTops.FindAsync(id);
            if (itemExchangeTop == null)
            {
                return NotFound();
            }

            _context.ItemExchangeTops.Remove(itemExchangeTop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemExchangeTopExists(int id)
        {
            return _context.ItemExchangeTops.Any(e => e.Id == id);
        }
    }
}
