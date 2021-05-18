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
    public class NoteProfileTextTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NoteProfileTextTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NoteProfileTextType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoteProfileTextType>>> GetNoteProfileTextTypes()
        {
            return await _context.NoteProfileTextTypes.ToListAsync();
        }

        // GET: api/NoteProfileTextType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NoteProfileTextType>> GetNoteProfileTextType(int id)
        {
            var noteProfileTextType = await _context.NoteProfileTextTypes.FindAsync(id);

            if (noteProfileTextType == null)
            {
                return NotFound();
            }

            return noteProfileTextType;
        }
    }
}
