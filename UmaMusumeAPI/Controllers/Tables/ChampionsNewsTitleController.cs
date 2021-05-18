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
    public class ChampionsNewsTitleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsNewsTitleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsNewsTitle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsNewsTitle>>> GetChampionsNewsTitles()
        {
            return await _context.ChampionsNewsTitles.ToListAsync();
        }

        // GET: api/ChampionsNewsTitle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsNewsTitle>> GetChampionsNewsTitle(int id)
        {
            var championsNewsTitle = await _context.ChampionsNewsTitles.FindAsync(id);

            if (championsNewsTitle == null)
            {
                return NotFound();
            }

            return championsNewsTitle;
        }
    }
}
