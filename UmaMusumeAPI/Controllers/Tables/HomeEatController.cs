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
    public class HomeEatController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeEatController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeEat
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeEat>>> GetHomeEat()
        {
            return await _context.HomeEats.ToListAsync();
        }

        // GET: api/HomeEat/5
        [HttpGet("{charaId}")]
        public async Task<ActionResult<IEnumerable<HomeEat>>> GetHomeEat(int charaId)
        {
            var audienceImpostor = await _context.HomeEats
                .Where(c => c.CharaId == charaId)
                .ToListAsync();

            if (audienceImpostor == null)
            {
                return NotFound();
            }

            return audienceImpostor;
        }
    }
}
