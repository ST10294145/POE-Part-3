using System.Collections.Generic;
using System.Windows;

namespace Part3
{
    public partial class Create_Recipe : Window
    {
        private List<Storage> _recipes;

        public Create_Recipe(List<Storage> recipes)
        {
            InitializeComponent();
            _recipes = recipes;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var newRecipe = new Storage
            {
                Name = txtName.Text,
                Ingredients = txtIngredients.Text,
                Steps = txtSteps.Text,
                FoodGroups = txtFoodGroups.Text,
                Calories = txtCalories.Text
            };

            _recipes.Add(newRecipe);

            MessageBox.Show("Recipe saved successfully!");
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtIngredients.Clear();
            txtSteps.Clear();
            txtFoodGroups.Clear();
            txtCalories.Clear();
        }
    }
}
