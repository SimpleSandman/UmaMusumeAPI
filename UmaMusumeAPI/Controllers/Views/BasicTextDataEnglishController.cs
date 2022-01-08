using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.DTO;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Controllers.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicTextDataEnglishController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicTextDataEnglishController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicTextDataEnglish
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicTextDataEnglish>>> GetBasicTextDataEnglish()
        {
            return await _context.BasicTextDataEnglish.ToListAsync();
        }

        // GET: api/BasicTextDataEnglish/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<BasicTextDataEnglish>>> GetBasicTextDataEnglish(long id)
        {
            var basicTextDataEnglish = await _context.BasicTextDataEnglish
                .Where(c => c.Id == id)
                .ToListAsync();

            if (basicTextDataEnglish == null)
            {
                return NotFound();
            }

            return basicTextDataEnglish;
        }

        // GET: api/BasicTextDataEnglish/5/5
        [HttpGet("{category}/{index}")]
        public async Task<ActionResult<IEnumerable<BasicTextDataEnglish>>> GetBasicTextDataEnglish(int category, int index)
        {
            var basicTextDataEnglish = await _context.BasicTextDataEnglish
                .Where(c => c.Category == category && c.Index == index)
                .ToListAsync();

            if (basicTextDataEnglish == null)
            {
                return NotFound();
            }

            return basicTextDataEnglish;
        }

        // POST: api/BasicTextDataEnglish
        [HttpPost]
        public async Task<ActionResult<IEnumerable<BasicTextDataEnglish>>> GetBasicTextDataEnglish([FromBody] BasicTextEnglishDTO body)
        {
            List<BasicTextDataEnglish> basicTextDataEnglish = new List<BasicTextDataEnglish>();

            if (body.IsEnglishQuery)
            {
                basicTextDataEnglish = await _context.BasicTextDataEnglish
                    .Where(c => c.Translation.Contains(body.SearchQuery))
                    .ToListAsync();
            }
            else
            {
                basicTextDataEnglish = await _context.BasicTextDataEnglish
                    .Where(c => c.Text.Contains(body.SearchQuery))
                    .ToListAsync();
            }

            if (basicTextDataEnglish == null)
            {
                return NotFound();
            }

            return basicTextDataEnglish;
        }
    }
}
