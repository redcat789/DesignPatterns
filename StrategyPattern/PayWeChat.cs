namespace StrategyPattern
{
    internal class PayWeChat : IPayBehavior
    {
        public void Pay()
        {
            Console.WriteLine("Paying with WeChat...");
        }
    }
}