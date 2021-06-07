using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Controllers.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicPieceDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicPieceDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicPieceDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicPieceDataInfo>>> GetBasicPieceDataInfos()
        {
            return await _context.BasicPieceDataInfos.ToListAsync();
        }

        // GET: api/BasicPieceDataInfo/5
        [HttpGet("{pieceId}")]
        public async Task<ActionResult<BasicPieceDataInfo>> GetBasicPieceDataInfo(int pieceId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicPieceDataInfo = await _context.BasicPieceDataInfos.SingleOrDefaultAsync(c => c.PieceId == pieceId);

            if (basicPieceDataInfo == null)
            {
                return NotFound();
            }

            return basicPieceDataInfo;
        }
    }
}
