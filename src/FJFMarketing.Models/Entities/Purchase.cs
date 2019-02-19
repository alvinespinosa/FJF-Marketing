using System.Collections.Generic;

namespace FJFMarketing.Models.Entities
{
    public class Purchase : BaseEntity
    {
        public string Notes { get; set; }
        public List<PurchaseItem> Items { get; set; }
    }
}
