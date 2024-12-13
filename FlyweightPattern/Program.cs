namespace FlyweightPattern
{
    static class Program
    {
        /*
         * The Flyweight Pattern is a structural design pattern used to optimize memory 
         * usage by sharing common parts of an object between multiple instances. 
         * It avoids creating multiple similar objects by storing shared data externally 
         * and reusing objects.
         */
        private static void Main()
        {
            var teaShop = new BubbleTeaShop();
            teaShop.Enumerate();
        }
    }
}