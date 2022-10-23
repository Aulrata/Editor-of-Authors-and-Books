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
            RefreshBooksTable();
            RefreshAuthorsTable();
        }

        private void AddAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            new AddAuthorWindow().ShowDialog();
            RefreshAuthorsTable();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs eventArgs)
        {
            new AddBookWindow().ShowDialog();
            RefreshBooksTable();
        }

        private void RefreshAuthorsTable()
        {
            lvAuthors.ItemsSource = _service.ShowAuthors().ToList();
        }

        private void RefreshBooksTable()
        {
            lvBooks.ItemsSource = _service.ShowBooks().ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (lvBooks.SelectedItem != null)
            {
                _service.RemoveBook((lvBooks.SelectedItem as Book).BookID);
                RefreshBooksTable();
            }
            else if (lvAuthors.SelectedItem != null)
            {
                _service.RemoveAuthor((lvAuthors.SelectedItem as Author).AuthorID);
                RefreshAuthorsTable();
            }


        }
    }
}
