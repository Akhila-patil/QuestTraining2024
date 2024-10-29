using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementSystem
{
    public class Cart
    {
        private readonly ICartRepository _cartRepository;

        public Cart(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void Add(Item item) => _cartRepository.Add(item);
        public void Update(Item item) => _cartRepository.Update(item);
        public void Remove(string itemName) => _cartRepository.Remove(itemName);

        public decimal CalculateTotalWithoutDiscount() =>
            _cartRepository.GetAllItems().Sum(item => item.GetTotalPrice());

    }
}
