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
    public class HonorDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public HonorDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/HonorData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HonorData>>> GetHonorData()
        {
            return await _context.HonorData.ToListAsync();
        }

        // GET: api/HonorData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HonorData>> GetHonorData(int id)
        {
            var honorData = await _context.HonorData.FindAsync(id);

            if (honorData == null)
            {
                return NotFound();
            }

            return honorData;
        }
    }
}
