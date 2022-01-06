using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeMemberRank
    {
        public int Id { get; set; }
        public long ValueMin { get; set; }
        public long ValueMax { get; set; }
        public long MemberRankId { get; set; }
    }
}
