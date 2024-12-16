using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.CartItems;

namespace VisitorPattern.Visitors
{
    public class TotalPriceVisitor : IVisitor
    {
        public double TotalPrice { get; private set; } = 0;

        public void VisitBook(Book book)
        {
            TotalPrice += book.Price;
        }

        public void VisitElectronics(Electronics electronics)
        {
            TotalPrice += electronics.Price;
        }
    }

}
