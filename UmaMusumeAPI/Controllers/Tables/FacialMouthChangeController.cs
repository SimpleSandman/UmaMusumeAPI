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
    public class FacialMouthChangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public FacialMouthChangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/FacialMouthChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacialMouthChange>>> GetFacialMouthChanges()
        {
            return await _context.FacialMouthChanges.ToListAsync();
        }

        // GET: api/FacialMouthChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacialMouthChange>> GetFacialMouthChange(int id)
        {
            var facialMouthChange = await _context.FacialMouthChanges.FindAsync(id);

            if (facialMouthChange == null)
            {
                return NotFound();
            }

            return facialMouthChange;
        }
    }
}
