using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern.CartItems
{
    public class Book : ICartItem
    {
        public string Title { get; }
        public double Price { get; }
        public string Author { get; }

        public Book(string title, double price, string author)
        {
            Title = title;
            Price = price;
            Author = author;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitBook(this);
        }
    }

}
