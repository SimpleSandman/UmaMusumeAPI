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
    public class BannerDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BannerDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BannerData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BannerData>>> GetBannerData()
        {
            return await _context.BannerData.ToListAsync();
        }

        // GET: api/BannerData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BannerData>> GetBannerData(int id)
        {
            var bannerData = await _context.BannerData.FindAsync(id);

            if (bannerData == null)
            {
                return NotFound();
            }

            return bannerData;
        }
    }
}
