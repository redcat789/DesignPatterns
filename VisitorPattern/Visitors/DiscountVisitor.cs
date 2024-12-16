using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.CartItems;

namespace VisitorPattern.Visitors
{
    public class DiscountVisitor : IVisitor
    {
        public double TotalDiscount { get; private set; } = 0;

        public void VisitBook(Book book)
        {
            // 10% discount on books
            TotalDiscount += book.Price * 0.10;
        }

        public void VisitElectronics(Electronics electronics)
        {
            // 20% discount on electronics
            TotalDiscount += electronics.Price * 0.20;
        }
    }

}
