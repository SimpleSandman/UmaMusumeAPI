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
    public class TrainedCharaTradeItemController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainedCharaTradeItemController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainedCharaTradeItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainedCharaTradeItem>>> GetTrainedCharaTradeItems()
        {
            return await _context.TrainedCharaTradeItems.ToListAsync();
        }

        // GET: api/TrainedCharaTradeItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainedCharaTradeItem>> GetTrainedCharaTradeItem(int id)
        {
            var trainedCharaTradeItem = await _context.TrainedCharaTradeItems.FindAsync(id);

            if (trainedCharaTradeItem == null)
            {
                return NotFound();
            }

            return trainedCharaTradeItem;
        }

        // PUT: api/TrainedCharaTradeItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainedCharaTradeItem(int id, TrainedCharaTradeItem trainedCharaTradeItem)
        {
            if (id != trainedCharaTradeItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainedCharaTradeItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainedCharaTradeItemExists(id))
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

        // POST: api/TrainedCharaTradeItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TrainedCharaTradeItem>> PostTrainedCharaTradeItem(TrainedCharaTradeItem trainedCharaTradeItem)
        {
            _context.TrainedCharaTradeItems.Add(trainedCharaTradeItem);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrainedCharaTradeItemExists(trainedCharaTradeItem.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrainedCharaTradeItem", new { id = trainedCharaTradeItem.Id }, trainedCharaTradeItem);
        }

        // DELETE: api/TrainedCharaTradeItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrainedCharaTradeItem(int id)
        {
            var trainedCharaTradeItem = await _context.TrainedCharaTradeItems.FindAsync(id);
            if (trainedCharaTradeItem == null)
            {
                return NotFound();
            }

            _context.TrainedCharaTradeItems.Remove(trainedCharaTradeItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrainedCharaTradeItemExists(int id)
        {
            return _context.TrainedCharaTradeItems.Any(e => e.Id == id);
        }
    }
}
