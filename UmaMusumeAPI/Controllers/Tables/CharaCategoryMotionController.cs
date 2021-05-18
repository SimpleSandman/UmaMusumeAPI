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
    public class CharaCategoryMotionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaCategoryMotionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaCategoryMotion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaCategoryMotion>>> GetCharaCategoryMotions()
        {
            return await _context.CharaCategoryMotions.ToListAsync();
        }

        // GET: api/CharaCategoryMotion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaCategoryMotion>> GetCharaCategoryMotion(int id)
        {
            var charaCategoryMotion = await _context.CharaCategoryMotions.FindAsync(id);

            if (charaCategoryMotion == null)
            {
                return NotFound();
            }

            return charaCategoryMotion;
        }
    }
}
