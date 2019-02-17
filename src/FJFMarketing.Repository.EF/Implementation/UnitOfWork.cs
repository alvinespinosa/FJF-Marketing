using FJFMarketing.Repository.EF.Data;
using FJFMarketing.Repository.EF.Interface;

namespace FJFMarketing.Repository.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        public IItemRepository Items { get; private set; }

        private readonly ItemContext _context;

        public UnitOfWork(ItemContext context,
            IItemRepository items)
        {
            _context = context;
            Items = items;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
