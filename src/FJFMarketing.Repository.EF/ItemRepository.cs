using FJFMarketing.Models.Entities;
using FJFMarketing.Repository.EF.Data;
using FJFMarketing.Repository.EF.Interface;

namespace FJFMarketing.Repository.EF
{
    // This is to extend the Item entity.
    public class ItemRepository :  Repository<Item>, IItemRepository
    {
        public ItemRepository(ItemContext context) 
            : base(context)
        {
        }
    }
}
