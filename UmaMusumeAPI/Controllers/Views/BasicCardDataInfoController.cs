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
    public class BasicCardDataInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicCardDataInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicCardDataInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicCardDataInfo>>> GetBasicCardDataInfos()
        {
            return await _context.BasicCardDataInfos.ToListAsync();
        }

        // GET: api/BasicCardDataInfo/5
        [HttpGet("{cardId}")]
        public async Task<ActionResult<BasicCardDataInfo>> GetBasicCardDataInfo(int cardId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicCardDataInfo = await _context.BasicCardDataInfos.SingleOrDefaultAsync(c => c.CardId == cardId);

            if (basicCardDataInfo == null)
            {
                return NotFound();
            }

            return basicCardDataInfo;
        }
    }
}
