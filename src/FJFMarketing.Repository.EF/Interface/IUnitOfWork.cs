using System;
using System.Collections.Generic;
using System.Text;

namespace FJFMarketing.Repository.EF.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository Items { get; }
        IPayableRepository Payables { get; }
        IPurchaseRepository Purchases { get; }

        void Save();
    }
}
