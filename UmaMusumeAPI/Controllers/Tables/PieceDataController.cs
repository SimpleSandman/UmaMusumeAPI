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
    public class PieceDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public PieceDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/PieceData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PieceData>>> GetPieceData()
        {
            return await _context.PieceData.ToListAsync();
        }

        // GET: api/PieceData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PieceData>> GetPieceData(int id)
        {
            var pieceData = await _context.PieceData.FindAsync(id);

            if (pieceData == null)
            {
                return NotFound();
            }

            return pieceData;
        }
    }
}
