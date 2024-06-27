using System.Collections.Generic;
using System.Windows;

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

        private void DisplayRecipes()
        {
            foreach (var recipe in _recipes)
            {
                lstRecipes.Items.Add($"Name: {recipe.Name}\nIngredients: {recipe.Ingredients}\nSteps: {recipe.Steps}\nFood Groups: {recipe.FoodGroups}\nCalories: {recipe.Calories}\n");
            }
        }
    }
}
