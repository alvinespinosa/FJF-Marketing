using System;

namespace FJFMarketing.Models.Entities
{
    public class Item : BaseEntity
    {
        public Item()
        {
            this.IsActive = true;
        }

        public int SectionId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int UnitId { get; set; }
        public decimal Fare { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SRP { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        //public DateTime? IsActiveAt { get; set; }
    }
}
