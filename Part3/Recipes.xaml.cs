using System.Windows;

namespace Part3
{
    /// <summary>
    /// Interaction logic for Recipes.xaml
    /// </summary>
    public partial class Recipes : Window
    {
        private Storage _storage;

        public Recipes(Storage storage)
        {
            InitializeComponent();
            _storage = storage;
            DisplayRecipe();
        }

        private void DisplayRecipe()
        {
            txtName.Text = $"Name: {_storage.Name}";
            txtIngredients.Text = $"Ingredients: {_storage.Ingredients}";
            txtSteps.Text = $"Steps: {_storage.Steps}";
            txtFoodGroups.Text = $"Food Groups: {_storage.FoodGroups}";
            txtCalories.Text = $"Calories: {_storage.Calories}";
        }
    }
}
