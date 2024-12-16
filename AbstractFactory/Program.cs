namespace AbstractFactory
{
    internal class Program
    {
        /*
         * Concept: A factory of factories. It creates families of related objects without specifying their concrete classes.
            Goal: Provide an interface to create groups of related objects.
            Key Feature: Supports product families, where the related objects are created by specific factories.

            When to Use:
            When you need to create multiple related objects (e.g., a GUI toolkit with buttons and checkboxes for different platforms).
            To ensure compatibility among products created.
         */
        static void Main(string[] args)
        {
            // Usage:
            GUIFactory factory = new WindowsFactory();
            Button button = factory.CreateButton();
            Checkbox checkbox = factory.CreateCheckbox();

            button.Render();       // Output: Rendering a Windows Button
            checkbox.Render();     // Output: Rendering a Windows Checkbox
        }
    }
}
