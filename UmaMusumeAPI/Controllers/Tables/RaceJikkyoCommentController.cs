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
    public class RaceJikkyoCommentController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceJikkyoCommentController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceJikkyoComment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceJikkyoComment>>> GetRaceJikkyoComments()
        {
            return await _context.RaceJikkyoComments.ToListAsync();
        }

        // GET: api/RaceJikkyoComment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceJikkyoComment>> GetRaceJikkyoComment(int id)
        {
            var raceJikkyoComment = await _context.RaceJikkyoComments.FindAsync(id);

            if (raceJikkyoComment == null)
            {
                return NotFound();
            }

            return raceJikkyoComment;
        }

        // PUT: api/RaceJikkyoComment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRaceJikkyoComment(int id, RaceJikkyoComment raceJikkyoComment)
        {
            if (id != raceJikkyoComment.Id)
            {
                return BadRequest();
            }

            _context.Entry(raceJikkyoComment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceJikkyoCommentExists(id))
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

        // POST: api/RaceJikkyoComment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RaceJikkyoComment>> PostRaceJikkyoComment(RaceJikkyoComment raceJikkyoComment)
        {
            _context.RaceJikkyoComments.Add(raceJikkyoComment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RaceJikkyoCommentExists(raceJikkyoComment.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRaceJikkyoComment", new { id = raceJikkyoComment.Id }, raceJikkyoComment);
        }

        // DELETE: api/RaceJikkyoComment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRaceJikkyoComment(int id)
        {
            var raceJikkyoComment = await _context.RaceJikkyoComments.FindAsync(id);
            if (raceJikkyoComment == null)
            {
                return NotFound();
            }

            _context.RaceJikkyoComments.Remove(raceJikkyoComment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RaceJikkyoCommentExists(int id)
        {
            return _context.RaceJikkyoComments.Any(e => e.Id == id);
        }
    }
}
