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
    public class SingleModeCharaGradeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeCharaGradeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeCharaGrade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeCharaGrade>>> GetSingleModeCharaGrades()
        {
            return await _context.SingleModeCharaGrades.ToListAsync();
        }

        // GET: api/SingleModeCharaGrade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeCharaGrade>> GetSingleModeCharaGrade(int id)
        {
            var singleModeCharaGrade = await _context.SingleModeCharaGrades.FindAsync(id);

            if (singleModeCharaGrade == null)
            {
                return NotFound();
            }

            return singleModeCharaGrade;
        }

        // PUT: api/SingleModeCharaGrade/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeCharaGrade(int id, SingleModeCharaGrade singleModeCharaGrade)
        {
            if (id != singleModeCharaGrade.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeCharaGrade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeCharaGradeExists(id))
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

        // POST: api/SingleModeCharaGrade
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeCharaGrade>> PostSingleModeCharaGrade(SingleModeCharaGrade singleModeCharaGrade)
        {
            _context.SingleModeCharaGrades.Add(singleModeCharaGrade);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeCharaGradeExists(singleModeCharaGrade.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeCharaGrade", new { id = singleModeCharaGrade.Id }, singleModeCharaGrade);
        }

        // DELETE: api/SingleModeCharaGrade/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeCharaGrade(int id)
        {
            var singleModeCharaGrade = await _context.SingleModeCharaGrades.FindAsync(id);
            if (singleModeCharaGrade == null)
            {
                return NotFound();
            }

            _context.SingleModeCharaGrades.Remove(singleModeCharaGrade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeCharaGradeExists(int id)
        {
            return _context.SingleModeCharaGrades.Any(e => e.Id == id);
        }
    }
}
