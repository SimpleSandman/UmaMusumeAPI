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
    public class LegendRaceBillingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LegendRaceBillingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LegendRaceBilling
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegendRaceBilling>>> GetLegendRaceBillings()
        {
            return await _context.LegendRaceBillings.ToListAsync();
        }

        // GET: api/LegendRaceBilling/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegendRaceBilling>> GetLegendRaceBilling(int id)
        {
            var legendRaceBilling = await _context.LegendRaceBillings.FindAsync(id);

            if (legendRaceBilling == null)
            {
                return NotFound();
            }

            return legendRaceBilling;
        }
    }
}
