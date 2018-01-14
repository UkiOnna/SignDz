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

namespace AuthorizationPh
{
    /// <summary>
    /// Логика взаимодействия для SignPage.xaml
    /// </summary>
    public partial class SignPage : Page
    {
        private MainWindow mainWindow;
        private string _login;
        private string _password;

        public SignPage()
        {
            InitializeComponent();
        }

        public SignPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        public SignPage(MainWindow mainWindow,string login,string password)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            _login = login;
            _password = password;
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            mainWindow.Content = new Registration(mainWindow);
        }

        private void SignClick(object sender, RoutedEventArgs e)
        {
            if (Login.Text == _login && Password.Text == _password)
            {
                mainWindow.Content = new Hello(_login);
            }

            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль");
            }
        }
    }
}
