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
    }
}
