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
    public class CharaMotionActController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaMotionActController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaMotionAct
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaMotionAct>>> GetCharaMotionActs()
        {
            return await _context.CharaMotionActs.ToListAsync();
        }

        // GET: api/CharaMotionAct/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaMotionAct>> GetCharaMotionAct(int id)
        {
            var charaMotionAct = await _context.CharaMotionActs.FindAsync(id);

            if (charaMotionAct == null)
            {
                return NotFound();
            }

            return charaMotionAct;
        }

        // PUT: api/CharaMotionAct/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharaMotionAct(int id, CharaMotionAct charaMotionAct)
        {
            if (id != charaMotionAct.Id)
            {
                return BadRequest();
            }

            _context.Entry(charaMotionAct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharaMotionActExists(id))
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

        // POST: api/CharaMotionAct
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharaMotionAct>> PostCharaMotionAct(CharaMotionAct charaMotionAct)
        {
            _context.CharaMotionActs.Add(charaMotionAct);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharaMotionActExists(charaMotionAct.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharaMotionAct", new { id = charaMotionAct.Id }, charaMotionAct);
        }

        // DELETE: api/CharaMotionAct/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharaMotionAct(int id)
        {
            var charaMotionAct = await _context.CharaMotionActs.FindAsync(id);
            if (charaMotionAct == null)
            {
                return NotFound();
            }

            _context.CharaMotionActs.Remove(charaMotionAct);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharaMotionActExists(int id)
        {
            return _context.CharaMotionActs.Any(e => e.Id == id);
        }
    }
}
