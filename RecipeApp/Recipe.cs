using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class Recipes
    {
        public string Name
        {
            get;
            set;
        }
        public string Ingredients
        {
            get;
            set;
        }
        public int numIngredients
        {
            get;
            set;
        }
        public double Quantity
        {
            get;
            set;
        }
        public string NumSteps 
        { 
            get;
            set; 
        }
        public string[] Steps
        {
            get;
            set;
        }
        public string Unit
        {
            get;
            set;
        }

        public Recipes(string name, string Ingredients, int numIngredients, Ingredients[] ingredients, double quantity, int NumSteps, string unit)
        {
            Name = name;
            numIngredients = numIngredients;
            Ingredients[] ingredients1 = new Ingredients[numIngredients];
            NumSteps = NumSteps;
            Quantity = quantity;
            Unit = unit;
        }
        public void AddIngredient(int index, string name, double quantity, string unit)
        {
            Ingredients[index] = new Ingredients { Name = name, Quantity = quantity, Unit = unit };
        }
        public void AddStep(int index, String description) 
        {
            Steps[index] = description;
        }
        public void PrintRecipe()
        {
            Console.WriteLine("Recipe Name: " + Name);
            Console.WriteLine("Number of Ingredients: " + numIngredients);
            
            for(int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Ingredient " + (i + 1) + ";");
                Console.WriteLine("Name: " + Ingredients[i]);
                Console.WriteLine("Quantity: " + Ingredients[i]);
                Console.WriteLine("Unit of Measurement: " + Ingredients[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Number of Steps: ");
            
            for (int i = 0; i < NumSteps; i++) 
            {
                Console.WriteLine("Step " + (i + 1) + ":");
                Console.WriteLine("Description: " + Steps[i]);
                Console.WriteLine();
            }
        }
    }

}
    
