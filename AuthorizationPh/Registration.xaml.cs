using Microsoft.Win32;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private MainWindow mainWindow;

        public Registration()
        {
            InitializeComponent();
        }

        public Registration(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void PhotoButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            //dialog.DefaultExt = ".png";
            dialog.ShowDialog();

            string filePath = dialog.FileName;

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(filePath);
            image.EndInit();

            imageContainer.Source = image;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (LoginText.Text == string.Empty||ParolText.Text==string.Empty||MailText.Text==string.Empty)
            {
                MessageBox.Show("Пожалуйства введите все данные");
            }

            else
            {
                mainWindow.Content = new SignPage(mainWindow,LoginText.Text,ParolText.Text);
            }
        }
    }
}
