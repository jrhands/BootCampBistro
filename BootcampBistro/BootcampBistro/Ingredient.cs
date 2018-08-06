using System.Collections;
using System.IO;
namespace BootcampBistro
{
    public class Ingredient
    {
        public Ingredient()
        {
            //placeholder
        }

        private static string ingredients = @"C:\Users\scull\Desktop\BootCampBistro\BootcampBistro\BootcampBistro\DataFiles\Ingredients.txt";
        private static string ingredientText = File.ReadAllText(ingredients);
        private static string[] ingredientsKeyValue = ingredientText.Split('\r');
        private static Hashtable hashIngreds = new Hashtable();


        public static Hashtable TableIngredients()
        {

            foreach (var ingredient1 in ingredientsKeyValue)
            {

                string[] ingredientString = ingredient1.Split(',');
                hashIngreds.Add(ingredientString[0], double.Parse(ingredientString[1]));


            }

            return hashIngreds;



        }

    }

}
