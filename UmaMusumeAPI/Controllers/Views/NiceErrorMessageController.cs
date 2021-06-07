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
    public class NiceErrorMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceErrorMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceErrorMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceErrorMessage>>> GetNiceErrorMessages()
        {
            return await _context.NiceErrorMessages.ToListAsync();
        }

        // GET: api/NiceErrorMessage/5
        [HttpGet("{errorId}")]
        public async Task<ActionResult<NiceErrorMessage>> GetNiceErrorMessage(int errorId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceErrorMessage = await _context.NiceErrorMessages.SingleOrDefaultAsync(c => c.ErrorId == errorId);

            if (niceErrorMessage == null)
            {
                return NotFound();
            }

            return niceErrorMessage;
        }
    }
}
