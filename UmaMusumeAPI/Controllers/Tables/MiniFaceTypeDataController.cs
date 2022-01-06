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
    public class MiniFaceTypeDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public MiniFaceTypeDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/MiniFaceTypeData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiniFaceTypeData>>> GetMiniFaceTypeData()
        {
            return await _context.MiniFaceTypeData.ToListAsync();
        }

        // GET: api/MiniFaceTypeData/5
        [HttpGet("{label}")]
        public async Task<ActionResult<MiniFaceTypeData>> GetMiniFaceTypeData(string label)
        {
            var miniFaceTypeData = await _context.MiniFaceTypeData.FindAsync(label);

            if (miniFaceTypeData == null)
            {
                return NotFound();
            }

            return miniFaceTypeData;
        }
    }
}
