using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCard card = new RealCard();
            Console.WriteLine("Enter your Card Number");
            card.CardNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Name");
            card.CardName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Card's Expire Date");
            card.CardDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Card's CVV code");
            card.CardCvv = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Cash Amount");
            card.Mebleg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you, Real card is created");
            VirtualCard Vcard = new VirtualCard();

            Console.WriteLine("Enter your name:");
            Vcard.VCardName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("How Much money you want to include?:");
            
            Console.WriteLine("Virtal Card Number: " + Vcard.VCardNumb());
            Console.WriteLine("Virtal Card Name: " + card.CardName);
            Console.WriteLine("Virtal Card Date of Expire: " + DateTime.Now.AddDays(enterDays).ToString("dd.MM.yy"));
        }
    }
}
