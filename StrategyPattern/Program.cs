namespace StrategyPattern
{
    internal static class Program
    {
        //Strategy is a behavioral design pattern that lets you define a family of
        //algorithms, put each of them into a separate class, and make their objects
        //interchangeable.
        private static void Main()
        {
            var payMethod = new PayMethod();

            payMethod.PayBehavior = new PayWeChat();
            payMethod.RefundBehavior = new RefundWeChat();
            payMethod.PerformPay();
            payMethod.PerformRefund();

            payMethod.PayBehavior = new PayAlipay();
            payMethod.RefundBehavior = new RefundAlipay();
            payMethod.PerformPay();
            payMethod.PerformRefund();
        }
    }
}
