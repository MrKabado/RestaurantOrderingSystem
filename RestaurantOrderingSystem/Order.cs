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
            Console.Write("Enter item code: ");
            string itemCode = Console.ReadLine();

            MenuItem selectedItem = menu.FindItemByCode(itemCode);
            if (!validation.IsValidMenuChoice(itemCode))
            {
                Console.WriteLine("Item not found in the menu. Please try again.");
                return;
            }

            Console.Write("Enter quantity: ");
            int itemQuantity = int.Parse(Console.ReadLine());
            if (!validation.IsValidQuantity(itemQuantity, 10))
            {
                
            }

            Items.Add(new OrderItem
            {
                ItemCode = itemCode,
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
