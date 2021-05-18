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
    public class MobDressColorSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MobDressColorSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MobDressColorSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MobDressColorSet>>> GetMobDressColorSets()
        {
            return await _context.MobDressColorSets.ToListAsync();
        }

        // GET: api/MobDressColorSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MobDressColorSet>> GetMobDressColorSet(int id)
        {
            var mobDressColorSet = await _context.MobDressColorSets.FindAsync(id);

            if (mobDressColorSet == null)
            {
                return NotFound();
            }

            return mobDressColorSet;
        }
    }
}
