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
    public class CharaStoryDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaStoryDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaStoryData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaStoryData>>> GetCharaStoryData()
        {
            return await _context.CharaStoryData.ToListAsync();
        }

        // GET: api/CharaStoryData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaStoryData>> GetCharaStoryData(int id)
        {
            var charaStoryData = await _context.CharaStoryData.FindAsync(id);

            if (charaStoryData == null)
            {
                return NotFound();
            }

            return charaStoryData;
        }
    }
}
