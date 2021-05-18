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
    public class SingleModeStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeStoryData>>> GetSingleModeStoryData()
        {
            return await _context.SingleModeStoryData.ToListAsync();
        }

        // GET: api/SingleModeStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeStoryData>> GetSingleModeStoryData(int id)
        {
            var singleModeStoryData = await _context.SingleModeStoryData.FindAsync(id);

            if (singleModeStoryData == null)
            {
                return NotFound();
            }

            return singleModeStoryData;
        }
    }
}
