using System.Collections.Generic;

namespace BootcampBistro
{
    public class Sandwich :MenuItem
    {
        public List<string> Ingredients;

        public Sandwich(string name, List<string> ingredients, double price) : base(name, price)
        {
            Ingredients = ingredients;
        }

        public static bool GetInv(int order)
        {
            switch (order)
            {
                case 1:
                    return true;
                //if (z[0][1] <= 0 || z[12][1] <= 0 || z[15][1] <= 0)
                //{
                //    return false;
                //}
                //else
                //{
                //    z[0][1]--;
                //    z[12][1]--;
                //    z[15][1]--;
                //    return true;
                //}
                default:
                    return false;
                    
            }
        }
        public static double GetPrice(int order)
        {
            List<double> prices = new List<double>
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
            return prices[order-1];
        }
        public static string GetName(int order)
        { 
            List<string> name = new List<string>
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
                "Potato Chips",
                "BBQ Chips"
            };
            return name[order-1];

        }
    }
}
