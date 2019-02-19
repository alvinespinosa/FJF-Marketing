using FJFMarketing.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FJFMarketing.Repository.EF.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> opt)
           : base(opt)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Payable> Payables { get; set; }
        public virtual DbSet<Payable> Purchases { get; set; }
        public virtual DbSet<PurchaseItem> PurchaseItems { get; set; }
    }
}
