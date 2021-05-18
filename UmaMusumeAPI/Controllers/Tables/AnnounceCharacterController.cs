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
    public class AnnounceCharacterController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AnnounceCharacterController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AnnounceCharacter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnnounceCharacter>>> GetAnnounceCharacters()
        {
            return await _context.AnnounceCharacters.ToListAsync();
        }

        // GET: api/AnnounceCharacter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnnounceCharacter>> GetAnnounceCharacter(int id)
        {
            var announceCharacter = await _context.AnnounceCharacters.FindAsync(id);

            if (announceCharacter == null)
            {
                return NotFound();
            }

            return announceCharacter;
        }
    }
}
