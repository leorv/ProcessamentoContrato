using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoContrato.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public List<Installments> InstallmentsList {  get; set; }

        public Contract(int number, DateTime date, double value, List<Installments> installments)
        {
            Number = number;
            Date = date;
            Value = value;
            this.InstallmentsList = installments;
        }

        public override string ToString()
        {
            string result = "\nContract number: " + Number.ToString()
                + "\nDate: " + Date.ToString() + "\n"
                + "Value: " + Value.ToString("F2") + "\n";

            for (int i = 0; i < InstallmentsList.Count; i++)
            {
                result = result + InstallmentsList[i].ToString() + "\n";
            }

            return result;
        }
    }
}
