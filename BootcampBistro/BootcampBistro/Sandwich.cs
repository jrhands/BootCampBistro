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
            return nameList[order - 1];
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
            return priceList[order - 1];
        }
    




        public static bool GetInv(int order)
        {
            string path = @"C:\Users\GC Student\Source\Repos\BootCampBistro-master\BootcampBistro\BootcampBistro\DataFiles\Ingredients.txt";
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

                    return GetRb(path, hash);
                case 2:

                    return GetTurkey(path, hash);
                case 3:

                    return GetHam(path, hash);
                case 4:

                    return GetClub(path, hash);
                case 5:

                    return GetTuna(path, hash);
                case 6:

                    return GetVeggie(path, hash);
                case 7:

                    return GetItalian(path, hash);
                case 8:

                    return GetBurger(path, hash);
                case 9:

                    return GetHotdog(path, hash);
                case 10:

                    return GetRegChips(path, hash);

                case 11:

                    return GetBbqChips(path, hash);

                default: return false;

            }
        }

        private static bool GetBbqChips(string path, Dictionary<string, int> hash)
        {
            if (hash["bbq chips"] == 0)
            {
                return false;

            }
            else
            {
                --hash["bbq chips"];


                using (StreamWriter writer = new StreamWriter(path))
                    foreach (var hashRW in hash)
                    {
                        writer.WriteLine($"{hashRW.Key}, {hashRW.Value}");
                    }

                return true;
            }
        }

        private static bool GetRegChips(string path, Dictionary<string, int> hash)
        {
            if (hash["reg chips"] == 0)
            {
                return false;
            }
            else
            {
                --hash["reg chips"];


                using (StreamWriter writer = new StreamWriter(path))
                    foreach (var hashRW in hash)
                    {
                        writer.WriteLine($"{hashRW.Key}, {hashRW.Value}");
                    }

                return true;
            }
        }

        private static bool GetHotdog(string path, Dictionary<string, int> hash)
        {
            if (hash["hotdog bun"] == 0 || hash["hot dog"] == 0 || hash["mustard"] == 0 || hash["ketchup"] == 0 || hash["onion"] == 0)
            {
                return false;

            }
            else
            {
                --hash["hotdog bun"];
                --hash["hot dog"];
                --hash["onion"];
                --hash["mustard"];
                --hash["ketchup"];

                using (StreamWriter writer = new StreamWriter(path))
                    foreach (var hashRW in hash)
                    {
                        writer.WriteLine($"{hashRW.Key}, {hashRW.Value}");
                    }

                return true;
            }
        }

        private static bool GetBurger(string path, Dictionary<string, int> hash)
        {
            if (hash["hamburger bun"] == 0 || hash["patty"] == 0 || hash["cheese"] == 0 || hash["lettuce"] == 0 ||
                hash["tomoato"] == 0 || hash["mustard"] == 0 || hash["ketchup"] == 0 || hash["onion"] == 0 || hash["bacon"] == 0)
            {
                return false;

            }
            else
            {
                --hash["hamburger bun"];
                --hash["patty"];
                --hash["cheese"];
                --hash["lettuce"];
                --hash["tomoato"];
                --hash["onion"];
                --hash["mustard"];
                --hash["ketchup"];
                --hash["bacon"];

                using (StreamWriter writer = new StreamWriter(path))
                    foreach (var hashRW in hash)
                    {
                        writer.WriteLine($"{hashRW.Key}, {hashRW.Value}");
                    }

                return true;
            }
        }

        private static bool GetItalian(string path, Dictionary<string, int> hash)
        {
            if (hash["ham"] == 0 || hash["salami"] == 0 || hash["white bread"] == 0 || hash["cheese"] == 0 || hash["lettuce"] == 0 ||
                hash["tomoato"] == 0)
            {
                return false;

            }
            else
            {
                --hash["salami"];
                --hash["ham"];
                --hash["white bread"];
                --hash["cheese"];
                --hash["lettuce"];
                --hash["tomoato"];
                --hash["onion"];


                using (StreamWriter writer = new StreamWriter(path))
                    foreach (var hashRW in hash)
                    {
                        writer.WriteLine($"{hashRW.Key}, {hashRW.Value}");
                    }

                return true;
            }
        }

        private static bool GetVeggie(string path, Dictionary<string, int> hash)
        {
            if (hash["white bread"] == 0 || hash["cheese"] == 0 || hash["lettuce"] == 0 ||
                hash["tomoato"] == 0 || hash["mayo"] == 0)
            {
                return false;

            }
            else
            {
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
        }

        private static bool GetTuna(string path, Dictionary<string, int> hash)
        {
            if (hash["tuna"] == 0 || hash["white bread"] == 0 || hash["cheese"] == 0 || hash["lettuce"] == 0 ||
                hash["tomoato"] == 0)
            {
                return false;

            }
            else
            {
                --hash["tuna"];
                --hash["white bread"];
                --hash["cheese"];
                --hash["lettuce"];
                --hash["tomoato"];
                --hash["onion"];


                using (StreamWriter writer = new StreamWriter(path))
                    foreach (var hashRW in hash)
                    {
                        writer.WriteLine($"{hashRW.Key}, {hashRW.Value}");
                    }

                return true;
            }
        }

        private static bool GetClub(string path, Dictionary<string, int> hash)
        {
            if (hash["rb"] == 0 || hash["turkey"] == 0 || hash["ham"] == 0 || hash["white bread"] == 0 || hash["cheese"] == 0 || hash["lettuce"] == 0 ||
                                    hash["tomoato"] == 0 || hash["mayo"] == 0)
            {
                return false;

            }
            else
            {
                --hash["rb"];
                --hash["ham"];
                --hash["turkey"];
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
        }

        private static bool GetHam(string path, Dictionary<string, int> hash)
        {
            if (hash["ham"] == 0 || hash["white bread"] == 0 || hash["cheese"] == 0 || hash["lettuce"] == 0 ||
                hash["tomoato"] == 0 || hash["mayo"] == 0)
            {
                return false;

            }
            else
            {
                --hash["ham"];
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
        }

        private static bool GetTurkey(string path, Dictionary<string, int> hash)
        {
            if (hash["turkey"] == 0 || hash["white bread"] == 0 || hash["cheese"] == 0 || hash["lettuce"] == 0 ||
                hash["tomoato"] == 0 || hash["mayo"] == 0)
            {
                return false;

            }
            else
            {
                --hash["turkey"];
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
        }

        private static bool GetRb(string path, Dictionary<string, int> hash)
        {
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
        }
    }
}


    