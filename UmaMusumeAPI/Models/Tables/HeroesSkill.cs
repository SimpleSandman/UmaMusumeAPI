using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HeroesSkill
    {
        public int Id { get; set; }
        public int LeagueRankMin { get; set; }
        public int LeagueRankMax { get; set; }
        public int SkillId { get; set; }
        public int Rate { get; set; }
    }
}
