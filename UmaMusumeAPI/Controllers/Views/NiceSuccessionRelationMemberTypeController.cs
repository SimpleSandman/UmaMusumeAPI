using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Controllers.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class NiceSuccessionRelationMemberTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceSuccessionRelationMemberTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceSuccessionRelationMemberType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceSuccessionRelationMemberType>>> GetNiceSuccessionRelationMemberTypes()
        {
            return await _context.NiceSuccessionRelationMemberTypes.ToListAsync();
        }

        // GET: api/NiceSuccessionRelationMemberType/5
        [HttpGet("{srmId}")]
        public async Task<ActionResult<NiceSuccessionRelationMemberType>> GetNiceSuccessionRelationMemberType(int srmId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceSuccessionRelationMemberType = await _context.NiceSuccessionRelationMemberTypes.SingleOrDefaultAsync(c => c.SrmId == srmId);

            if (niceSuccessionRelationMemberType == null)
            {
                return NotFound();
            }

            return niceSuccessionRelationMemberType;
        }
    }
}
