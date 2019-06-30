using System;
using System.Collections.Generic;
using System.Linq;

namespace FJFApp.Payables
{
    public class Payable
    {
        public Guid Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PaymentTerms { get; set; }
        public int NotificationDays { get; set; }
        public string Notes { get; set; }
        public bool IsPaid { get; set; }
        public List<PurchaseItem> Items { get; set; }

        public Payable()
        {
            this.Items = new List<PurchaseItem>();
        }

        public decimal GetAmount()
        {
            return this.Items.Sum(_ => _.Price * _.Qty);
        }
    }

    public class PurchaseItem
    {
        public Guid ProductId { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        public decimal GetTotal()
        {
            return this.Price * this.Qty;
        }
    }
}
