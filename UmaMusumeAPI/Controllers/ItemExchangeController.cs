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

        // PUT: api/ItemExchange/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemExchange(int id, ItemExchange itemExchange)
        {
            if (id != itemExchange.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemExchange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExchangeExists(id))
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

        // POST: api/ItemExchange
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemExchange>> PostItemExchange(ItemExchange itemExchange)
        {
            _context.ItemExchanges.Add(itemExchange);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ItemExchangeExists(itemExchange.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetItemExchange", new { id = itemExchange.Id }, itemExchange);
        }

        // DELETE: api/ItemExchange/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemExchange(int id)
        {
            var itemExchange = await _context.ItemExchanges.FindAsync(id);
            if (itemExchange == null)
            {
                return NotFound();
            }

            _context.ItemExchanges.Remove(itemExchange);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemExchangeExists(int id)
        {
            return _context.ItemExchanges.Any(e => e.Id == id);
        }
    }
}
