// See https://aka.ms/new-console-template for more information

using ProcessamentoContrato.Entities;
using ProcessamentoContrato.Services;

Console.WriteLine("Enter contract data:\n");
Console.WriteLine("Number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("\nDate (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());

Console.WriteLine("\nContract value: ");
double value = Double.Parse(Console.ReadLine());

Console.WriteLine("Enter number of installments: ");
int installments = int.Parse(Console.ReadLine());

Contract contract = new Contract(number,date,value, new List<Installments>());

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, installments);
Console.WriteLine(contract.ToString());

Console.ReadLine();


