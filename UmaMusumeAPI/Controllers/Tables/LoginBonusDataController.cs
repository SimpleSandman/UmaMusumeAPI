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
    public class LoginBonusDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LoginBonusDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LoginBonusData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoginBonusData>>> GetLoginBonusData()
        {
            return await _context.LoginBonusData.ToListAsync();
        }

        // GET: api/LoginBonusData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoginBonusData>> GetLoginBonusData(int id)
        {
            var loginBonusData = await _context.LoginBonusData.FindAsync(id);

            if (loginBonusData == null)
            {
                return NotFound();
            }

            return loginBonusData;
        }

        // PUT: api/LoginBonusData/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoginBonusData(int id, LoginBonusData loginBonusData)
        {
            if (id != loginBonusData.Id)
            {
                return BadRequest();
            }

            _context.Entry(loginBonusData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginBonusDataExists(id))
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

        // POST: api/LoginBonusData
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoginBonusData>> PostLoginBonusData(LoginBonusData loginBonusData)
        {
            _context.LoginBonusData.Add(loginBonusData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoginBonusDataExists(loginBonusData.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLoginBonusData", new { id = loginBonusData.Id }, loginBonusData);
        }

        // DELETE: api/LoginBonusData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoginBonusData(int id)
        {
            var loginBonusData = await _context.LoginBonusData.FindAsync(id);
            if (loginBonusData == null)
            {
                return NotFound();
            }

            _context.LoginBonusData.Remove(loginBonusData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoginBonusDataExists(int id)
        {
            return _context.LoginBonusData.Any(e => e.Id == id);
        }
    }
}
