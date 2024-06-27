using System.Collections.Generic;
using System.Windows;

namespace Part3
{
    public partial class MainWindow : Window
    {
        private List<Storage> _recipes = new List<Storage>(); // Initialize empty recipe list

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            var newRecipe = new Storage();
            var createRecipeWindow = new Create_Recipe(newRecipe);

            if (createRecipeWindow.ShowDialog() == true)
            {
                _recipes.Add(newRecipe);
                DisplayRecipes();
            }
        }

        private void btnViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            var recipesWindow = new Recipes(_recipes);
            recipesWindow.ShowDialog();
        }

        private void DisplayRecipes()
        {
            // Method to display recipes if needed in the main window
            // You can implement this as per your application's requirements
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            // Close the application
            Application.Current.Shutdown();
        }
    }
}
