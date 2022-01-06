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
    public class MobDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MobDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MobData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MobData>>> GetMobData()
        {
            return await _context.MobData.ToListAsync();
        }

        // GET: api/MobData/5
        [HttpGet("{mobId}")]
        public async Task<ActionResult<MobData>> GetMobData(int mobId)
        {
            var mobData = await _context.MobData.FindAsync(mobId);

            if (mobData == null)
            {
                return NotFound();
            }

            return mobData;
        }
    }
}
