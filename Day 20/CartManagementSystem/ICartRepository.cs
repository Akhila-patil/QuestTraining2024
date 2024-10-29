using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementSystem
{
    public  interface ICartRepository

    {
        void Add(Item item);
        void Update(Item item);
        void Remove(string itemName);
        List<Item> GetAllItems();
        void ClearCart();

    }
}
