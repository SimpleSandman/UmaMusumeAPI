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
    public class HeroesRaceDefaultUserController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HeroesRaceDefaultUserController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HeroesRaceDefaultUser
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeroesRaceDefaultUser>>> GetHeroesRaceDefaultUser()
        {
            return await _context.HeroesRaceDefaultUsers.ToListAsync();
        }

        // GET: api/HeroesRaceDefaultUser/5
        [HttpGet("{defaultNpcTeamId}")]
        public async Task<ActionResult<HeroesRaceDefaultUser>> GetHeroesRaceDefaultUser(int defaultNpcTeamId)
        {
            var heroesRaceDefaultUser = await _context.HeroesRaceDefaultUsers.FindAsync(defaultNpcTeamId);

            if (heroesRaceDefaultUser == null)
            {
                return NotFound();
            }

            return heroesRaceDefaultUser;
        }
    }
}
