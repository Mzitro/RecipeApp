using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Description
    {
        public static void main(string[] args) 
        {
            Console.WriteLine("Enter recipe details");
            Console.Write("Recipe Name: ");
            String name = Console.ReadLine();
            Console.Write("Number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            Console.Write("Number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            Recipes recipe = new Recipes (name, numIngredients, numSteps));

            for (int i = 0; i < numIngredients; i++) ;
            {
                Console.WriteLine("Enter details for ingredient" + (i + 1) + (":");
            }
        }
       
    }
}
