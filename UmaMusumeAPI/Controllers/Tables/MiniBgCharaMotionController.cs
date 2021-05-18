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
    public class MiniBgCharaMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniBgCharaMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniBgCharaMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniBgCharaMotion>>> GetMiniBgCharaMotions()
        {
            return await _context.MiniBgCharaMotions.ToListAsync();
        }

        // GET: api/MiniBgCharaMotion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniBgCharaMotion>> GetMiniBgCharaMotion(int id)
        {
            var miniBgCharaMotion = await _context.MiniBgCharaMotions.FindAsync(id);

            if (miniBgCharaMotion == null)
            {
                return NotFound();
            }

            return miniBgCharaMotion;
        }
    }
}
