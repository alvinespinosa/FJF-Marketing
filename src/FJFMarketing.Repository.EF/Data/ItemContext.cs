using FJFMarketing.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
