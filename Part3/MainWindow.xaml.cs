using System.Collections.Generic;
using System.Windows;

namespace Part3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Storage> _recipes;

        public MainWindow()
        {
            InitializeComponent();
            _recipes = new List<Storage>();
        }

        private void btnCreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            var newform = new Create_Recipe(_recipes);
            newform.Show();
        }

        private void btnViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (_recipes.Count > 0)
            {
                var newform = new Recipes(_recipes);
                newform.Show();
            }
            else
            {
                MessageBox.Show("No recipes to view. Please create a recipe first.");
            }
        }
    }
}
