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
    public class SupportCardEffectFilterGroupController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardEffectFilterGroupController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardEffectFilterGroup
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardEffectFilterGroup>>> GetSupportCardEffectFilterGroups()
        {
            return await _context.SupportCardEffectFilterGroups.ToListAsync();
        }

        // GET: api/SupportCardEffectFilterGroup/5
        [HttpGet("{groupId}")]
        public async Task<ActionResult<SupportCardEffectFilterGroup>> GetSupportCardEffectFilterGroup(int groupId)
        {
            var supportCardEffectFilterGroup = await _context.SupportCardEffectFilterGroups.FindAsync(groupId);

            if (supportCardEffectFilterGroup == null)
            {
                return NotFound();
            }

            return supportCardEffectFilterGroup;
        }
    }
}
