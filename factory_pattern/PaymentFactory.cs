using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    public class PaymentFactory
    {
        public IPayment getInstance(int paymentMethod)
        {
            switch (paymentMethod)
            {
                case 0:
                    return new BkashPayment();
                case 1:
                    return new NagadPayment();
                default:
                    throw new Exception("Invalid Payment Method!");
            }
        }
    }
}
