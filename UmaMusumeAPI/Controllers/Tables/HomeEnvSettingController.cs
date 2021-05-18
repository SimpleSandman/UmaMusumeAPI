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
    public class HomeEnvSettingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HomeEnvSettingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HomeEnvSetting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HomeEnvSetting>>> GetHomeEnvSettings()
        {
            return await _context.HomeEnvSettings.ToListAsync();
        }

        // GET: api/HomeEnvSetting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HomeEnvSetting>> GetHomeEnvSetting(int id)
        {
            var homeEnvSetting = await _context.HomeEnvSettings.FindAsync(id);

            if (homeEnvSetting == null)
            {
                return NotFound();
            }

            return homeEnvSetting;
        }
    }
}
