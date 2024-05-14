public class Ingredient
{
    private string ingredientName;

    public Ingredient(string ingredientName, double calories, string foodGroup)
    {
        this.ingredientName = ingredientName;
        Calories = calories;
        FoodGroup = foodGroup;
    }

    public string Name { get; set; }
    public double Calories { get; set; }
    public object FoodGroup { get; internal set; }
}