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
    public class TextDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TextDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TextData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TextData>>> GetTextData()
        {
            return await _context.TextData.ToListAsync();
        }

        // GET: api/TextData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TextData>> GetTextData(int id)
        {
            var textData = await _context.TextData.FindAsync(id);

            if (textData == null)
            {
                return NotFound();
            }

            return textData;
        }

        // PUT: api/TextData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTextData(int id, TextData textData)
        {
            if (id != textData.Category)
            {
                return BadRequest();
            }

            _context.Entry(textData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TextDataExists(id))
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

        // POST: api/TextData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TextData>> PostTextData(TextData textData)
        {
            _context.TextData.Add(textData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TextDataExists(textData.Category))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTextData", new { id = textData.Category }, textData);
        }

        // DELETE: api/TextData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTextData(int id)
        {
            var textData = await _context.TextData.FindAsync(id);
            if (textData == null)
            {
                return NotFound();
            }

            _context.TextData.Remove(textData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TextDataExists(int id)
        {
            return _context.TextData.Any(e => e.Category == id);
        }
    }
}
