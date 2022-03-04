using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ItemExchange
    {
        public int Id { get; set; }
        public int ItemExchangeTopId { get; set; }
        public int DispOrder { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionValue2 { get; set; }
        public int ChangeItemLimitType { get; set; }
        public int ChangeItemLimitNum { get; set; }
        public int ChangeItemCategory { get; set; }
        public int ChangeItemId { get; set; }
        public int ChangeItemNum { get; set; }
        public int AdditionalPieceNum { get; set; }
        public int PayItemCategory { get; set; }
        public int PayItemId { get; set; }
        public int PayItemNum { get; set; }
        public int PriceChangeGroupId { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
