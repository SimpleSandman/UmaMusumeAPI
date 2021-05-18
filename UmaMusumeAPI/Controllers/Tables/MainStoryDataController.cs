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
    public class MainStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MainStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MainStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainStoryData>>> GetMainStoryData()
        {
            return await _context.MainStoryData.ToListAsync();
        }

        // GET: api/MainStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MainStoryData>> GetMainStoryData(int id)
        {
            var mainStoryData = await _context.MainStoryData.FindAsync(id);

            if (mainStoryData == null)
            {
                return NotFound();
            }

            return mainStoryData;
        }
    }
}
