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
        [HttpGet("{id}")]
        public async Task<ActionResult<LivePermissionData>> GetLivePermissionData(int id)
        {
            var livePermissionData = await _context.LivePermissionData.FindAsync(id);

            if (livePermissionData == null)
            {
                return NotFound();
            }

            return livePermissionData;
        }
    }
}
