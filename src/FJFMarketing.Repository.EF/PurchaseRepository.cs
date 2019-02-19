using FJFMarketing.Models.Entities;
using FJFMarketing.Repository.EF.Data;
using FJFMarketing.Repository.EF.Interface;

namespace FJFMarketing.Repository.EF
{
    public class PurchaseRepository : Repository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(ItemContext context)
                 : base(context)
        {
        }
    }
}
