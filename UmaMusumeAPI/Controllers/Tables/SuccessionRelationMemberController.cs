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
    public class SuccessionRelationMemberController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionRelationMemberController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionRelationMember
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionRelationMember>>> GetSuccessionRelationMembers()
        {
            return await _context.SuccessionRelationMembers.ToListAsync();
        }

        // GET: api/SuccessionRelationMember/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionRelationMember>> GetSuccessionRelationMember(int id)
        {
            var successionRelationMember = await _context.SuccessionRelationMembers.FindAsync(id);

            if (successionRelationMember == null)
            {
                return NotFound();
            }

            return successionRelationMember;
        }
    }
}
