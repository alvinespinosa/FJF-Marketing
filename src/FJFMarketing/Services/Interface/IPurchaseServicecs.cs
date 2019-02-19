using FJFMarketing.Models.Entities;
using System.Collections.Generic;

namespace FJFMarketing.Services.Interface
{
    public interface IPurchaseServicecs
    {
        bool AddPurchase(Purchase purchase);
        IEnumerable<Purchase> GetAllPurchase();
        Purchase GetPurchaseById(string id);
        bool UpdatePurchase(string id, Purchase purchase);
    }
}
