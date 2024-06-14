using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FinalPOE
{
    public partial class Page4 : Page
    {
        private Recipe selectedRecipe;

        public Page4(Recipe recipe)
        {
            InitializeComponent();
            selectedRecipe = recipe;
            LoadRecipeData();
        }

        private void LoadRecipeData()
        {
            RecipeNameTextBox.Text = selectedRecipe.Name;
            CaloriesTextBox.Text = selectedRecipe.Calories.ToString();
            IngredientsTextBox.Text = selectedRecipe.Ingredients;
            InstructionsTextBox.Text = selectedRecipe.Instructions;
        }

        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(RecipeNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(CaloriesTextBox.Text) ||
                    string.IsNullOrWhiteSpace(IngredientsTextBox.Text) ||
                    string.IsNullOrWhiteSpace(InstructionsTextBox.Text))
                {
                    StatusMessage.Text = "All fields must be filled.";
                    StatusMessage.Foreground = new SolidColorBrush(Colors.Red);
                    return;
                }

                // Save the changes to the recipe
                selectedRecipe.Name = RecipeNameTextBox.Text;
                selectedRecipe.Calories = int.Parse(CaloriesTextBox.Text);
                selectedRecipe.Ingredients = IngredientsTextBox.Text;
                selectedRecipe.Instructions = InstructionsTextBox.Text;

                // Update the status message
                StatusMessage.Text = "Recipe saved successfully!";
                StatusMessage.Foreground = new SolidColorBrush(Colors.Green);
            }
            catch (Exception ex)
            {
                StatusMessage.Text = "Error saving recipe: " + ex.Message;
                StatusMessage.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }

    // Assume Recipe class is defined elsewhere in your project
    public class Recipe
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
