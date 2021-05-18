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
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeDifficultyData>> GetSingleModeDifficultyData(int id)
        {
            var singleModeDifficultyData = await _context.SingleModeDifficultyData.FindAsync(id);

            if (singleModeDifficultyData == null)
            {
                return NotFound();
            }

            return singleModeDifficultyData;
        }
    }
}
