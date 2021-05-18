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
    public class MainStoryRaceCharaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryRaceCharaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryRaceCharaData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryRaceCharaData>>> GetMainStoryRaceCharaData()
        {
            return await _context.MainStoryRaceCharaData.ToListAsync();
        }

        // GET: api/MainStoryRaceCharaData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryRaceCharaData>> GetMainStoryRaceCharaData(int id)
        {
            var mainStoryRaceCharaData = await _context.MainStoryRaceCharaData.FindAsync(id);

            if (mainStoryRaceCharaData == null)
            {
                return NotFound();
            }

            return mainStoryRaceCharaData;
        }
    }
}
