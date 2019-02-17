using FJFMarketing.Models.Enums;
using System;

namespace FJFMarketing.Models.Entities
{
    public class Payable: BaseEntity
    {
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public Terms Terms { get; set; }
        public int NotificationDays { get; set; }
    }
}
