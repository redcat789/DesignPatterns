using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // Abstract Products
    public abstract class Button
    {
        public abstract void Render();
    }

    public abstract class Checkbox
    {
        public abstract void Render();
    }

    // Concrete Products
    public class WindowsButton : Button
    {
        public override void Render() => Console.WriteLine("Rendering a Windows Button");
    }

    public class WindowsCheckbox : Checkbox
    {
        public override void Render() => Console.WriteLine("Rendering a Windows Checkbox");
    }

    public class MacButton : Button
    {
        public override void Render() => Console.WriteLine("Rendering a Mac Button");
    }

    public class MacCheckbox : Checkbox
    {
        public override void Render() => Console.WriteLine("Rendering a Mac Checkbox");
    }
}
