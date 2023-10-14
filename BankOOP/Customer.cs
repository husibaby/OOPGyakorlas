using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    internal class Customer
    {
        //Neve
        public string customerName { get; set; }
        //Életkor
        public int customerAge { get; set; }
        //Cím
        public string customerAddress { get; set; }
        //Email
        public string customerEmail { get; set; }
        //Telefonszám
        public string customerPhoneNumber { get; set; }
        //Támogatás kérések
        public List<string> supportRequests { get; set; }
        //Visszajelzések
        public List<string> sendFeedbacks { get; set; }

        //Konstruktor
        public Customer(string customerName, int customerAge, string customerAddress, string customerEmail, string customerPhoneNumber)
        {
            this.customerName = customerName;
            this.customerAge = customerAge;
            this.customerAddress = customerAddress;
            this.customerEmail = customerEmail;
            this.customerPhoneNumber = customerPhoneNumber;
            this.supportRequests = new List<string>();
            this.sendFeedbacks = new List<string>();
        }
        //Metódusok
        //Ügydéladatok
        public void PrintCustomorInfo()
        {
            Console.WriteLine($"Az ügyfél neve:{customerName},\nAz ügyfél kora:{customerAge},\n" +
                $"Az ügyfél címe:{customerAddress},\nAz ügyfél email címe:{customerEmail},\n" +
                $"Az ügyfl telefonszáma:{customerPhoneNumber}");
        }

        //ügyfél adatok frissítése
        public void UpdateCustomerInfo(string newName, int newAge, string newAddress, string newEmail, string newPhoneNumber)
        {
            customerName = newName;
            customerAge = newAge;
            customerAddress = newAddress;
            customerEmail = newEmail;
            customerPhoneNumber = newPhoneNumber;
        }
        // Rendelés feladása
        public void PlaceOrder(string product, int quantity)
        {
            Console.WriteLine($"Az ügyfél:{customerName} a következő mmennyiséget {quantity}db rendelte a következő {product}-ból/ből.");
        }
        //támogatási kérés rögzítése
        public void RequestSupport(string supportRequest)
        {
            supportRequests.Add(supportRequest);
            Console.WriteLine($"Az ügyfél:{customerName} a követkző támogatást kérte: {supportRequest}");
        }
        // visszajelzés
        public void SendFeedback(string feedback)
        {
            sendFeedbacks.Add(feedback);
            Console.WriteLine($"Az ügyfél:{customerName} a követkző visszajelzést küldte: {feedback}");
        }
    }
}
