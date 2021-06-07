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
    public class NiceCharaDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceCharaDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceCharaDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceCharaDataInfo>>> GetNiceCharaDataInfos()
        {
            return await _context.NiceCharaDataInfos.ToListAsync();
        }

        // GET: api/NiceCharaDataInfo/5
        [HttpGet("{charaId}")]
        public async Task<ActionResult<NiceCharaDataInfo>> GetNiceCharaDataInfo(int charaId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceCharaDataInfo = await _context.NiceCharaDataInfos.SingleOrDefaultAsync(c => c.CharaId == charaId);

            if (niceCharaDataInfo == null)
            {
                return NotFound();
            }

            return niceCharaDataInfo;
        }
    }
}
