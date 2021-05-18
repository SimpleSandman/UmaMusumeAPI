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
    public class ChampionsNewsTitleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsTitleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsTitle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsTitle>>> GetChampionsNewsTitles()
        {
            return await _context.ChampionsNewsTitles.ToListAsync();
        }

        // GET: api/ChampionsNewsTitle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsTitle>> GetChampionsNewsTitle(int id)
        {
            var championsNewsTitle = await _context.ChampionsNewsTitles.FindAsync(id);

            if (championsNewsTitle == null)
            {
                return NotFound();
            }

            return championsNewsTitle;
        }

        // PUT: api/ChampionsNewsTitle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsNewsTitle(int id, ChampionsNewsTitle championsNewsTitle)
        {
            if (id != championsNewsTitle.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsNewsTitle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsNewsTitleExists(id))
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

        // POST: api/ChampionsNewsTitle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsNewsTitle>> PostChampionsNewsTitle(ChampionsNewsTitle championsNewsTitle)
        {
            _context.ChampionsNewsTitles.Add(championsNewsTitle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsNewsTitleExists(championsNewsTitle.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsNewsTitle", new { id = championsNewsTitle.Id }, championsNewsTitle);
        }

        // DELETE: api/ChampionsNewsTitle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsNewsTitle(int id)
        {
            var championsNewsTitle = await _context.ChampionsNewsTitles.FindAsync(id);
            if (championsNewsTitle == null)
            {
                return NotFound();
            }

            _context.ChampionsNewsTitles.Remove(championsNewsTitle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsNewsTitleExists(int id)
        {
            return _context.ChampionsNewsTitles.Any(e => e.Id == id);
        }
    }
}
