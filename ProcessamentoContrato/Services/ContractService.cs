using ProcessamentoContrato.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoContrato.Services
{
    class ContractService
    {
        public IPayService payService { get; set; }

        public ContractService(IPayService payService)
        {
            this.payService = payService;
        }

        public void ProcessContract(Contract contract, int mounths)
        {
            for (int i = 0; i < mounths; i++)
            {
                contract.InstallmentsList.Add(new Installments((i + 1), contract.Date.AddMonths(i + 1), 0.0));

                double sInterest = payService.SimpleInterest(contract.Value, i + 1);
                double tax = payService.Tax(contract.Value + sInterest);
                contract.InstallmentsList[i].Amount = contract.Value + sInterest + tax;
            }
        }
    }
}
