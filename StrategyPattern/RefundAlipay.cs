namespace StrategyPattern
{
    class RefundAlipay : IRefundBehavior
    {
        public void Refund()
        {
            Console.WriteLine("Refunding with Alipay...");
        }
    }
}
