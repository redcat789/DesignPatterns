using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern.CartItems
{
    public class Electronics : ICartItem
    {
        public string Name { get; }
        public double Price { get; }
        public string Brand { get; }

        public Electronics(string name, double price, string brand)
        {
            Name = name;
            Price = price;
            Brand = brand;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitElectronics(this);
        }
    }

}
