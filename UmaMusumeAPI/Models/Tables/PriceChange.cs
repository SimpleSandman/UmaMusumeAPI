using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class PriceChange
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int MinNum { get; set; }
        public int MaxNum { get; set; }
        public int PayItemNum { get; set; }
    }
}
