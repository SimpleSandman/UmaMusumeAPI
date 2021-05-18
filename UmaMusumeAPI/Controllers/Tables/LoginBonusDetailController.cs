using System.Collections.Generic;
using System.Threading.Tasks;

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
    }
}
