using System;
using System.Collections.Generic;

namespace BootcampBistro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool orderAgain = true;
            List<MenuItem> menu = LoadData();
            do
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("== Welcome to the Bootcamp Bistro! ==");
                Console.WriteLine("=====================================");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "#", "Item", "Price");
                Console.WriteLine("=====================================");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "1:", "Roast Beef Sandwich", "$12.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "2:", "Turkey Sandwich", "$12.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "3:", "Ham Sandwich", "$10.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "4:", "Club", "$10.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "5:", "Tuna Sandwich", "$12.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "6:", "Veggie Sandwich", "$10.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "7:", "Italian Sandwich", "$11.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "8:", "Burger", "$13.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "9:", "Hot Dog", "$7.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "10:", "Potato Chips", "$2.99");
                Console.WriteLine(" {0,-3} {1,-20} {2,10}", "11:", "BBQ Chips", "$2.99");
                Console.WriteLine("=====================================");

                List<double> orderList = new List<double>();

                bool repeat = true;
                do
                {
                    Console.WriteLine("What item would you like to order? (#)");
                    int order = int.Parse(Console.ReadLine());

                    switch (order)
                    {
                        //case 1:
                        //    orderList.Add(Sandwich.GetRB());
                        //    break;
                        //case 2:
                        //    orderList.Add(Sandwich.GetTK());
                        //    break;
                        //case 3:
                        //    orderList.Add(Sandwich.GetHM());
                        //    break;
                        //case 4:
                        //    orderList.Add(Sandwich.GetCL());
                        //    break;
                        //case 5:
                        //    orderList.Add(Sandwich.GetTN());
                        //    break;
                        //case 6:
                        //    orderList.Add(Sandwich.GetVG());
                        //    break;
                        //case 7:
                        //    orderList.Add(Sandwich.GetIT());
                        //    break;
                        //case 8:
                        //    orderList.Add(Sandwich.GetBRG());
                        //    break;
                        //case 9:
                        //    orderList.Add(Sandwich.GetHD());
                        //    break;
                        //case 10:
                        //    orderList.Add(Ingredient.GetCP());
                        //    break;
                        //case 11:
                        //    orderList.Add(Ingredient.GetBBQC());
                        //    break;
                    }
                    Console.WriteLine("Do you want to add another item? (y/n)");
                    string answer = Console.ReadLine().ToLower();
                    switch (answer)
                    {
                        case "y":
                            repeat = true;
                            break;
                        case "n":
                            repeat = false;
                            break;
                        default:
                            break;
                    }
                } while (repeat == true);

                double sum = 0;

                foreach (double price in orderList)
                {
                    sum += price;
                }
                Console.WriteLine($"Your total price is {sum + (sum * .06):C}.");
                sum = 0;
                orderList.Clear();

                Console.WriteLine("Would you like to make another order? (y/n)");
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "y")
                {
                    orderAgain = true;
                }
                else
                {
                    Console.WriteLine("Thank you for your business!");
                    orderAgain = false;
                }
            } while (orderAgain == true);

        }

        public static List<MenuItem> LoadData()
        {
            //This will load Sandwiches.txt and Other.txt
            return new List<MenuItem>();
        }


    }
}
