using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Part3
{
    /// <summary>
    /// Interaction logic for Create_Recipe.xaml
    /// </summary>
    public partial class Create_Recipe : Window
    {
        public Create_Recipe()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            // If the user presses yes a message box with the title "WARNING!" will appear telling them it could be dangerous
            MessageBox.Show("Anything above 300 calories can be dangerous to your health!", "WARNING!");
        }
    }
}
