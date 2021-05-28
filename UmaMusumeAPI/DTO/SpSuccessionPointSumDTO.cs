namespace UmaMusumeAPI.DTO
{
    public class SpSuccessionPointSumDTO
    {
        /// <example>1008</example>
        public long Child { get; set; }

        /// <example>1011</example>
        public long Parent1 { get; set; }

        /// <example>1008</example>
        public long Grandparent1A { get; set; }

        /// <example>1009</example>
        public long Grandparent1B { get; set; }

        /// <example>1014</example>
        public long Parent2 { get; set; }

        /// <example>1009</example>
        public long Grandparent2A { get; set; }

        /// <example>1011</example>
        public long Grandparent2B { get; set; }
    }
}
