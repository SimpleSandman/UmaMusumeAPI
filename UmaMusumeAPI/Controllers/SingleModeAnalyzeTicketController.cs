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
    public class SingleModeAnalyzeTicketController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAnalyzeTicketController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAnalyzeTicket
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAnalyzeTicket>>> GetSingleModeAnalyzeTickets()
        {
            return await _context.SingleModeAnalyzeTickets.ToListAsync();
        }

        // GET: api/SingleModeAnalyzeTicket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAnalyzeTicket>> GetSingleModeAnalyzeTicket(int id)
        {
            var singleModeAnalyzeTicket = await _context.SingleModeAnalyzeTickets.FindAsync(id);

            if (singleModeAnalyzeTicket == null)
            {
                return NotFound();
            }

            return singleModeAnalyzeTicket;
        }

        // PUT: api/SingleModeAnalyzeTicket/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeAnalyzeTicket(int id, SingleModeAnalyzeTicket singleModeAnalyzeTicket)
        {
            if (id != singleModeAnalyzeTicket.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeAnalyzeTicket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeAnalyzeTicketExists(id))
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

        // POST: api/SingleModeAnalyzeTicket
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeAnalyzeTicket>> PostSingleModeAnalyzeTicket(SingleModeAnalyzeTicket singleModeAnalyzeTicket)
        {
            _context.SingleModeAnalyzeTickets.Add(singleModeAnalyzeTicket);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeAnalyzeTicketExists(singleModeAnalyzeTicket.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeAnalyzeTicket", new { id = singleModeAnalyzeTicket.Id }, singleModeAnalyzeTicket);
        }

        // DELETE: api/SingleModeAnalyzeTicket/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeAnalyzeTicket(int id)
        {
            var singleModeAnalyzeTicket = await _context.SingleModeAnalyzeTickets.FindAsync(id);
            if (singleModeAnalyzeTicket == null)
            {
                return NotFound();
            }

            _context.SingleModeAnalyzeTickets.Remove(singleModeAnalyzeTicket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeAnalyzeTicketExists(int id)
        {
            return _context.SingleModeAnalyzeTickets.Any(e => e.Id == id);
        }
    }
}
