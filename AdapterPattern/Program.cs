
namespace AdapterPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var turkey = new WildTurkey();
            // convert Turkey to a duck
            var adapter = new TurkeyAdapter(turkey);

            Tester(adapter);
        }

        private static void Tester(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
