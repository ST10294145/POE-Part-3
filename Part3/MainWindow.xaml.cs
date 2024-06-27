using System.Windows;

namespace Part3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Storage _storage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            _storage = new Storage();
            var newform = new Create_Recipe(_storage);
            newform.Show();
        }

        private void btnViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (_storage != null)
            {
                var newform = new Recipes(_storage);
                newform.Show();
            }
            else
            {
                MessageBox.Show("No recipe to view. Please create a recipe first.");
            }
        }
    }
}
