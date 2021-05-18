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
    public class SingleModeScenarioController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeScenarioController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeScenario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeScenario>>> GetSingleModeScenarios()
        {
            return await _context.SingleModeScenarios.ToListAsync();
        }

        // GET: api/SingleModeScenario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeScenario>> GetSingleModeScenario(int id)
        {
            var singleModeScenario = await _context.SingleModeScenarios.FindAsync(id);

            if (singleModeScenario == null)
            {
                return NotFound();
            }

            return singleModeScenario;
        }

        // PUT: api/SingleModeScenario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeScenario(int id, SingleModeScenario singleModeScenario)
        {
            if (id != singleModeScenario.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeScenario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeScenarioExists(id))
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

        // POST: api/SingleModeScenario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeScenario>> PostSingleModeScenario(SingleModeScenario singleModeScenario)
        {
            _context.SingleModeScenarios.Add(singleModeScenario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeScenarioExists(singleModeScenario.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeScenario", new { id = singleModeScenario.Id }, singleModeScenario);
        }

        // DELETE: api/SingleModeScenario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeScenario(int id)
        {
            var singleModeScenario = await _context.SingleModeScenarios.FindAsync(id);
            if (singleModeScenario == null)
            {
                return NotFound();
            }

            _context.SingleModeScenarios.Remove(singleModeScenario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeScenarioExists(int id)
        {
            return _context.SingleModeScenarios.Any(e => e.Id == id);
        }
    }
}
