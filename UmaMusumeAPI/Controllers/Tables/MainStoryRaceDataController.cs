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
    public class MainStoryRaceDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryRaceDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryRaceData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryRaceData>>> GetMainStoryRaceData()
        {
            return await _context.MainStoryRaceData.ToListAsync();
        }

        // GET: api/MainStoryRaceData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryRaceData>> GetMainStoryRaceData(int id)
        {
            var mainStoryRaceData = await _context.MainStoryRaceData.FindAsync(id);

            if (mainStoryRaceData == null)
            {
                return NotFound();
            }

            return mainStoryRaceData;
        }
    }
}
