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
    public class TrainingCuttCharaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingCuttCharaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingCuttCharaData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingCuttCharaData>>> GetTrainingCuttCharaData()
        {
            return await _context.TrainingCuttCharaData.ToListAsync();
        }

        // GET: api/TrainingCuttCharaData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingCuttCharaData>> GetTrainingCuttCharaData(int id)
        {
            var trainingCuttCharaData = await _context.TrainingCuttCharaData.FindAsync(id);

            if (trainingCuttCharaData == null)
            {
                return NotFound();
            }

            return trainingCuttCharaData;
        }

        // PUT: api/TrainingCuttCharaData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingCuttCharaData(int id, TrainingCuttCharaData trainingCuttCharaData)
        {
            if (id != trainingCuttCharaData.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainingCuttCharaData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingCuttCharaDataExists(id))
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

        // POST: api/TrainingCuttCharaData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TrainingCuttCharaData>> PostTrainingCuttCharaData(TrainingCuttCharaData trainingCuttCharaData)
        {
            _context.TrainingCuttCharaData.Add(trainingCuttCharaData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrainingCuttCharaDataExists(trainingCuttCharaData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrainingCuttCharaData", new { id = trainingCuttCharaData.Id }, trainingCuttCharaData);
        }

        // DELETE: api/TrainingCuttCharaData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrainingCuttCharaData(int id)
        {
            var trainingCuttCharaData = await _context.TrainingCuttCharaData.FindAsync(id);
            if (trainingCuttCharaData == null)
            {
                return NotFound();
            }

            _context.TrainingCuttCharaData.Remove(trainingCuttCharaData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrainingCuttCharaDataExists(int id)
        {
            return _context.TrainingCuttCharaData.Any(e => e.Id == id);
        }
    }
}
