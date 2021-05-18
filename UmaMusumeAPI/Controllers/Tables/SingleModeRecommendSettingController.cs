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
    public class SingleModeRecommendSettingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRecommendSettingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRecommendSetting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRecommendSetting>>> GetSingleModeRecommendSettings()
        {
            return await _context.SingleModeRecommendSettings.ToListAsync();
        }

        // GET: api/SingleModeRecommendSetting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRecommendSetting>> GetSingleModeRecommendSetting(int id)
        {
            var singleModeRecommendSetting = await _context.SingleModeRecommendSettings.FindAsync(id);

            if (singleModeRecommendSetting == null)
            {
                return NotFound();
            }

            return singleModeRecommendSetting;
        }
    }
}
