using MainApplication.View.UserControls;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HomeContent home = new();
        private readonly ManagePets managePets = new();
        private readonly BoardingCostCalculator boardingCostCalculator = new();
        private readonly Statistics statistics = new();
        public MainWindow()
        {
            InitializeComponent();
            home.Navigate += OnNavigate;
            MainContent.Content = home;
        }
        private void OnNavigate(object? sender, String targetView)
        {
            switch (targetView)
            {
                case "Home":
                    MainContent.Content = home;
                    break;
                case "ManagePets":
                    MainContent.Content = managePets;
                    break;
                case "BoardingCostCalculator":
                    MainContent.Content = boardingCostCalculator;
                    break;
                case "Statistics":
                    MainContent.Content = statistics;
                    break;
                default:
                    break;
            }

        }
    }
}