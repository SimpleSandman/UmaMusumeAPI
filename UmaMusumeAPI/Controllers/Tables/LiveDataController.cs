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
    public class LiveDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LiveDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LiveData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LiveData>>> GetLiveData()
        {
            return await _context.LiveData.ToListAsync();
        }

        // GET: api/LiveData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LiveData>> GetLiveData(int id)
        {
            var liveData = await _context.LiveData.FindAsync(id);

            if (liveData == null)
            {
                return NotFound();
            }

            return liveData;
        }
    }
}
