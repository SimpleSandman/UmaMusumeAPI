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
    public class MiniBgController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniBgController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniBg
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniBg>>> GetMiniBgs()
        {
            return await _context.MiniBgs.ToListAsync();
        }

        // GET: api/MiniBg/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MiniBg>> GetMiniBg(int id)
        {
            var miniBg = await _context.MiniBgs.FindAsync(id);

            if (miniBg == null)
            {
                return NotFound();
            }

            return miniBg;
        }
    }
}
