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
    public class NiceTutorialMessageController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceTutorialMessageController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceTutorialMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceTutorialMessage>>> GetNiceTutorialMessages()
        {
            return await _context.NiceTutorialMessages.ToListAsync();
        }

        // GET: api/NiceTutorialMessage/5
        [HttpGet("{tutorialId}")]
        public async Task<ActionResult<NiceTutorialMessage>> GetNiceTutorialMessage(int tutorialId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceTutorialMessage = await _context.NiceTutorialMessages.SingleOrDefaultAsync(c => c.TutorialId == tutorialId);

            if (niceTutorialMessage == null)
            {
                return NotFound();
            }

            return niceTutorialMessage;
        }
    }
}
