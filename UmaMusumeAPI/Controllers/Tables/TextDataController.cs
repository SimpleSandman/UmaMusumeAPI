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
    public class TextDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TextDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TextData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TextData>>> GetTextData()
        {
            return await _context.TextData.ToListAsync();
        }

        // GET: api/TextData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TextData>> GetTextData(int id)
        {
            var textData = await _context.TextData.FindAsync(id);

            if (textData == null)
            {
                return NotFound();
            }

            return textData;
        }
    }
}
