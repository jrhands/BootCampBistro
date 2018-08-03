using System.Collections.Generic;

namespace BootcampBistro
{
    public class Sandwich : MenuItem
    {
        public List<string> Ingredients;

        public Sandwich(string name, List<string> ingredients, double price) : base(name, price)
        {
            Ingredients = ingredients;
        }
       
    }
}
