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
    public class LivePermissionDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LivePermissionDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LivePermissionData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LivePermissionData>>> GetLivePermissionData()
        {
            return await _context.LivePermissionData.ToListAsync();
        }

        // GET: api/LivePermissionData/5
        [HttpGet("{musicId}")]
        public async Task<ActionResult<IEnumerable<LivePermissionData>>> GetLivePermissionData(int musicId)
        {
            var livePermissionData = await _context.LivePermissionData
                .Where(c => c.MusicId == musicId)
                .ToListAsync();

            if (livePermissionData == null)
            {
                return NotFound();
            }

            return livePermissionData;
        }
    }
}
