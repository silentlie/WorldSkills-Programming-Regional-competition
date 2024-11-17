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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainApplication.View.UserControls
{
    /// <summary>
    /// Interaction logic for HomeContent.xaml
    /// </summary>
    public partial class HomeContent : UserControl
    {
        public event EventHandler<string>? Navigate;
        public HomeContent()
        {
            InitializeComponent();
        }

        private void ManagePets_Click(object sender, RoutedEventArgs e)
        {
            Navigate?.Invoke(sender, "ManagePets");
        }

        private void BoardingCostCalculator_Click(object sender, RoutedEventArgs e)
        {
            Navigate?.Invoke(sender, "BoardingCostCalculator");
        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            Navigate?.Invoke(sender, "Statistics");
        }
    }
}
