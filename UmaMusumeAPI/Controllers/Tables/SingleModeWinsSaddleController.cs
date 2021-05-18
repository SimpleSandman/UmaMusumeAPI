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
    public class SingleModeWinsSaddleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeWinsSaddleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeWinsSaddle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeWinsSaddle>>> GetSingleModeWinsSaddles()
        {
            return await _context.SingleModeWinsSaddles.ToListAsync();
        }

        // GET: api/SingleModeWinsSaddle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeWinsSaddle>> GetSingleModeWinsSaddle(int id)
        {
            var singleModeWinsSaddle = await _context.SingleModeWinsSaddles.FindAsync(id);

            if (singleModeWinsSaddle == null)
            {
                return NotFound();
            }

            return singleModeWinsSaddle;
        }

        // PUT: api/SingleModeWinsSaddle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeWinsSaddle(int id, SingleModeWinsSaddle singleModeWinsSaddle)
        {
            if (id != singleModeWinsSaddle.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeWinsSaddle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeWinsSaddleExists(id))
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

        // POST: api/SingleModeWinsSaddle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeWinsSaddle>> PostSingleModeWinsSaddle(SingleModeWinsSaddle singleModeWinsSaddle)
        {
            _context.SingleModeWinsSaddles.Add(singleModeWinsSaddle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeWinsSaddleExists(singleModeWinsSaddle.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeWinsSaddle", new { id = singleModeWinsSaddle.Id }, singleModeWinsSaddle);
        }

        // DELETE: api/SingleModeWinsSaddle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeWinsSaddle(int id)
        {
            var singleModeWinsSaddle = await _context.SingleModeWinsSaddles.FindAsync(id);
            if (singleModeWinsSaddle == null)
            {
                return NotFound();
            }

            _context.SingleModeWinsSaddles.Remove(singleModeWinsSaddle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeWinsSaddleExists(int id)
        {
            return _context.SingleModeWinsSaddles.Any(e => e.Id == id);
        }
    }
}
