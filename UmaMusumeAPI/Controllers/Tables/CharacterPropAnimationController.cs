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
    public class CharacterPropAnimationController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharacterPropAnimationController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharacterPropAnimation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterPropAnimation>>> GetCharacterPropAnimations()
        {
            return await _context.CharacterPropAnimations.ToListAsync();
        }

        // GET: api/CharacterPropAnimation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterPropAnimation>> GetCharacterPropAnimation(int id)
        {
            var characterPropAnimation = await _context.CharacterPropAnimations.FindAsync(id);

            if (characterPropAnimation == null)
            {
                return NotFound();
            }

            return characterPropAnimation;
        }
    }
}
