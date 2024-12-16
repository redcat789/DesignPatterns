using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class GUIFactory
    {
        public abstract Button CreateButton();
        public abstract Checkbox CreateCheckbox();
    }

    // Concrete Factories
    public class WindowsFactory : GUIFactory
    {
        public override Button CreateButton() => new WindowsButton();
        public override Checkbox CreateCheckbox() => new WindowsCheckbox();
    }

    public class MacFactory : GUIFactory
    {
        public override Button CreateButton() => new MacButton();
        public override Checkbox CreateCheckbox() => new MacCheckbox();
    }
}
