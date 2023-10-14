using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer hajni = new Customer("Hajnalka", 31, "Virág utca 21", "hanjni@hanjni.com", "+123456789");
            Customer ati = new Customer("Attila", 36, "Etele út 58/A", "ati@ati.com", "+214365879");

            hajni.PrintCustomorInfo();
            hajni.PlaceOrder("Csekk", 20);
            hajni.UpdateCustomerInfo("Hajnalka", 32, "Szárazvirág utca 22", "hajnalka@hajnalka.com", "+987654321");
            hajni.PrintCustomorInfo();

            hajni.RequestSupport("Segítség, segítség");
            hajni.SendFeedback("Minden tuti szupi");

            Console.WriteLine();

            BankAccount hajnie = new BankAccount("Hajnalka", 30000, "2030405060", "privát", new DateTime(2023, 10, 14), true);
            BankAccount atie = new BankAccount("Attila", 10000, "10305070", "privát", new DateTime(2023, 10, 13), true);

            hajnie.PrintAccountInfo();
            hajnie.UpdateAccountType("céges");
            hajnie.PrintAccountInfo();
            hajnie.TransferFundsTo(atie, 10000);
            hajnie.PrintAccountInfo();
            atie.PrintAccountInfo();
            atie.CloseAccount();
            atie.CloseAccount();

            Console.ReadLine();
        }
    }
}
