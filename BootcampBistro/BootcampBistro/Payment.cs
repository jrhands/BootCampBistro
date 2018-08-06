using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BootcampBistro
{
    class Payment
    {
        public double PmtAmt;
        public string PmtType;
        public double[] CardNum;

        public Payment(double pmtAmt, string pmtType)
        {
            PmtAmt = pmtAmt;
            PmtType = pmtType;
            
           
        }
        public void cardPmt()

        {
                double[] cardNum = new double[16];
                Console.WriteLine("Please enter your credit card number");
                double entNum = double.Parse(Console.ReadLine());

                string entNum1 = entNum.ToString();

                if (entNum1.Length != 16)
                {
                    Console.WriteLine("Please enter a 16 digit card number");
                }
           
            Console.WriteLine("Please enter your expiration date mm/yy");
            string expDate = Console.ReadLine();

            Console.WriteLine("Please enter your CVV code");
            int code = int.Parse(Console.ReadLine());

            if (cardNum[0] == 4)
            {
                Console.WriteLine("Thank you for your Visa payment. Please come again");
            }

            if (cardNum[0] == 5)
            {
                Console.WriteLine("Thank you for your Mastercard payment. Please come again");
            }

            if (cardNum[0] == 6)
            {
                Console.WriteLine("Thank you for your Discover payment. Please come again");
            }

        }
        public double CashPmt()
        {
            
            Console.WriteLine("How much cash are you paying with?");
            double cashAmt = double.Parse(Console.ReadLine());

            return cashAmt;
        }

        public string checkPmt()
        {
            Console.WriteLine("Please enter your check number:");
            string checkNum = Console.ReadLine();
            return checkNum;
        }
      
    }
}
