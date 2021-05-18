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
    public class RacePlayerCameraController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RacePlayerCameraController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RacePlayerCamera
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RacePlayerCamera>>> GetRacePlayerCameras()
        {
            return await _context.RacePlayerCameras.ToListAsync();
        }

        // GET: api/RacePlayerCamera/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RacePlayerCamera>> GetRacePlayerCamera(int id)
        {
            var racePlayerCamera = await _context.RacePlayerCameras.FindAsync(id);

            if (racePlayerCamera == null)
            {
                return NotFound();
            }

            return racePlayerCamera;
        }

        // PUT: api/RacePlayerCamera/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRacePlayerCamera(int id, RacePlayerCamera racePlayerCamera)
        {
            if (id != racePlayerCamera.Id)
            {
                return BadRequest();
            }

            _context.Entry(racePlayerCamera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacePlayerCameraExists(id))
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

        // POST: api/RacePlayerCamera
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RacePlayerCamera>> PostRacePlayerCamera(RacePlayerCamera racePlayerCamera)
        {
            _context.RacePlayerCameras.Add(racePlayerCamera);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RacePlayerCameraExists(racePlayerCamera.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRacePlayerCamera", new { id = racePlayerCamera.Id }, racePlayerCamera);
        }

        // DELETE: api/RacePlayerCamera/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRacePlayerCamera(int id)
        {
            var racePlayerCamera = await _context.RacePlayerCameras.FindAsync(id);
            if (racePlayerCamera == null)
            {
                return NotFound();
            }

            _context.RacePlayerCameras.Remove(racePlayerCamera);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RacePlayerCameraExists(int id)
        {
            return _context.RacePlayerCameras.Any(e => e.Id == id);
        }
    }
}
