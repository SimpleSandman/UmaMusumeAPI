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
        public async Task<ActionResult<IEnumerable<BasicCharaDataInfo>>> GetAnnounceCharacters()
        {
            return await _context.BasicCharaDataInfos.ToListAsync();
        }

        // GET: api/BasicCharaDataInfo/5
        [HttpGet("{charaId}")]
        public async Task<ActionResult<BasicCharaDataInfo>> GetAnnounceCharacter(int charaId)
        {
            var basicCharaDatainfo = await _context.BasicCharaDataInfos.SingleOrDefaultAsync(c => c.CharaId == charaId);

            if (basicCharaDatainfo == null)
            {
                return NotFound();
            }

            return basicCharaDatainfo;
        }
    }
}
