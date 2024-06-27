// Create_Recipe.xaml.cs

using System.Windows;

namespace Part3
{
    public partial class Create_Recipe : Window
    {
        private Storage _storage;
        private bool _isEditing;

        public Create_Recipe(Storage storage)
        {
            InitializeComponent();
            _storage = storage;
            _isEditing = !string.IsNullOrEmpty(_storage.Name); // Check if editing existing recipe

            if (_isEditing)
            {
                // Populate fields with existing recipe data
                txtName.Text = _storage.Name;
                txtIngredients.Text = _storage.Ingredients;
                txtSteps.Text = _storage.Steps;
                txtFoodGroups.Text = _storage.FoodGroups;
                txtCalories.Text = _storage.Calories;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Update storage object with form data
            _storage.Name = txtName.Text;
            _storage.Ingredients = txtIngredients.Text;
            _storage.Steps = txtSteps.Text;
            _storage.FoodGroups = txtFoodGroups.Text;
            _storage.Calories = txtCalories.Text;

            DialogResult = true; // Return true to indicate successful save
        }
    }
}
