using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementSystem
{
    public class CartRepository:ICartRepository
    {
        private List<Item> _items = new List<Item>();

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public void Update(Item updatedItem)
        {
            var item = _items.FirstOrDefault(x => x.Name == updatedItem.Name);
            if (item != null)
            {
                item.Quantity = updatedItem.Quantity;
                item.Price = updatedItem.Price;
            }
        }
        public void Remove(string itemName)
        {
            _items.RemoveAll(x => x.Name == itemName);
        }
        public List<Item> GetAllItems() => _items;

        public void ClearCart() => _items.Clear();
        
    }
}
