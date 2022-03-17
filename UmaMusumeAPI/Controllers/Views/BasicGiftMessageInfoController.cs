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
    public class BasicGiftMessageInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicGiftMessageInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicGiftMessageInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicGiftMessageInfo>>> GetBasicGiftMessageInfos()
        {
            return await _context.BasicGiftMessageInfos.ToListAsync();
        }

        // GET: api/BasicGiftMessageInfo/5
        [HttpGet("{giftMessageId}")]
        public async Task<ActionResult<IEnumerable<BasicGiftMessageInfo>>> GetBasicGiftMessageInfo(int giftMessageId)
        {
            var basicGiftMessageInfo = await _context.BasicGiftMessageInfos
                .Where(c => c.GiftMessageId == giftMessageId)
                .ToListAsync();

            if (basicGiftMessageInfo == null)
            {
                return NotFound();
            }

            return basicGiftMessageInfo;
        }
    }
}
