using FJFMarketing.Models.Entities;
using FJFMarketing.Repository.Dapper.Interface;
using FJFMarketing.Repository.EF.Interface;
using FJFMarketing.Services.Interface;
using System;
using System.Collections.Generic;

namespace FJFMarketing.Services
{
    public class PurchaseService : IPurchaseServicecs
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Read only parameter that makes use of dapper
        /// </summary>
        private readonly IReadOnlyRepository<Purchase> _purchaseRepository;

        public bool AddPurchase(Purchase purchase)
        {
            purchase.CreatedAt = DateTime.UtcNow;
            purchase.CreatedBy = "AI";
            purchase.ModifiedAt = DateTime.UtcNow;
            purchase.ModifiedBy = "AI";

            try
            {
                _unitOfWork.Purchases.Add(purchase);
                _unitOfWork.Save();
            }
            catch
            {
                // Todo: create logging
                return false;
            }

            // Todo: create logging
            return true;
        }

        public IEnumerable<Purchase> GetAllPurchase()
        {
            return _purchaseRepository.GetAll();
        }

        public Purchase GetPurchaseById(string id)
        {
            return _purchaseRepository.FindById(id);
        }

        public bool UpdatePurchase(string id, Purchase purchase)
        {

            try
            {
                purchase.Id = Guid.Parse(id);
                _unitOfWork.Purchases.Update(purchase);
                _unitOfWork.Save();
            }
            catch
            {
                // ToDo: create logging
                return false;
            }

            // ToDo: create logging
            return true;
        }
    }
}
