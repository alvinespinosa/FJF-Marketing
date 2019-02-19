using FJFMarketing.Models.Entities;
using FJFMarketing.Repository.EF.Data;
using FJFMarketing.Repository.EF.Interface;

namespace FJFMarketing.Repository.EF
{
    public class PayableRepository : Repository<Payable>, IPayableRepository
    {
        public PayableRepository(ItemContext context)
              : base(context)
        {
        }
    }
}
