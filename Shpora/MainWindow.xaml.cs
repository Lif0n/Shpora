using Shpora.Models;
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

namespace Shpora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Context _db;
        public MainWindow()
        {
            _db = new Context();
            InitializeComponent();
            UserList.ItemsSource = _db.test.ToList();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var selecteduser = UserList.SelectedItem as User;
            MessageBox.Show(selecteduser.Name);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ButtonClick");
        }
    }
}