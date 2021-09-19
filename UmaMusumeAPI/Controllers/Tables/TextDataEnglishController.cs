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
    public class TextDataEnglishController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TextDataEnglishController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TextDataEnglish
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TextDataEnglish>>> GetTextDataEnglish()
        {
            return await _context.TextDataEnglish.ToListAsync();
        }

        // GET: api/TextDataEnglish/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TextDataEnglish>> GetTextDataEnglish(int id)
        {
            var textDataEnglish = await _context.TextDataEnglish.FindAsync(id);

            if (textDataEnglish == null)
            {
                return NotFound();
            }

            return textDataEnglish;
        }
    }
}
