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
    public class DirectoryController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DirectoryController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/Directory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Directory>>> GetDirectories()
        {
            return await _context.Directories.ToListAsync();
        }

        // GET: api/Directory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Directory>> GetDirectory(int id)
        {
            var directory = await _context.Directories.FindAsync(id);

            if (directory == null)
            {
                return NotFound();
            }

            return directory;
        }

        // PUT: api/Directory/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDirectory(int id, Directory directory)
        {
            if (id != directory.Id)
            {
                return BadRequest();
            }

            _context.Entry(directory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectoryExists(id))
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

        // POST: api/Directory
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Directory>> PostDirectory(Directory directory)
        {
            _context.Directories.Add(directory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DirectoryExists(directory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDirectory", new { id = directory.Id }, directory);
        }

        // DELETE: api/Directory/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDirectory(int id)
        {
            var directory = await _context.Directories.FindAsync(id);
            if (directory == null)
            {
                return NotFound();
            }

            _context.Directories.Remove(directory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DirectoryExists(int id)
        {
            return _context.Directories.Any(e => e.Id == id);
        }
    }
}
