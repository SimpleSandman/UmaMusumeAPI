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
    public class ChampionsNewsTrainerDetailController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsTrainerDetailController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsTrainerDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsTrainerDetail>>> GetChampionsNewsTrainerDetails()
        {
            return await _context.ChampionsNewsTrainerDetails.ToListAsync();
        }

        // GET: api/ChampionsNewsTrainerDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsTrainerDetail>> GetChampionsNewsTrainerDetail(int id)
        {
            var championsNewsTrainerDetail = await _context.ChampionsNewsTrainerDetails.FindAsync(id);

            if (championsNewsTrainerDetail == null)
            {
                return NotFound();
            }

            return championsNewsTrainerDetail;
        }
    }
}
