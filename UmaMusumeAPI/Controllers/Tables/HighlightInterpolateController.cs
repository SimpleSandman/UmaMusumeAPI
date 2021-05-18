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
    public class HighlightInterpolateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HighlightInterpolateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HighlightInterpolate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HighlightInterpolate>>> GetHighlightInterpolates()
        {
            return await _context.HighlightInterpolates.ToListAsync();
        }

        // GET: api/HighlightInterpolate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HighlightInterpolate>> GetHighlightInterpolate(int id)
        {
            var highlightInterpolate = await _context.HighlightInterpolates.FindAsync(id);

            if (highlightInterpolate == null)
            {
                return NotFound();
            }

            return highlightInterpolate;
        }
    }
}
