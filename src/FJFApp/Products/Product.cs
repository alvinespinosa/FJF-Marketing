using System;

namespace FJFApp.Model.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Section { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal Fare { get; set; }
        public decimal Srp { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }

        public decimal TotalCost()
        {
            return this.Price + this.Fare;
        }

        public decimal GP()
        {
            return this.Srp - this.TotalCost();
        }

        public decimal Percentage()
        {
            return (this.GP() / this.Srp) *  100;
        }
    }
}
