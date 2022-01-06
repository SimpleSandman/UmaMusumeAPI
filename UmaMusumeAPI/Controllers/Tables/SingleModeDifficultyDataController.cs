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
    public class SingleModeDifficultyDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeDifficultyDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeDifficultyData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyData>>> GetSingleModeDifficultyData()
        {
            return await _context.SingleModeDifficultyData.ToListAsync();
        }

        // GET: api/SingleModeDifficultyData/5
        [HttpGet("{difficultyId}")]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyData>>> GetSingleModeDifficultyData(int difficultyId)
        {
            var singleModeDifficultyData = await _context.SingleModeDifficultyData
                .Where(c => c.DifficultyId == difficultyId)
                .ToListAsync();

            if (singleModeDifficultyData == null)
            {
                return NotFound();
            }

            return singleModeDifficultyData;
        }
    }
}
