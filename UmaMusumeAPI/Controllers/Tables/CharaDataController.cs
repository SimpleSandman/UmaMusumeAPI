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
    public class CharaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaData>>> GetCharaData()
        {
            return await _context.CharaData.ToListAsync();
        }

        // GET: api/CharaData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaData>> GetCharaData(int id)
        {
            var charaData = await _context.CharaData.FindAsync(id);

            if (charaData == null)
            {
                return NotFound();
            }

            return charaData;
        }

        // PUT: api/CharaData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharaData(int id, CharaData charaData)
        {
            if (id != charaData.Id)
            {
                return BadRequest();
            }

            _context.Entry(charaData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharaDataExists(id))
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

        // POST: api/CharaData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharaData>> PostCharaData(CharaData charaData)
        {
            _context.CharaData.Add(charaData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharaDataExists(charaData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharaData", new { id = charaData.Id }, charaData);
        }

        // DELETE: api/CharaData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharaData(int id)
        {
            var charaData = await _context.CharaData.FindAsync(id);
            if (charaData == null)
            {
                return NotFound();
            }

            _context.CharaData.Remove(charaData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharaDataExists(int id)
        {
            return _context.CharaData.Any(e => e.Id == id);
        }
    }
}
