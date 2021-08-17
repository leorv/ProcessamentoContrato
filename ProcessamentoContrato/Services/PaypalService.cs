using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoContrato.Services
{
    class PaypalService : IPayService
    {
        public double Interest = 0.01;
        public double TaxValue = 0.02;
        public double SimpleInterest(double amount, int mounths)
        {
            return amount * Interest * mounths; ;
        }

        public double Tax(double amount)
        {
            return amount * TaxValue;
        }
    }
}
