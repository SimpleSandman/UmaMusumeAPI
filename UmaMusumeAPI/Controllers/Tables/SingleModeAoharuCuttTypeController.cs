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
    public class SingleModeAoharuCuttTypeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeAoharuCuttTypeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeAoharuCuttType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeAoharuCuttType>>> GetSingleModeAoharuCuttTypes()
        {
            return await _context.SingleModeAoharuCuttTypes.ToListAsync();
        }

        // GET: api/SingleModeAoharuCuttType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeAoharuCuttType>> GetSingleModeAoharuCuttType(int id)
        {
            var singleModeAoharuCuttType = await _context.SingleModeAoharuCuttTypes.FindAsync(id);

            if (singleModeAoharuCuttType == null)
            {
                return NotFound();
            }

            return singleModeAoharuCuttType;
        }
    }
}
