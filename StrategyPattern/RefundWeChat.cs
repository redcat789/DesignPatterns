namespace StrategyPattern
{
    class RefundWeChat : IRefundBehavior
    {
        public void Refund()
        {
            Console.WriteLine("Refunding with WeChat Pay...");
        }
    }
}
