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
    public class CharaTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaType>>> GetCharaTypes()
        {
            return await _context.CharaTypes.ToListAsync();
        }

        // GET: api/CharaType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaType>> GetCharaType(string id)
        {
            var charaType = await _context.CharaTypes.FindAsync(id);

            if (charaType == null)
            {
                return NotFound();
            }

            return charaType;
        }

        // PUT: api/CharaType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharaType(string id, CharaType charaType)
        {
            if (id != charaType.Id)
            {
                return BadRequest();
            }

            _context.Entry(charaType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharaTypeExists(id))
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

        // POST: api/CharaType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharaType>> PostCharaType(CharaType charaType)
        {
            _context.CharaTypes.Add(charaType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharaTypeExists(charaType.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharaType", new { id = charaType.Id }, charaType);
        }

        // DELETE: api/CharaType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharaType(string id)
        {
            var charaType = await _context.CharaTypes.FindAsync(id);
            if (charaType == null)
            {
                return NotFound();
            }

            _context.CharaTypes.Remove(charaType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharaTypeExists(string id)
        {
            return _context.CharaTypes.Any(e => e.Id == id);
        }
    }
}
