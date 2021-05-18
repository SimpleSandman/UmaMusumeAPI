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
    public class GiftMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public GiftMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/GiftMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GiftMessage>>> GetGiftMessages()
        {
            return await _context.GiftMessages.ToListAsync();
        }

        // GET: api/GiftMessage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GiftMessage>> GetGiftMessage(int id)
        {
            var giftMessage = await _context.GiftMessages.FindAsync(id);

            if (giftMessage == null)
            {
                return NotFound();
            }

            return giftMessage;
        }
    }
}
