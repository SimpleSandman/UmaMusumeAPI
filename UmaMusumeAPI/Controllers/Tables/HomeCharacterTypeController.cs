using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeCharacterTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeCharacterTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeCharacterType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeCharacterType>>> GetHomeCharacterTypes()
        {
            return await _context.HomeCharacterTypes.ToListAsync();
        }

        // GET: api/HomeCharacterType/5
        [HttpGet("{posId}")]
        public async Task<ActionResult<IEnumerable<HomeCharacterType>>> GetHomeCharacterType(int posId)
        {
            var homeCharacterType = await _context.HomeCharacterTypes
                .Where(c => c.PosId == posId)
                .ToListAsync();

            if (homeCharacterType == null)
            {
                return NotFound();
            }

            return homeCharacterType;
        }
    }
}
