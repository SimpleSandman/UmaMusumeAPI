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
    public class DailyRaceBillingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public DailyRaceBillingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/DailyRaceBilling
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyRaceBilling>>> GetDailyRaceBillings()
        {
            return await _context.DailyRaceBillings.ToListAsync();
        }

        // GET: api/DailyRaceBilling/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyRaceBilling>> GetDailyRaceBilling(int id)
        {
            var dailyRaceBilling = await _context.DailyRaceBillings.FindAsync(id);

            if (dailyRaceBilling == null)
            {
                return NotFound();
            }

            return dailyRaceBilling;
        }
    }
}
