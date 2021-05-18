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
    public class TrainedCharaTradeItemController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainedCharaTradeItemController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainedCharaTradeItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainedCharaTradeItem>>> GetTrainedCharaTradeItems()
        {
            return await _context.TrainedCharaTradeItems.ToListAsync();
        }

        // GET: api/TrainedCharaTradeItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainedCharaTradeItem>> GetTrainedCharaTradeItem(int id)
        {
            var trainedCharaTradeItem = await _context.TrainedCharaTradeItems.FindAsync(id);

            if (trainedCharaTradeItem == null)
            {
                return NotFound();
            }

            return trainedCharaTradeItem;
        }
    }
}
