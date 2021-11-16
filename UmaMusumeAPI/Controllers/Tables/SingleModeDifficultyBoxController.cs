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
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeDifficultyBox>> GetSingleModeDifficultyBox(int id)
        {
            var singleModeDifficultyBox = await _context.SingleModeDifficultyBoxes.FindAsync(id);

            if (singleModeDifficultyBox == null)
            {
                return NotFound();
            }

            return singleModeDifficultyBox;
        }
    }
}
