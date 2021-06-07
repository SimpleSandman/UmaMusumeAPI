namespace UmaMusumeAPI.Models.Tables
{
    public partial class ItemExchange
    {
        public int Id { get; set; }
        public long ItemExchangeTopId { get; set; }
        public long DispOrder { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long ChangeItemLimitType { get; set; }
        public long ChangeItemLimitNum { get; set; }
        public long ChangeItemCategory { get; set; }
        public long ChangeItemId { get; set; }
        public long ChangeItemNum { get; set; }
        public long AdditionalPieceNum { get; set; }
        public long PayItemCategory { get; set; }
        public long PayItemId { get; set; }
        public long PayItemNum { get; set; }
        public long PriceChangeGroupId { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
