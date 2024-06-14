using System.Windows;
using System.Windows.Controls;

namespace FinalPOE
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string tag = button.Tag.ToString();

            switch (tag)
            {
                case "View_Recipes.xaml":
                    NavigationService.Navigate(new Uri("View_Recipes.xaml", UriKind.Relative));
                    break;
                case "Edit_Recipes.xaml":
                    // Navigate to Page4 with a dummy recipe for now
                    Recipe dummyRecipe = new Recipe
                    {
                        Name = "Sample Recipe",
                        Calories = 250,
                        Ingredients = "Sample Ingredients",
                        Instructions = "Sample Instructions"
                    };
                    NavigationService.Navigate(new Page4(dummyRecipe));
                    break;
                case "Page2.xaml":
                    NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));
                    break;
                case "Page3.xaml":
                    NavigationService.Navigate(new Uri("Page3.xaml", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }
    }
}
