using System;
using System.Collections.Generic;
using System.Text;

namespace FJFMarketing.Repository.EF.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IItemRepository Items { get; }

        void Save();
    }
}
