using FJFMarketing.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FJFMarketing.Services.Interface
{
    public interface IItemService
    {
        void AddItem(Item item);
        IEnumerable<Item> GetAllItem();
        Item GetItemById(string id);
        bool UpdateItem(string id, Item item);
    }
}
