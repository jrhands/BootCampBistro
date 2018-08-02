using System.Collections.Generic;

namespace BootcampBistro
{
    public class Sandwich
    {
        public string Name;
        public List<Ingredient> Ingredients;
        public double Price;

        public Sandwich(string name, List<Ingredient> ingredients, double price)
        {
            Name = name;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
