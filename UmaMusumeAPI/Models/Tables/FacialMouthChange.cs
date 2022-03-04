using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class FacialMouthChange
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public string BeforeFacialname { get; set; }
        public string AfterFacialname { get; set; }
    }
}
