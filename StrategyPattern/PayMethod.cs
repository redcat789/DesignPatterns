namespace StrategyPattern
{
    public class PayMethod
    {
        private IPayBehavior _payBehavior;
        private IRefundBehavior _refundBehavior;


        public IPayBehavior PayBehavior
        {
            set
            {
                _payBehavior = value;
            }
        }

        public IRefundBehavior RefundBehavior
        {
            set
            {
                _refundBehavior = value;
            }
        }

        public void PerformPay()
        {
            _payBehavior.Pay();
        }

        public void PerformRefund()
        {
            _refundBehavior.Refund();
        }
    }
}
