﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Controllers.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicStoryEventMissionInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicStoryEventMissionInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicStoryEventMissionInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicStoryEventMissionInfo>>> GetBasicStoryEventMissionInfos()
        {
            return await _context.BasicStoryEventMissionInfos.ToListAsync();
        }

        // GET: api/BasicStoryEventMissionInfo/5
        [HttpGet("{storyEventMissionId}")]
        public async Task<ActionResult<BasicStoryEventMissionInfo>> GetBasicStoryEventMissionInfo(int storyEventMissionId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicStoryEventMissionInfo = await _context.BasicStoryEventMissionInfos.SingleOrDefaultAsync(c => c.StoryEventMissionId == storyEventMissionId);

            if (basicStoryEventMissionInfo == null)
            {
                return NotFound();
            }

            return basicStoryEventMissionInfo;
        }
    }
}
