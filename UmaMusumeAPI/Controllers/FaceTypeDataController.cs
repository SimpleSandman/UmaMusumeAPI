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
    public class FaceTypeDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public FaceTypeDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/FaceTypeData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaceTypeData>>> GetFaceTypeData()
        {
            return await _context.FaceTypeData.ToListAsync();
        }

        // GET: api/FaceTypeData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FaceTypeData>> GetFaceTypeData(string id)
        {
            var faceTypeData = await _context.FaceTypeData.FindAsync(id);

            if (faceTypeData == null)
            {
                return NotFound();
            }

            return faceTypeData;
        }

        // PUT: api/FaceTypeData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaceTypeData(string id, FaceTypeData faceTypeData)
        {
            if (id != faceTypeData.Label)
            {
                return BadRequest();
            }

            _context.Entry(faceTypeData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaceTypeDataExists(id))
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

        // POST: api/FaceTypeData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FaceTypeData>> PostFaceTypeData(FaceTypeData faceTypeData)
        {
            _context.FaceTypeData.Add(faceTypeData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FaceTypeDataExists(faceTypeData.Label))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFaceTypeData", new { id = faceTypeData.Label }, faceTypeData);
        }

        // DELETE: api/FaceTypeData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaceTypeData(string id)
        {
            var faceTypeData = await _context.FaceTypeData.FindAsync(id);
            if (faceTypeData == null)
            {
                return NotFound();
            }

            _context.FaceTypeData.Remove(faceTypeData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FaceTypeDataExists(string id)
        {
            return _context.FaceTypeData.Any(e => e.Label == id);
        }
    }
}
