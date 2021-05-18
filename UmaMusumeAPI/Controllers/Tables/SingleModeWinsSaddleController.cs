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
    public class SingleModeWinsSaddleController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeWinsSaddleController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeWinsSaddle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeWinsSaddle>>> GetSingleModeWinsSaddles()
        {
            return await _context.SingleModeWinsSaddles.ToListAsync();
        }

        // GET: api/SingleModeWinsSaddle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeWinsSaddle>> GetSingleModeWinsSaddle(int id)
        {
            var singleModeWinsSaddle = await _context.SingleModeWinsSaddles.FindAsync(id);

            if (singleModeWinsSaddle == null)
            {
                return NotFound();
            }

            return singleModeWinsSaddle;
        }
    }
}
