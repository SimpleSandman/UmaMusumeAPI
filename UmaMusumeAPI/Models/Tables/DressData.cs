using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class DressData
    {
        public int Id { get; set; }
        public int ConditionType { get; set; }
        public int HaveMini { get; set; }
        public int GeneralPurpose { get; set; }
        public int CharaId { get; set; }
        public int UseGender { get; set; }
        public int BodyShape { get; set; }
        public int BodyType { get; set; }
        public int BodyTypeSub { get; set; }
        public int BodySetting { get; set; }
        public int UseRace { get; set; }
        public int UseLive { get; set; }
        public int UseLiveTheater { get; set; }
        public int UseHome { get; set; }
        public int IsWet { get; set; }
        public int IsDirt { get; set; }
        public int HeadSubId { get; set; }
        public int UseSeason { get; set; }
        public string DressColorMain { get; set; }
        public string DressColorSub { get; set; }
        public int ColorNum { get; set; }
        public int DispOrder { get; set; }
        public int TailModelId { get; set; }
        public int TailModelSubId { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int CostumeType { get; set; }
        public int UseDressChange { get; set; }
    }
}
