using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    internal class BankAccount
    {
        //adattagok
        //
        public string ownerName { get; set; }
        public decimal balance { get; set; }
        public string accountNumbre { get; set; }
        public string accountType { get; set; }
        public DateTime accountOpeningDate { get; set; }
        //A bankszámla állapota (aktív vagy inaktív)
        public bool isAccountActive { get; set; }
        //konstruktor
        public BankAccount(string ownerName, decimal balance, string accountNumbre, string accountType, DateTime accountOpeningDate, bool isAccountActive)
        {
            this.ownerName = ownerName;
            this.balance = balance;
            this.accountNumbre = accountNumbre;
            this.accountType = accountType;
            this.accountOpeningDate = accountOpeningDate;
            this.isAccountActive = isAccountActive;
        }
        //metódusok
        //bankszamla adatok
        public void PrintAccountInfo()
        {
            Console.WriteLine($"A számlatulajdonos neve:{ownerName},\nA bankszámla egenlege:{balance},\n" +
                $"A számlatulajdonos számlaszáma:{accountNumbre},\nA bankszámla típusa:{accountType},\n" +
                $"A bankszámla nyitásának dátuma:{accountOpeningDate},\nA bankszámla állapota:{isAccountActive}");
        }

        //lezárni a bankszámlát
        public void CloseAccount()
        {
            if (isAccountActive)
            {
                isAccountActive = false;
                Console.WriteLine("A bankszámla lezárása sikerült.");
            }
            else
            {
                Console.WriteLine("A bankszámlát már lezárták.");
            }
        }

        //Pénzátutalást végez 
        public void TransferFundsTo(BankAccount destinationAccount, decimal amount)
        {
            if (isAccountActive && destinationAccount.isAccountActive && balance >= amount && amount > 0)
            {
                balance -= amount;
                destinationAccount.balance += amount;
                Console.WriteLine($"Sikerült átutalni a {amount} FT összeget, a megadott bankszámlára.");
            }
            else
            {
                Console.WriteLine("Az utalás nem sikerült, nincs elég fedezet az utaláshoz.");
            }
        }

        // Frissíti a bankszámla típusát
        public void UpdateAccountType(string newAccountType)
        {
            accountType = newAccountType;
        }
    }
}
