
public class Recipe
{
    private string name;
    private List<Ingredient> ingredients;
    private List<string> steps;

    public Recipe(string name)
    {
        this.name = name;
        this.ingredients = new List<Ingredient>();
        this.steps = new List<string>();
    }

    public Action<string> RecipeCalorieExceeded { get; internal set; }
    public string? Name { get; internal set; }

    public void AddIngredient(string ingredientName, double calories, string foodGroup)
    {
        Ingredient ingredient = new(ingredientName, calories, foodGroup);
        ingredients.Add(ingredient);
    }

    public void AddStep(string stepDescription)
    {
        steps.Add(stepDescription);
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"Recipe: {name}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}, {ingredient.Calories} calories, {ingredient.FoodGroup}");
        }
        Console.WriteLine("Steps:");
        for (int i = 0; i < steps.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }
        double totalCalories = ingredients.Sum(i => i.Calories);
        Console.WriteLine($"Total Calories: {totalCalories}");

        if (totalCalories > 300)
        {
            RecipeCalorieExceeded?.Invoke(name);
        }
    }
}