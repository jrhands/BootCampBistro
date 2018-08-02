using System.Collections.Generic;

namespace BootcampBistro
{
    public class Sandwich : MenuItem
    {
        public List<Ingredient> Ingredients;

        public Sandwich(string name, List<Ingredient> ingredients, double price) : base(name, price)
        {
            Ingredients = ingredients;
        }
    }
}
