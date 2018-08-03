using System;
using System.Collections.Generic;

namespace BootcampBistro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool orderAgain = true;
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
                List<string> itemList = new List<string>();
                List<double> orderList = new List<double>();

                bool repeat = true;
                do
                {
                    bool itemOut = true;
                    do
                    {
                        Console.WriteLine("What item would you like to order? (#)");
                        int order = int.Parse(Console.ReadLine());


                        bool inStock = Sandwich.GetInv(order);
                        if (inStock == true)
                        {
                            orderList.Add(Sandwich.GetPrice(order));
                            itemList.Add(Sandwich.GetName(order));
                            Console.WriteLine($"{Sandwich.GetName(order)} is {Sandwich.GetPrice(order):C}.");
                            itemOut = false;
                        }
                        else if (inStock == false)
                        {
                            Console.WriteLine($"Sorry, we are currently out of {Sandwich.GetName(order)}.");
                            itemOut = true;
                        }
                    } while (itemOut == true);


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
                Console.WriteLine("You ordered:");
                foreach (string item in itemList)
                {
                    Console.WriteLine(item);
                }

                foreach (double price in orderList)
                {
                    sum += price;
                }
                Console.WriteLine($"Subtotal: {sum:C}.\nTax {(sum * .06):C}\nYour total is {sum+(sum*0.06):C}.");
                sum = 0;
                orderList.Clear();
                itemList.Clear();

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


    }
}
