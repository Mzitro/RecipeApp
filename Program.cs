namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Recipe> recipes = new List<Recipe>();

            while (true)
            {
                Console.WriteLine("Welcome to Imperials Recipe App");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Recipe");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Delete Recipe");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddRecipe(recipes);
                        break;
                    case "2":
                        DisplayRecipe(recipes);
                        break;
                    case "3":
                        DeleteRecipe(recipes);
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddRecipe(List<Recipe> recipes)
        {
            Console.Write("Recipe Name: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "exit")
                return;

            Recipe recipe = new Recipe(name);

            Console.Write("Number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();
                Console.Write("Calories: ");
                double calories = double.Parse(Console.ReadLine());
                Console.Write("Food Group: ");
                string foodGroup = Console.ReadLine();
                recipe.AddIngredient(ingredientName, calories, foodGroup);
            }

            Console.Write("Number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter details for step {i + 1}:");
                Console.Write("Description: ");
                string stepDescription = Console.ReadLine();
                recipe.AddStep(stepDescription);
            }

            recipe.RecipeCalorieExceeded += RecipeCalorieExceededHandler;

            recipes.Add(recipe);

            Console.WriteLine("Recipe added successfully!");
        }

        static void DisplayRecipe(List<Recipe> recipes)
        {
            Console.WriteLine("Recipe List:");
            foreach (var recipe in recipes.OrderBy(r => r.Name))
            {
                Console.WriteLine(recipe.Name);
            }

            Console.Write("Enter recipe name to display details: ");
            string selectedRecipeName = Console.ReadLine();

            var selectedRecipe = recipes.FirstOrDefault(r => r.Name == selectedRecipeName);
            if (selectedRecipe != null)
            {
                selectedRecipe.PrintRecipe();
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }

        static void DeleteRecipe(List<Recipe> recipes)
        {
            Console.Write("Enter the name of the recipe to delete: ");
            string recipeName = Console.ReadLine();

            var recipeToDelete = recipes.FirstOrDefault(r => r.Name == recipeName);
            if (recipeToDelete != null)
            {
                recipes.Remove(recipeToDelete);
                Console.WriteLine($"Recipe '{recipeName}' deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Recipe '{recipeName}' not found.");
            }
        }

        static void RecipeCalorieExceededHandler(string recipeName)
        {
            Console.WriteLine($"Warning: Calories exceed 300 for recipe '{recipeName}'");
        }
    }
}