using System;

namespace FJFMarketing.Models.Entities
{
    public class PurchaseItem
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
    }
}
