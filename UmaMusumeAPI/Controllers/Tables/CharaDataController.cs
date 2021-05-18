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
    public class CharaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaData>>> GetCharaData()
        {
            return await _context.CharaData.ToListAsync();
        }

        // GET: api/CharaData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaData>> GetCharaData(int id)
        {
            var charaData = await _context.CharaData.FindAsync(id);

            if (charaData == null)
            {
                return NotFound();
            }

            return charaData;
        }
    }
}
