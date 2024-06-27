using System.Windows;

namespace Part3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Creating a new Storage object to pass to the Create_Recipe form
            var storage = new Storage();
            var newform = new Create_Recipe(storage);
            newform.Show();
        }

        private void btnViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Implementation for viewing the recipe
        }
    }
}
