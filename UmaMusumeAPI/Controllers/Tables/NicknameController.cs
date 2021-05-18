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
    public class NicknameController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NicknameController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/Nickname
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nickname>>> GetNicknames()
        {
            return await _context.Nicknames.ToListAsync();
        }

        // GET: api/Nickname/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nickname>> GetNickname(int id)
        {
            var nickname = await _context.Nicknames.FindAsync(id);

            if (nickname == null)
            {
                return NotFound();
            }

            return nickname;
        }

        // PUT: api/Nickname/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNickname(int id, Nickname nickname)
        {
            if (id != nickname.Id)
            {
                return BadRequest();
            }

            _context.Entry(nickname).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NicknameExists(id))
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

        // POST: api/Nickname
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nickname>> PostNickname(Nickname nickname)
        {
            _context.Nicknames.Add(nickname);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NicknameExists(nickname.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNickname", new { id = nickname.Id }, nickname);
        }

        // DELETE: api/Nickname/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNickname(int id)
        {
            var nickname = await _context.Nicknames.FindAsync(id);
            if (nickname == null)
            {
                return NotFound();
            }

            _context.Nicknames.Remove(nickname);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NicknameExists(int id)
        {
            return _context.Nicknames.Any(e => e.Id == id);
        }
    }
}
