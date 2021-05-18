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
    public class NeedPieceNumDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NeedPieceNumDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NeedPieceNumData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NeedPieceNumData>>> GetNeedPieceNumData()
        {
            return await _context.NeedPieceNumData.ToListAsync();
        }

        // GET: api/NeedPieceNumData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NeedPieceNumData>> GetNeedPieceNumData(int id)
        {
            var needPieceNumData = await _context.NeedPieceNumData.FindAsync(id);

            if (needPieceNumData == null)
            {
                return NotFound();
            }

            return needPieceNumData;
        }
    }
}
