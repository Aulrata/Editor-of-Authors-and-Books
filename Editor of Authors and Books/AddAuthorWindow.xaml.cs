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
    /// Логика взаимодействия для AddAuthorWindow.xaml
    /// </summary>
    public partial class AddAuthorWindow : Window
    {
        readonly private Service service;
        public AddAuthorWindow()
        {
            InitializeComponent();
            service = new Service();
        }

        private void AddAuthorButton(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(LastName.Text))
                return;
            if (String.IsNullOrWhiteSpace(FirstName.Text))
                return;
            if (String.IsNullOrWhiteSpace(MiddleName.Text))
                return;
            if (String.IsNullOrWhiteSpace(Birthday.Text))
                return;

            service.AddAuthor(LastName.Text, FirstName.Text, MiddleName.Text, Birthday.Text);
            this.Close();
        }
    }
}
