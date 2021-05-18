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
    public class CharacterSystemLotteryController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CharacterSystemLotteryController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CharacterSystemLottery
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterSystemLottery>>> GetCharacterSystemLotteries()
        {
            return await _context.CharacterSystemLotteries.ToListAsync();
        }

        // GET: api/CharacterSystemLottery/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterSystemLottery>> GetCharacterSystemLottery(int id)
        {
            var characterSystemLottery = await _context.CharacterSystemLotteries.FindAsync(id);

            if (characterSystemLottery == null)
            {
                return NotFound();
            }

            return characterSystemLottery;
        }
    }
}
