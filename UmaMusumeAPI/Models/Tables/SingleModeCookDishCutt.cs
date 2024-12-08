using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookDishCutt
    {
        public int Id { get; set; }
        public int CommandGroupId { get; set; }
        public int MaterialGroupId { get; set; }
        public int IsSuccess { get; set; }
        public string CuttId { get; set; }
        public string PropId { get; set; }
    }
}