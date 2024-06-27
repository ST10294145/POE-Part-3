using System;
using System.Windows;

namespace Part3
{
    /// <summary>
    /// Interaction logic for Create_Recipe.xaml
    /// </summary>
    public partial class Create_Recipe : Window
    {
        private Storage _storage;

        public Create_Recipe(Storage storage)
        {
            InitializeComponent();
            _storage = storage;

            // Use the storage object as needed
            // For example, you could display the recipe details in the UI
            // You can access the properties using _storage.Name, _storage.Ingredients, etc.
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            // If the user presses yes a message box with the title "WARNING!" will appear telling them it could be dangerous
            MessageBox.Show("Anything above 300 calories can be dangerous to your health!", "WARNING!");
        }
    }
}
