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
    public class ChampionsNewsCharaCommentController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsCharaCommentController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsCharaComment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsCharaComment>>> GetChampionsNewsCharaComments()
        {
            return await _context.ChampionsNewsCharaComments.ToListAsync();
        }

        // GET: api/ChampionsNewsCharaComment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsCharaComment>> GetChampionsNewsCharaComment(int id)
        {
            var championsNewsCharaComment = await _context.ChampionsNewsCharaComments.FindAsync(id);

            if (championsNewsCharaComment == null)
            {
                return NotFound();
            }

            return championsNewsCharaComment;
        }

        // PUT: api/ChampionsNewsCharaComment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsNewsCharaComment(int id, ChampionsNewsCharaComment championsNewsCharaComment)
        {
            if (id != championsNewsCharaComment.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsNewsCharaComment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsNewsCharaCommentExists(id))
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

        // POST: api/ChampionsNewsCharaComment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsNewsCharaComment>> PostChampionsNewsCharaComment(ChampionsNewsCharaComment championsNewsCharaComment)
        {
            _context.ChampionsNewsCharaComments.Add(championsNewsCharaComment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsNewsCharaCommentExists(championsNewsCharaComment.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsNewsCharaComment", new { id = championsNewsCharaComment.Id }, championsNewsCharaComment);
        }

        // DELETE: api/ChampionsNewsCharaComment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsNewsCharaComment(int id)
        {
            var championsNewsCharaComment = await _context.ChampionsNewsCharaComments.FindAsync(id);
            if (championsNewsCharaComment == null)
            {
                return NotFound();
            }

            _context.ChampionsNewsCharaComments.Remove(championsNewsCharaComment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsNewsCharaCommentExists(int id)
        {
            return _context.ChampionsNewsCharaComments.Any(e => e.Id == id);
        }
    }
}
