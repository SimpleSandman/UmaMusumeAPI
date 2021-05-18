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
    public class LoginBonusDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LoginBonusDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LoginBonusDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoginBonusDetail>>> GetLoginBonusDetails()
        {
            return await _context.LoginBonusDetails.ToListAsync();
        }

        // GET: api/LoginBonusDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoginBonusDetail>> GetLoginBonusDetail(int id)
        {
            var loginBonusDetail = await _context.LoginBonusDetails.FindAsync(id);

            if (loginBonusDetail == null)
            {
                return NotFound();
            }

            return loginBonusDetail;
        }

        // PUT: api/LoginBonusDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoginBonusDetail(int id, LoginBonusDetail loginBonusDetail)
        {
            if (id != loginBonusDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(loginBonusDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginBonusDetailExists(id))
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

        // POST: api/LoginBonusDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoginBonusDetail>> PostLoginBonusDetail(LoginBonusDetail loginBonusDetail)
        {
            _context.LoginBonusDetails.Add(loginBonusDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoginBonusDetailExists(loginBonusDetail.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLoginBonusDetail", new { id = loginBonusDetail.Id }, loginBonusDetail);
        }

        // DELETE: api/LoginBonusDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoginBonusDetail(int id)
        {
            var loginBonusDetail = await _context.LoginBonusDetails.FindAsync(id);
            if (loginBonusDetail == null)
            {
                return NotFound();
            }

            _context.LoginBonusDetails.Remove(loginBonusDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoginBonusDetailExists(int id)
        {
            return _context.LoginBonusDetails.Any(e => e.Id == id);
        }
    }
}
