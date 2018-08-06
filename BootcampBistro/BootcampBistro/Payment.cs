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
            bool isValid = true;
            do
            {
                double[] cardNum = new double[15];
                Console.WriteLine("Please enter your credit card number");
                long entNum = Convert.ToInt64(Console.ReadLine());
                string entNum1 = entNum.ToString();

                if (entNum1.Length !=16)
                {
                    Console.WriteLine("Please enter a valid 16 digit card number");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter your expiration date mm/yy");
                    string expDate = Console.ReadLine();
                    Console.WriteLine("Please enter your CVV code");
                    int code = int.Parse(Console.ReadLine());
                    isValid = false;
                }
                
            } while (isValid);


        }
        public double CashPmt()
        {
            
            Console.WriteLine("How much cash are you paying with?");
            double cashAmt = double.Parse(Console.ReadLine());

            return cashAmt;
        }

        public void checkPmt()
        {
            Console.WriteLine("Thank you for your payment by check");
            Console.ReadLine();
        }
      
    }
}
