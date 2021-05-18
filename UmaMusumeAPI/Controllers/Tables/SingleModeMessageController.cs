using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleModeMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeMessage>>> GetSingleModeMessages()
        {
            return await _context.SingleModeMessages.ToListAsync();
        }

        // GET: api/SingleModeMessage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeMessage>> GetSingleModeMessage(int id)
        {
            var singleModeMessage = await _context.SingleModeMessages.FindAsync(id);

            if (singleModeMessage == null)
            {
                return NotFound();
            }

            return singleModeMessage;
        }

        // PUT: api/SingleModeMessage/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeMessage(int id, SingleModeMessage singleModeMessage)
        {
            if (id != singleModeMessage.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeMessageExists(id))
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

        // POST: api/SingleModeMessage
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeMessage>> PostSingleModeMessage(SingleModeMessage singleModeMessage)
        {
            _context.SingleModeMessages.Add(singleModeMessage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeMessageExists(singleModeMessage.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeMessage", new { id = singleModeMessage.Id }, singleModeMessage);
        }

        // DELETE: api/SingleModeMessage/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeMessage(int id)
        {
            var singleModeMessage = await _context.SingleModeMessages.FindAsync(id);
            if (singleModeMessage == null)
            {
                return NotFound();
            }

            _context.SingleModeMessages.Remove(singleModeMessage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeMessageExists(int id)
        {
            return _context.SingleModeMessages.Any(e => e.Id == id);
        }
    }
}
