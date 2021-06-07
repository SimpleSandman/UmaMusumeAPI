namespace UmaMusumeAPI.Models.Tables
{
    public partial class FacialMouthChange
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public string BeforeFacialname { get; set; }
        public string AfterFacialname { get; set; }
    }
}
