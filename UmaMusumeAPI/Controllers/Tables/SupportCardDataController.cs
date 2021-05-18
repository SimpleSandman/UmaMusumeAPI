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
    public class SupportCardDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardData>>> GetSupportCardData()
        {
            return await _context.SupportCardData.ToListAsync();
        }

        // GET: api/SupportCardData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardData>> GetSupportCardData(int id)
        {
            var supportCardData = await _context.SupportCardData.FindAsync(id);

            if (supportCardData == null)
            {
                return NotFound();
            }

            return supportCardData;
        }
    }
}
