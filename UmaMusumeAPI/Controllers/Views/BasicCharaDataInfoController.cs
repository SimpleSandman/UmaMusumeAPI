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
    public class BasicCharaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicCharaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicCharaDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicCharaDataInfo>>> GetBasicCharaDataInfos()
        {
            return await _context.BasicCharaDataInfos.ToListAsync();
        }

        // GET: api/BasicCharaDataInfo/5
        [HttpGet("{charaId}")]
        public async Task<ActionResult<BasicCharaDataInfo>> GetBasicCharaDataInfo(int charaId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicCharaDatainfo = await _context.BasicCharaDataInfos.SingleOrDefaultAsync(c => c.CharaId == charaId);

            if (basicCharaDatainfo == null)
            {
                return NotFound();
            }

            return basicCharaDatainfo;
        }
    }
}
