using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoContrato.Services
{
    interface IPayService
    {
        double SimpleInterest(double amount, int mounths);
        double Tax (double amount);
    }
}
