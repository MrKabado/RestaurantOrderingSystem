using System;

namespace RestaurantOrderingSystem
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Customer Customer { get; set; }

        private Menu menu;
        private Validation validation = new Validation();
        public Inputs input = new Inputs();

        public Order(Menu menu)
		{
            this.menu = menu;
        }

        public void AddItem()
        {
            MenuItem selectedItem = input.GetItemCode();

            int itemQuantity = input.GetItemQuantity();

            Items.Add(new OrderItem
            {
                ItemCode = selectedItem.Code,
                ItemName = selectedItem.Name,
                Quantity = itemQuantity,
                Price = selectedItem.Price,
            });

        }

        public void OrderAgain()
        {
            Console.Write("\nDo you want to order again? (Y/N): ");
            string response = Console.ReadLine();
            if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                AddItem();
                OrderAgain();
			}
		}

        public void GetCustomerInfo()
        {
            Customer = new Customer();

            Customer.Name = input.GetValidName();

            Customer.ContactNumber = input.GetValidContact();
        }
    }
}
