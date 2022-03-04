using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class GachaStockDetail
    {
        public int Id { get; set; }
        public int GachaStockId { get; set; }
        public int GachaId { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
