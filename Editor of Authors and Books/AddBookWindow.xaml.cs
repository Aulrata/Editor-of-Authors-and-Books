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

namespace Editor_of_Authors_and_Books
{
    /// <summary>
    /// Логика взаимодействия для AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        readonly private Service _service;

        public AddBookWindow()
        {
            InitializeComponent();
            _service = new Service();
        }

        private void AddBookButton(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(Name.Text))
                    return;
                if (String.IsNullOrWhiteSpace(YearOfIssue.Text))
                    return;

                _service.AddBook(Name.Text, int.Parse(YearOfIssue.Text));
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
