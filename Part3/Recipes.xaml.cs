using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Part3
{
    /// <summary>
    /// Interaction logic for Recipes.xaml
    /// </summary>
    public partial class Recipes : Window
    {
        private List<Storage> _recipes;

        public Recipes(List<Storage> recipes)
        {
            InitializeComponent();
            _recipes = recipes;
            DisplayRecipes();
        }

        private void DisplayRecipes(string searchQuery = "")
        {
            lstRecipes.Items.Clear();

            var filteredRecipes = _recipes
                .Where(recipe => string.IsNullOrEmpty(searchQuery) ||
                                 (recipe.Name?.Contains(searchQuery, System.StringComparison.OrdinalIgnoreCase) == true) ||
                                 (recipe.FoodGroups?.Contains(searchQuery, System.StringComparison.OrdinalIgnoreCase) == true))
                .ToList();

            foreach (var recipe in filteredRecipes)
            {
                lstRecipes.Items.Add($"Name: {recipe.Name}\nIngredients: {recipe.Ingredients}\nSteps: {recipe.Steps}\nFood Groups: {recipe.FoodGroups}\nCalories: {recipe.Calories}\n");
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var searchQuery = txtSearch.Text;
            if (searchQuery == "Search by name or food groups...") searchQuery = string.Empty;
            DisplayRecipes(searchQuery);
        }

        private void btnSearchFilter_Click(object sender, RoutedEventArgs e)
        {
            // Logic for search filter functionality
            MessageBox.Show("Search filter button clicked");
        }

        private void txtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text == "Search by name or food groups...")
            {
                txtSearch.Text = string.Empty;
                txtSearch.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void txtSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by name or food groups...";
                txtSearch.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
