using System.Windows;
using System.Windows.Controls;

namespace FinalPOE
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show("Recipe saved successfully!");

            // Optionally navigate back to the previous page after saving
            NavigationService.GoBack();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void txtSteps_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbFoodGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
