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
    public class MissionDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MissionDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MissionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MissionData>>> GetMissionData()
        {
            return await _context.MissionData.ToListAsync();
        }

        // GET: api/MissionData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MissionData>> GetMissionData(int id)
        {
            var missionData = await _context.MissionData.FindAsync(id);

            if (missionData == null)
            {
                return NotFound();
            }

            return missionData;
        }
    }
}
