using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace FinalPOE
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string pageUrl = button.Tag as string;
                if (!string.IsNullOrEmpty(pageUrl))
                {
                    MainContentFrame.Navigate(new Uri(pageUrl, UriKind.Relative));
                    Continue.Visibility = Visibility.Collapsed; // Hide the button after navigation
                }
            }
        }
    }
}