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
    public class MobHairColorSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MobHairColorSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MobHairColorSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MobHairColorSet>>> GetMobHairColorSets()
        {
            return await _context.MobHairColorSets.ToListAsync();
        }

        // GET: api/MobHairColorSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MobHairColorSet>> GetMobHairColorSet(int id)
        {
            var mobHairColorSet = await _context.MobHairColorSets.FindAsync(id);

            if (mobHairColorSet == null)
            {
                return NotFound();
            }

            return mobHairColorSet;
        }
    }
}
