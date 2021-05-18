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
    public class TutorialGuideDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TutorialGuideDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TutorialGuideData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorialGuideData>>> GetTutorialGuideData()
        {
            return await _context.TutorialGuideData.ToListAsync();
        }

        // GET: api/TutorialGuideData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TutorialGuideData>> GetTutorialGuideData(int id)
        {
            var tutorialGuideData = await _context.TutorialGuideData.FindAsync(id);

            if (tutorialGuideData == null)
            {
                return NotFound();
            }

            return tutorialGuideData;
        }

        // PUT: api/TutorialGuideData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTutorialGuideData(int id, TutorialGuideData tutorialGuideData)
        {
            if (id != tutorialGuideData.Id)
            {
                return BadRequest();
            }

            _context.Entry(tutorialGuideData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TutorialGuideDataExists(id))
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

        // POST: api/TutorialGuideData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TutorialGuideData>> PostTutorialGuideData(TutorialGuideData tutorialGuideData)
        {
            _context.TutorialGuideData.Add(tutorialGuideData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TutorialGuideDataExists(tutorialGuideData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTutorialGuideData", new { id = tutorialGuideData.Id }, tutorialGuideData);
        }

        // DELETE: api/TutorialGuideData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTutorialGuideData(int id)
        {
            var tutorialGuideData = await _context.TutorialGuideData.FindAsync(id);
            if (tutorialGuideData == null)
            {
                return NotFound();
            }

            _context.TutorialGuideData.Remove(tutorialGuideData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TutorialGuideDataExists(int id)
        {
            return _context.TutorialGuideData.Any(e => e.Id == id);
        }
    }
}
