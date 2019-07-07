using AssetManagement.Models.Items.Data;
using AssetManagement.Models.Items.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Models.Items
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext context;

        public ItemRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Item GetItem(int Id)
        {
            return context.Items.Find(Id);
        }

        public IEnumerable<Item> GetItemsList()
        {
            return context.Items;
        }
    }
}
