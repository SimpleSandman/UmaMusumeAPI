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
    public class CraneGameDefineParamController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameDefineParamController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameDefineParam
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameDefineParam>>> GetCraneGameDefineParams()
        {
            return await _context.CraneGameDefineParams.ToListAsync();
        }

        // GET: api/CraneGameDefineParam/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameDefineParam>> GetCraneGameDefineParam(int id)
        {
            var craneGameDefineParam = await _context.CraneGameDefineParams.FindAsync(id);

            if (craneGameDefineParam == null)
            {
                return NotFound();
            }

            return craneGameDefineParam;
        }

        // PUT: api/CraneGameDefineParam/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCraneGameDefineParam(int id, CraneGameDefineParam craneGameDefineParam)
        {
            if (id != craneGameDefineParam.Id)
            {
                return BadRequest();
            }

            _context.Entry(craneGameDefineParam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CraneGameDefineParamExists(id))
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

        // POST: api/CraneGameDefineParam
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CraneGameDefineParam>> PostCraneGameDefineParam(CraneGameDefineParam craneGameDefineParam)
        {
            _context.CraneGameDefineParams.Add(craneGameDefineParam);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CraneGameDefineParamExists(craneGameDefineParam.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCraneGameDefineParam", new { id = craneGameDefineParam.Id }, craneGameDefineParam);
        }

        // DELETE: api/CraneGameDefineParam/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCraneGameDefineParam(int id)
        {
            var craneGameDefineParam = await _context.CraneGameDefineParams.FindAsync(id);
            if (craneGameDefineParam == null)
            {
                return NotFound();
            }

            _context.CraneGameDefineParams.Remove(craneGameDefineParam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CraneGameDefineParamExists(int id)
        {
            return _context.CraneGameDefineParams.Any(e => e.Id == id);
        }
    }
}
