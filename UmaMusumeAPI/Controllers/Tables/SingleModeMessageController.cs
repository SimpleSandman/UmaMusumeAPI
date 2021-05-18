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
    public class SingleModeMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeMessage>>> GetSingleModeMessages()
        {
            return await _context.SingleModeMessages.ToListAsync();
        }

        // GET: api/SingleModeMessage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeMessage>> GetSingleModeMessage(int id)
        {
            var singleModeMessage = await _context.SingleModeMessages.FindAsync(id);

            if (singleModeMessage == null)
            {
                return NotFound();
            }

            return singleModeMessage;
        }
    }
}
