using AssetManagement.Models.Items.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Models.Items
{
    public interface IItemRepository
    {
        Item GetItem(int Id);
        IEnumerable<Item> GetItemsList();
    }
}
