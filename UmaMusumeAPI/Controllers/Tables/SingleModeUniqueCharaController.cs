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
    public class SingleModeUniqueCharaController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeUniqueCharaController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeUniqueChara
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeUniqueChara>>> GetSingleModeUniqueCharas()
        {
            return await _context.SingleModeUniqueCharas.ToListAsync();
        }

        // GET: api/SingleModeUniqueChara/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeUniqueChara>> GetSingleModeUniqueChara(int id)
        {
            var singleModeUniqueChara = await _context.SingleModeUniqueCharas.FindAsync(id);

            if (singleModeUniqueChara == null)
            {
                return NotFound();
            }

            return singleModeUniqueChara;
        }

        // PUT: api/SingleModeUniqueChara/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeUniqueChara(int id, SingleModeUniqueChara singleModeUniqueChara)
        {
            if (id != singleModeUniqueChara.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeUniqueChara).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeUniqueCharaExists(id))
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

        // POST: api/SingleModeUniqueChara
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeUniqueChara>> PostSingleModeUniqueChara(SingleModeUniqueChara singleModeUniqueChara)
        {
            _context.SingleModeUniqueCharas.Add(singleModeUniqueChara);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeUniqueCharaExists(singleModeUniqueChara.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeUniqueChara", new { id = singleModeUniqueChara.Id }, singleModeUniqueChara);
        }

        // DELETE: api/SingleModeUniqueChara/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeUniqueChara(int id)
        {
            var singleModeUniqueChara = await _context.SingleModeUniqueCharas.FindAsync(id);
            if (singleModeUniqueChara == null)
            {
                return NotFound();
            }

            _context.SingleModeUniqueCharas.Remove(singleModeUniqueChara);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeUniqueCharaExists(int id)
        {
            return _context.SingleModeUniqueCharas.Any(e => e.Id == id);
        }
    }
}
