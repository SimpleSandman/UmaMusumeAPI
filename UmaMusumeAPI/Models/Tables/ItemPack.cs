using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ItemPack
    {
        public int Id { get; set; }
        public int ItemPackId { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
