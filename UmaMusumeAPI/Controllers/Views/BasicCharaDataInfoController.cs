using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Controllers.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicCharaDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicCharaDataInfoController(UmaMusumeDbContext context)
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
        public async Task<ActionResult<IEnumerable<BasicCharaDataInfo>>> GetBasicCharaDataInfo(int charaId)
        {
            var basicCharaDataInfo = await _context.BasicCharaDataInfos
                .Where(c => c.CharaId == charaId)
                .ToListAsync();

            if (basicCharaDataInfo == null)
            {
                return NotFound();
            }

            return basicCharaDataInfo;
        }
    }
}
