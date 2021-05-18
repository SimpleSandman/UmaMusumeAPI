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
    public class CharacterSystemTextController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharacterSystemTextController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharacterSystemText
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterSystemText>>> GetCharacterSystemTexts()
        {
            return await _context.CharacterSystemTexts.ToListAsync();
        }

        // GET: api/CharacterSystemText/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterSystemText>> GetCharacterSystemText(int id)
        {
            var characterSystemText = await _context.CharacterSystemTexts.FindAsync(id);

            if (characterSystemText == null)
            {
                return NotFound();
            }

            return characterSystemText;
        }
    }
}
