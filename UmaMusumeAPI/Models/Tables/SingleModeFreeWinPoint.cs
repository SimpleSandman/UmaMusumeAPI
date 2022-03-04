using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeFreeWinPoint
    {
        public int Id { get; set; }
        public int RaceGroupId { get; set; }
        public int Grade { get; set; }
        public int OrderMin { get; set; }
        public int OrderMax { get; set; }
        public int PointNum { get; set; }
    }
}
