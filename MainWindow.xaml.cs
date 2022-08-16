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

namespace WpfAppProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        NorthwindEntities db=new NorthwindEntities();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void mainloaded_Loaded(object sender, RoutedEventArgs e)
        {
            MyGrid.DataContext = GetAllProducts();
        }
        public List<Product> GetAllProducts()
        {
            var result = db.Products.Select(p => p).ToList();
            return result;
        }
    }
}
