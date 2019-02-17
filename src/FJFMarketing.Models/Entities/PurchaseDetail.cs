using System;

namespace FJFMarketing.Models.Entities
{
    public class PurchaseDetail
    {
        public Guid Id { get; set; }
        public Item Item { get; set; }
        public int Qty { get; set; }
    }
}
