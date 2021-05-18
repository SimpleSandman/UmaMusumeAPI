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
    public class CharaStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaStoryData>>> GetCharaStoryData()
        {
            return await _context.CharaStoryData.ToListAsync();
        }

        // GET: api/CharaStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaStoryData>> GetCharaStoryData(int id)
        {
            var charaStoryData = await _context.CharaStoryData.FindAsync(id);

            if (charaStoryData == null)
            {
                return NotFound();
            }

            return charaStoryData;
        }

        // PUT: api/CharaStoryData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharaStoryData(int id, CharaStoryData charaStoryData)
        {
            if (id != charaStoryData.Id)
            {
                return BadRequest();
            }

            _context.Entry(charaStoryData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharaStoryDataExists(id))
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

        // POST: api/CharaStoryData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharaStoryData>> PostCharaStoryData(CharaStoryData charaStoryData)
        {
            _context.CharaStoryData.Add(charaStoryData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharaStoryDataExists(charaStoryData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharaStoryData", new { id = charaStoryData.Id }, charaStoryData);
        }

        // DELETE: api/CharaStoryData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharaStoryData(int id)
        {
            var charaStoryData = await _context.CharaStoryData.FindAsync(id);
            if (charaStoryData == null)
            {
                return NotFound();
            }

            _context.CharaStoryData.Remove(charaStoryData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharaStoryDataExists(int id)
        {
            return _context.CharaStoryData.Any(e => e.Id == id);
        }
    }
}
