using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeFreeWinPoint
    {
        public int Id { get; set; }
        public long RaceGroupId { get; set; }
        public long Grade { get; set; }
        public long OrderMin { get; set; }
        public long OrderMax { get; set; }
        public long PointNum { get; set; }
    }
}
