using System;

namespace AdapterPattern
{
    // make Turkey to adapt to Duck's behaviors
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public void Quack()
        {
            Console.WriteLine("I was a Turkey and I could Gobble, now I'm a Duck and I can Quack");
            _turkey.Gobble();
        }

        public void Fly()
        {
            Console.WriteLine("I was a Turkey, now I'm a Duck");
            _turkey.Fly();
        }
    }
}