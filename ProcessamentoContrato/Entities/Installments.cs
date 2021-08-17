namespace ProcessamentoContrato.Entities
{
    public class Installments
    {
        public int Number { get; set; }
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments(int number, DateTime dueDate, double amount)
        {
            Number = number;
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return "\nQuota#" + Number.ToString() +"\n"
                + "Date: " + DueDate.ToString() + "\n"
                + "Amount: " + Amount.ToString("F2") + "\n";
        }
    }
}