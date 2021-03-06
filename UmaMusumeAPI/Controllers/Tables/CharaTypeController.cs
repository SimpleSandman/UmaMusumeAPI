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
    public class CharaTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharaTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharaType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharaType>>> GetCharaType()
        {
            return await _context.CharaTypes.ToListAsync();
        }

        // GET: api/CharaType/1
        [HttpGet("{id}")]
        public async Task<ActionResult<CharaType>> GetCharaType(string id)
        {
            var CharaType = await _context.CharaTypes.FindAsync(id);

            if (CharaType == null)
            {
                return NotFound();
            }

            return CharaType;
        }
    }
}
