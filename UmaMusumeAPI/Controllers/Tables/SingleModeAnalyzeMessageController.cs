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
    public class SingleModeAnalyzeMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAnalyzeMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAnalyzeMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAnalyzeMessage>>> GetSingleModeAnalyzeMessages()
        {
            return await _context.SingleModeAnalyzeMessages.ToListAsync();
        }

        // GET: api/SingleModeAnalyzeMessage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAnalyzeMessage>> GetSingleModeAnalyzeMessage(int id)
        {
            var singleModeAnalyzeMessage = await _context.SingleModeAnalyzeMessages.FindAsync(id);

            if (singleModeAnalyzeMessage == null)
            {
                return NotFound();
            }

            return singleModeAnalyzeMessage;
        }
    }
}
