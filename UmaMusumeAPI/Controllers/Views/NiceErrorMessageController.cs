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
        public async Task<ActionResult<IEnumerable<NiceErrorMessage>>> GetNiceErrorMessage(int errorId)
        {
            var niceErrorMessage = await _context.NiceErrorMessages
                .Where(c => c.ErrorId == errorId)
                .ToListAsync();

            if (niceErrorMessage == null)
            {
                return NotFound();
            }

            return niceErrorMessage;
        }
    }
}
