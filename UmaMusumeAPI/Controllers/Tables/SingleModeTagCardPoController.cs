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
    public class SingleModeTagCardPoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTagCardPoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTagCardPo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTagCardPo>>> GetSingleModeTagCardPos()
        {
            return await _context.SingleModeTagCardPos.ToListAsync();
        }

        // GET: api/SingleModeTagCardPo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTagCardPo>> GetSingleModeTagCardPo(int id)
        {
            var singleModeTagCardPo = await _context.SingleModeTagCardPos.FindAsync(id);

            if (singleModeTagCardPo == null)
            {
                return NotFound();
            }

            return singleModeTagCardPo;
        }

        // PUT: api/SingleModeTagCardPo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeTagCardPo(int id, SingleModeTagCardPo singleModeTagCardPo)
        {
            if (id != singleModeTagCardPo.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeTagCardPo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeTagCardPoExists(id))
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

        // POST: api/SingleModeTagCardPo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeTagCardPo>> PostSingleModeTagCardPo(SingleModeTagCardPo singleModeTagCardPo)
        {
            _context.SingleModeTagCardPos.Add(singleModeTagCardPo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeTagCardPoExists(singleModeTagCardPo.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeTagCardPo", new { id = singleModeTagCardPo.Id }, singleModeTagCardPo);
        }

        // DELETE: api/SingleModeTagCardPo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeTagCardPo(int id)
        {
            var singleModeTagCardPo = await _context.SingleModeTagCardPos.FindAsync(id);
            if (singleModeTagCardPo == null)
            {
                return NotFound();
            }

            _context.SingleModeTagCardPos.Remove(singleModeTagCardPo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeTagCardPoExists(int id)
        {
            return _context.SingleModeTagCardPos.Any(e => e.Id == id);
        }
    }
}
