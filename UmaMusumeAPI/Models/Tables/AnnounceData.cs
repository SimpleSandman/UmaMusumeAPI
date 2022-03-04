using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class AnnounceData
    {
        public int Id { get; set; }
        public int AnnounceType { get; set; }
        public int AnnounceId { get; set; }
        public int Priority { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
