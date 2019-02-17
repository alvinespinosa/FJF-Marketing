using FJFMarketing.Models.Entities;
using FJFMarketing.Repository.Dapper.Interface;
using FJFMarketing.Repository.EF.Interface;
using FJFMarketing.Services.Interface;
using System;
using System.Collections.Generic;

namespace FJFMarketing.Services
{
    public class ItemService : IItemService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Read only parameter that makes use of dapper
        /// </summary>
        private readonly IReadOnlyRepository<Item> _itemRepository;

        public ItemService(IUnitOfWork unitOfWork, 
            IReadOnlyRepository<Item> itemRepository)
        {
            _unitOfWork = unitOfWork;
            _itemRepository = itemRepository;
        }

        public void AddItem(Item item)
        {
            item.CreatedAt = DateTime.UtcNow;
            item.CreatedBy = "AI";
            item.ModifiedAt = DateTime.UtcNow;
            item.ModifiedBy = "AI";

            _unitOfWork.Items.Add(item);
            _unitOfWork.Save();
        }

        public IEnumerable<Item> GetAllItem()
        {
            return _itemRepository.GetAll();
        }

        public Item GetItemById(string id)
        {
            return _itemRepository.FindById(id);
        }

        public bool UpdateItem(string id, Item item)
        {
            item.Id = Guid.Parse(id);
            _unitOfWork.Items.Update(item);
            _unitOfWork.Save();

            return true;
        }
    }
}
