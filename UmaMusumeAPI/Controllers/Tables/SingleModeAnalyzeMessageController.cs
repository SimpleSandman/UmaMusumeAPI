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
    public class SingleModeAnalyzeMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAnalyzeMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAnalyzeMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAnalyzeMessage>>> GetSingleModeAnalyzeMessages()
        {
            return await _context.SingleModeAnalyzeMessages.ToListAsync();
        }

        // GET: api/SingleModeAnalyzeMessage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAnalyzeMessage>> GetSingleModeAnalyzeMessage(int id)
        {
            var singleModeAnalyzeMessage = await _context.SingleModeAnalyzeMessages.FindAsync(id);

            if (singleModeAnalyzeMessage == null)
            {
                return NotFound();
            }

            return singleModeAnalyzeMessage;
        }

        // PUT: api/SingleModeAnalyzeMessage/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeAnalyzeMessage(int id, SingleModeAnalyzeMessage singleModeAnalyzeMessage)
        {
            if (id != singleModeAnalyzeMessage.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeAnalyzeMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeAnalyzeMessageExists(id))
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

        // POST: api/SingleModeAnalyzeMessage
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeAnalyzeMessage>> PostSingleModeAnalyzeMessage(SingleModeAnalyzeMessage singleModeAnalyzeMessage)
        {
            _context.SingleModeAnalyzeMessages.Add(singleModeAnalyzeMessage);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeAnalyzeMessageExists(singleModeAnalyzeMessage.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeAnalyzeMessage", new { id = singleModeAnalyzeMessage.Id }, singleModeAnalyzeMessage);
        }

        // DELETE: api/SingleModeAnalyzeMessage/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeAnalyzeMessage(int id)
        {
            var singleModeAnalyzeMessage = await _context.SingleModeAnalyzeMessages.FindAsync(id);
            if (singleModeAnalyzeMessage == null)
            {
                return NotFound();
            }

            _context.SingleModeAnalyzeMessages.Remove(singleModeAnalyzeMessage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeAnalyzeMessageExists(int id)
        {
            return _context.SingleModeAnalyzeMessages.Any(e => e.Id == id);
        }
    }
}
