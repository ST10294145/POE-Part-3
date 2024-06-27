using System.Windows;

namespace Part3
{
    public partial class Create_Recipe : Window
    {
        private Storage _storage;

        public Create_Recipe(Storage storage)
        {
            InitializeComponent();
            _storage = storage;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _storage.Name = txtName.Text;
            _storage.Ingredients = txtIngredients.Text;
            _storage.Steps = txtSteps.Text;
            _storage.FoodGroups = txtFoodGroups.Text;

            Recipes recipesWindow = new Recipes(_storage);
            recipesWindow.Show();
            this.Close();
        }
    }
}
