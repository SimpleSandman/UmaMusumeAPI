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
    public class NoteProfileController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NoteProfileController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NoteProfile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoteProfile>>> GetNoteProfiles()
        {
            return await _context.NoteProfiles.ToListAsync();
        }

        // GET: api/NoteProfile/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NoteProfile>> GetNoteProfile(int id)
        {
            var noteProfile = await _context.NoteProfiles.FindAsync(id);

            if (noteProfile == null)
            {
                return NotFound();
            }

            return noteProfile;
        }
    }
}
