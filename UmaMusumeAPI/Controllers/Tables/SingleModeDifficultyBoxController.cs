using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleModeDifficultyBoxController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeDifficultyBoxController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeDifficultyBox
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyBox>>> GetSingleModeDifficultyBoxes()
        {
            return await _context.SingleModeDifficultyBoxes.ToListAsync();
        }

        // GET: api/SingleModeDifficultyBox/5
        [HttpGet("{rewardSetId}")]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyBox>>> GetSingleModeDifficultyBox(int rewardSetId)
        {
            var singleModeDifficultyBox = await _context.SingleModeDifficultyBoxes
                .Where(c => c.RewardSetId == rewardSetId)
                .ToListAsync();

            if (singleModeDifficultyBox == null)
            {
                return NotFound();
            }

            return singleModeDifficultyBox;
        }
    }
}
