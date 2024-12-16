using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.CartItems;

namespace VisitorPattern.Visitors
{
    public interface IVisitor
    {
        void VisitBook(Book book);
        void VisitElectronics(Electronics electronics);
    }

}
