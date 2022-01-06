using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class GachaStockDetail
    {
        public int Id { get; set; }
        public long GachaStockId { get; set; }
        public long GachaId { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
