using FJFMarketing.Models.Entities;
using FJFMarketing.Repository.Dapper.Interface;
using FJFMarketing.Repository.EF.Interface;
using FJFMarketing.Services.Interface;
using System;
using System.Collections.Generic;

namespace FJFMarketing.Services
{
    public class PayableService : IPayableService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Read only parameter that makes use of dapper
        /// </summary>
        private readonly IReadOnlyRepository<Payable> _payableRepository;

        public PayableService(IUnitOfWork unitOfWork,
          IReadOnlyRepository<Payable> payableRepository)
        {
            _unitOfWork = unitOfWork;
            _payableRepository = payableRepository;
        }

        public bool AddPayable(Payable payable)
        {
            payable.CreatedAt = DateTime.UtcNow;
            payable.CreatedBy = "AI";
            payable.ModifiedAt = DateTime.UtcNow;
            payable.ModifiedBy = "AI";

            try
            {
                _unitOfWork.Payables.Add(payable);
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

        public IEnumerable<Payable> GetAllPayable()
        {
            return _payableRepository.GetAll();
        }

        public Payable GetPayableById(string id)
        {
            return _payableRepository.FindById(id);
        }

        public bool UpdatePayable(string id, Payable payable)
        {
            try
            {
                payable.Id = Guid.Parse(id);
                _unitOfWork.Payables.Update(payable);
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
