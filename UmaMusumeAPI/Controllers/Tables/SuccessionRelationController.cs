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
    public class SuccessionRelationController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionRelationController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionRelation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionRelation>>> GetSuccessionRelations()
        {
            return await _context.SuccessionRelations.ToListAsync();
        }

        // GET: api/SuccessionRelation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionRelation>> GetSuccessionRelation(int relationType)
        {
            var successionRelation = await _context.SuccessionRelations.FindAsync(relationType);

            if (successionRelation == null)
            {
                return NotFound();
            }

            return successionRelation;
        }
    }
}
