using System.Collections.Generic;

namespace FJFMarketing.Models.Entities
{
    public class Purchase : BaseEntity
    {
        public string Supplier { get; set; }
        public List<Purchase> PurchaseItem { get; set; }
    }
}
