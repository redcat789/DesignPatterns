using System;
using VisitorPattern.CartItems;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    class Program
    {
        /*
         * Visitor is a behavioral design pattern that lets you separate algorithms from 
         * the objects on which they operate.
         */

        /*
         * Imagine you’re designing a shopping cart system. The cart can contain different 
         * types of items such as books, electronics, and clothing. Each type of item 
         * might require different operations:

            Calculating the total price.
            Applying discounts.
            Generating a detailed receipt.
         */
        static void Main()
        {
            // Create a shopping cart
            var cart = new List<ICartItem>
            {
                new Book("C# Programming", 50, "John Doe"),
                new Electronics("Smartphone", 800, "BrandX"),
                new Book("Design Patterns", 60, "Gamma et al.")
            };

            // Calculate total price
            var totalPriceVisitor = new TotalPriceVisitor();
            foreach (var item in cart)
            {
                item.Accept(totalPriceVisitor);
            }
            Console.WriteLine($"Total Price: ${totalPriceVisitor.TotalPrice}");

            // Apply discounts
            var discountVisitor = new DiscountVisitor();
            foreach (var item in cart)
            {
                item.Accept(discountVisitor);
            }
            Console.WriteLine($"Total Discount: ${discountVisitor.TotalDiscount}");
        }
    }
}