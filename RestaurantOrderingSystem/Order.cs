using System;

namespace RestaurantOrderingSystem
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Customer Customer { get; set; }

        private Menu menu;
        private Inputs input;
        private Validation valid;
 
        public Order(Menu menu, Inputs input, Validation valid)
		{
            this.menu = menu;
            this.input = input;
            this.valid = valid;
        }

        public void AddItem()
        {
            MenuItem selectedItem = input.GetItemCode();
            if (selectedItem == null) return;

            int itemQuantity = input.GetItemQuantity();
            if (itemQuantity == 0) return;


            Items.Add(new OrderItem
            {
                ItemCode = selectedItem.Code,
                ItemName = selectedItem.Name,
                Quantity = itemQuantity,
                Price = selectedItem.Price,
            });

        }

        public void AddAgain()
        {
            Console.Write("\nDo you want to add item again? (Y/N): ");
            string response = Console.ReadLine();
            if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                AddItem();
				AddAgain();
			}
		}

        public void GetCustomerInfo()
        {
            Customer = new Customer();

            Customer.Name = input.GetValidName();
            if (Customer.Name == null) return;

            Customer.ContactNumber = input.GetValidContact();
        }

        public void OrderAgain()
        {
            Console.Write("\nDo you want to order again? (Y/N): ");
            string response = Console.ReadLine();
            if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                valid.OrderAgain();
            } else
            {
                valid.IsOrderAgain = false;
                Console.WriteLine("Thank you for ordering! Enjoy your meal :)");
            }
        }
    }
}
