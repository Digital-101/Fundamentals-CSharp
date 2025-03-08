using System;
using System.Collections.Generic;

class VendingMachine
{
    // Define the Product class with inventory tracking
    class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Stock { get; private set; }  // Track inventory

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public bool Purchase()
        {
            if (Stock > 0)
            {
                Stock--; // Reduce stock after purchase
                return true;
            }
            return false;
        }
    }

    static void Main()
    {
        // Initialize vending machine products with stock
        List<Product> products = new List<Product>
        {
            new Product("Coke", 9.50m, 5),
            new Product("Pepsi", 8.50m, 3),
            new Product("Water", 7.00m, 10),
            new Product("Chips", 3.00m, 2),
            new Product("Chocolate", 12.50m, 1)
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Vending Machine!\n");

            // Display available products and stock levels
            Console.WriteLine("Products:");
            for (int i = 0; i < products.Count; i++)
            {
                string stockStatus = products[i].Stock > 0 ? $"Stock: {products[i].Stock}" : "OUT OF STOCK";
                Console.WriteLine($"{i + 1}. {products[i].Name} - R{products[i].Price:F2} ({stockStatus})");
            }
            Console.WriteLine("6. Exit");

            // Get user selection
            Console.Write("\nSelect a product (1-5) or Exit (6): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid choice. Try again.");
                Console.ReadKey();
                continue;
            }

            if (choice == 6)
            {
                Console.WriteLine("Thank you for using the vending machine!");
                break;
            }

            Product selectedProduct = products[choice - 1];

            // Check if product is in stock
            if (selectedProduct.Stock == 0)
            {
                Console.WriteLine("Sorry, this product is out of stock.");
                Console.ReadKey();
                continue;
            }

            // Handle payment
            Console.Write($"Insert money for {selectedProduct.Name} (R{selectedProduct.Price:F2}): R");
            if (!decimal.TryParse(Console.ReadLine(), out decimal moneyInserted) || moneyInserted < selectedProduct.Price)
            {
                Console.WriteLine("Insufficient funds or invalid amount. Try again.");
                Console.ReadKey();
                continue;
            }

            // Process purchase and deduct stock
            if (selectedProduct.Purchase())
            {
                decimal change = moneyInserted - selectedProduct.Price;
                Console.WriteLine($"\nDispensing {selectedProduct.Name}...");
                Console.WriteLine($"Change: R{change:F2}");
                Console.WriteLine($"Remaining stock: {selectedProduct.Stock}");
                Console.WriteLine("Enjoy your product!\n");
            }
            else
            {
                Console.WriteLine("Error processing the purchase.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
