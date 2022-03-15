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
    public class FaceTypeDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public FaceTypeDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/FaceTypeData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaceTypeData>>> GetFaceTypeData()
        {
            return await _context.FaceTypeData.ToListAsync();
        }

        // GET: api/FaceTypeData/Base
        [HttpGet("{label}")]
        public async Task<ActionResult<FaceTypeData>> GetFaceTypeData(string label)
        {
            var faceTypeData = await _context.FaceTypeData.FindAsync(label);

            if (faceTypeData == null)
            {
                return NotFound();
            }

            return faceTypeData;
        }
    }
}
