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
    public class RacePlayerCameraController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RacePlayerCameraController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RacePlayerCamera
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RacePlayerCamera>>> GetRacePlayerCameras()
        {
            return await _context.RacePlayerCameras.ToListAsync();
        }

        // GET: api/RacePlayerCamera/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RacePlayerCamera>> GetRacePlayerCamera(int id)
        {
            var racePlayerCamera = await _context.RacePlayerCameras.FindAsync(id);

            if (racePlayerCamera == null)
            {
                return NotFound();
            }

            return racePlayerCamera;
        }
    }
}
