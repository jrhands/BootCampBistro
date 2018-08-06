using System.Collections.Generic;
using System.IO;
using System.Collections;
using System;


namespace BootcampBistro
{
    public class Sandwich : MenuItem
    {
        public List<string> Ingredients;

        public Sandwich(string name, List<string> ingredients, double price) : base(name, price)
        {
            Ingredients = ingredients;
        }

        public static string GetName(int order)
        {
            List<string> nameList = new List<string>()
            {

                "Roast Beef Sandwich",
                "Turkey Sandwich",
                "Ham Sandwich",
                "Club Sandwich",
                "Tuna Sandwich",
                "Veggie Sandwich",
                "Italian Sandwich",
                "Burger",
                "Hot Dog",
                "Potatoe Chips",
                "BBQ Chips"
            };
            return nameList[order-1];
        }

        public static double GetPrice(int order)
        {
            List<double> priceList = new List<double>()
            {
                12.99,
                12.99,
                10.99,
                10.99,
                12.99,
                10.99,
                11.99,
                13.99,
                7.99,
                2.99,
                2.99
            };
            return priceList[order-1];
        }



        public static bool GetInv(int order)
        {
            string path = @"C:\Users\scull\Desktop\BootCampBistro-master\BootcampBistro\BootcampBistro\DataFiles\Ingredients.txt";
            string[] allLines = File.ReadAllLines(path);
            Dictionary<string, int> hash = new Dictionary<string, int>();

            foreach (string line in allLines)
            {
                var test = line.Split(',');

                hash.Add(test[0], int.Parse(test[1]));
            }

            switch (order)
            {


                case 1:


                    if (hash["rb"] == 0 || hash["white bread"] == 0 || hash["cheese"] == 0 || hash["lettuce"] == 0 ||
                        hash["tomoato"] == 0 || hash["mayo"] == 0)
                    {
                        return false;

                    }
                    else
                    {
                        --hash["rb"];
                        --hash["white bread"];
                        --hash["cheese"];
                        --hash["lettuce"];
                        --hash["tomoato"];
                        --hash["onion"];
                        --hash["mayo"];

                        using (StreamWriter writer = new StreamWriter(path))
                            foreach (var hashRW in hash)
                            {
                                writer.WriteLine($"{hashRW.Key}, {hashRW.Value}");
                            }

                        return true;
                    }


                default: return false;

            }






        }
    }
}


    