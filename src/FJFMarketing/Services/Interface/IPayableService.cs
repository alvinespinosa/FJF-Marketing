using FJFMarketing.Models.Entities;
using System.Collections.Generic;

namespace FJFMarketing.Services.Interface
{
    public interface IPayableService
    {
        bool AddPayable(Payable payable);
        IEnumerable<Payable> GetAllPayable();
        Payable GetPayableById(string id);
        bool UpdatePayable(string id, Payable payable);
    }
}
