// Recipes.xaml.cs

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Part3
{
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

            var filteredRecipes = _recipes.Where(recipe =>
            {
                if (string.IsNullOrEmpty(searchQuery))
                    return true;

                var filterType = ((ComboBoxItem)cbFilterType.SelectedItem)?.Content.ToString();
                switch (filterType)
                {
                    case "Name":
                        return recipe.Name?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0;
                    case "Food Groups":
                        return recipe.FoodGroups?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0;
                    case "Calories":
                        return recipe.Calories?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0;
                    default:
                        return false;
                }
            }).ToList();

            foreach (var recipe in filteredRecipes)
            {
                lstRecipes.Items.Add(new ListBoxItem { Content = $"Name: {recipe.Name}\nIngredients: {recipe.Ingredients}\nSteps: {recipe.Steps}\nFood Groups: {recipe.FoodGroups}\nCalories: {recipe.Calories}\n", Tag = recipe });
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var searchQuery = txtSearch.Text;
            DisplayRecipes(searchQuery);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                var selectedItem = (ListBoxItem)lstRecipes.SelectedItem;
                var recipeToDelete = (Storage)selectedItem.Tag;
                _recipes.Remove(recipeToDelete);
                DisplayRecipes();
            }
            else
            {
                MessageBox.Show("Please select a recipe to delete.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                var selectedItem = (ListBoxItem)lstRecipes.SelectedItem;
                var recipeToEdit = (Storage)selectedItem.Tag;

                var editWindow = new Create_Recipe(recipeToEdit);
                if (editWindow.ShowDialog() == true)
                {
                    // Update the displayed recipe after editing
                    DisplayRecipes();
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to edit.", "No Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void txtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = string.Empty;
                txtSearch.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void txtSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
                txtSearch.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
