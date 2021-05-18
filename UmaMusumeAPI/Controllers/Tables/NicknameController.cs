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
    public class NicknameController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NicknameController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/Nickname
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nickname>>> GetNicknames()
        {
            return await _context.Nicknames.ToListAsync();
        }

        // GET: api/Nickname/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nickname>> GetNickname(int id)
        {
            var nickname = await _context.Nicknames.FindAsync(id);

            if (nickname == null)
            {
                return NotFound();
            }

            return nickname;
        }
    }
}
