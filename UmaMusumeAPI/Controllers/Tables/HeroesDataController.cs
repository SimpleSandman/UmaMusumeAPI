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
    public class HeroesDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HeroesDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HeroesData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeroesData>>> GetHeroesData()
        {
            return await _context.HeroesData.ToListAsync();
        }

        // GET: api/HeroesData/5
        [HttpGet("{heroesId}")]
        public async Task<ActionResult<HeroesData>> GetHeroesData(int heroesId)
        {
            var heroesData = await _context.HeroesData.FindAsync(heroesId);

            if (heroesData == null)
            {
                return NotFound();
            }

            return heroesData;
        }
    }
}
