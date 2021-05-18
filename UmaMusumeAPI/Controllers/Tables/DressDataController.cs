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
    public class DressDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DressDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DressData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DressData>>> GetDressData()
        {
            return await _context.DressData.ToListAsync();
        }

        // GET: api/DressData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DressData>> GetDressData(int id)
        {
            var dressData = await _context.DressData.FindAsync(id);

            if (dressData == null)
            {
                return NotFound();
            }

            return dressData;
        }
    }
}
