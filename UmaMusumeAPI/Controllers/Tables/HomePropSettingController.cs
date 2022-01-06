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
    public class HomePropSettingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomePropSettingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomePropSetting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomePropSetting>>> GetHomePropSettings()
        {
            return await _context.HomePropSettings.ToListAsync();
        }

        // GET: api/HomePropSetting/5
        [HttpGet("{posId}")]
        public async Task<ActionResult<IEnumerable<HomePropSetting>>> GetHomePropSetting(int posId)
        {
            var homePropSetting = await _context.HomePropSettings
                .Where(c => c.PosId == posId)
                .ToListAsync();

            if (homePropSetting == null)
            {
                return NotFound();
            }

            return homePropSetting;
        }
    }
}
