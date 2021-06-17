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
    public class NiceCardDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceCardDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceCardDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceCardDataInfo>>> GetNiceCardDataInfos()
        {
            return await _context.NiceCardDataInfos.ToListAsync();
        }

        // GET: api/NiceCardDataInfo/5
        [HttpGet("{charaId}")]
        public async Task<ActionResult<NiceCardDataInfo>> GetNiceCardDataInfo(int charaId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceCardDataInfo = await _context.NiceCardDataInfos.SingleOrDefaultAsync(c => c.CardId == charaId);

            if (niceCardDataInfo == null)
            {
                return NotFound();
            }

            return niceCardDataInfo;
        }
    }
}
