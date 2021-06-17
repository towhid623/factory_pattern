using System;
using System.Collections.Generic;
using System.Text;

namespace factory_pattern
{
    public interface IPayment
    {
        string pay(decimal amount);
    }
}
