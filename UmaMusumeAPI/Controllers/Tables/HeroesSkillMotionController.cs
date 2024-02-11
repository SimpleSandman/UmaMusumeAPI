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
    public class HeroesSkillMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HeroesSkillMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HeroesSkillMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeroesSkillMotion>>> GetHeroesSkillMotion()
        {
            return await _context.HeroesSkillMotions.ToListAsync();
        }

        // GET: api/HeroesSkillMotion/5
        [HttpGet("{characterId}")]
        public async Task<ActionResult<HeroesSkillMotion>> GetHeroesSkillMotion(int characterId)
        {
            var heroesSkillMotion = await _context.HeroesSkillMotions.FindAsync(characterId);

            if (heroesSkillMotion == null)
            {
                return NotFound();
            }

            return heroesSkillMotion;
        }
    }
}
