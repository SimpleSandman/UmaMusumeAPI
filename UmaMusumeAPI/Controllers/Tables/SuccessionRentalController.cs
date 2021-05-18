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
    public class SuccessionRentalController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionRentalController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionRental
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionRental>>> GetSuccessionRentals()
        {
            return await _context.SuccessionRentals.ToListAsync();
        }

        // GET: api/SuccessionRental/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionRental>> GetSuccessionRental(int id)
        {
            var successionRental = await _context.SuccessionRentals.FindAsync(id);

            if (successionRental == null)
            {
                return NotFound();
            }

            return successionRental;
        }
    }
}
