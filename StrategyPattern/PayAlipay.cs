namespace StrategyPattern
{
    class PayAlipay : IPayBehavior
    {
        public void Pay()
        {
            Console.WriteLine("Paying with Alipay...");
        }
    }
}
