using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    public class NagadPayment : IPayment
    {
        public string pay(decimal amount)
        {
            return "Successfully paid " + amount + " taka with nagad!";
        }
    }
}
