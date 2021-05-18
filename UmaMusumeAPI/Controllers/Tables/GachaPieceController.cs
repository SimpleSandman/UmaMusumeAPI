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
    public class GachaPieceController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GachaPieceController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GachaPiece
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GachaPiece>>> GetGachaPieces()
        {
            return await _context.GachaPieces.ToListAsync();
        }

        // GET: api/GachaPiece/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GachaPiece>> GetGachaPiece(int id)
        {
            var gachaPiece = await _context.GachaPieces.FindAsync(id);

            if (gachaPiece == null)
            {
                return NotFound();
            }

            return gachaPiece;
        }
    }
}
