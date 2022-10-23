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

namespace Editor_of_Authors_and_Books
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Service _service;
        public MainWindow()
        {
            InitializeComponent();
            _service = new Service();
            lvBooks.ItemsSource =  _service.ShowBooks().ToList();
            lvAuthors.ItemsSource = _service.ShowAuthors().ToList();
        }

        private void AddAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            new AddAuthorWindow().ShowDialog();
            lvAuthors.ItemsSource = _service.ShowAuthors().ToList();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs eventArgs)
        {

        }
    }
}
