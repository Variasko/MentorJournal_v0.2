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

namespace MentorJournal_v0._2
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Application a = Application.Current;
            a.Shutdown();
        }

        private void signInButton_Click(object sender, RoutedEventArgs e)
        {

            string login = loginEnter.Text;
            string password = passwordEnter.Password;

            if (login == "admin" && password == "admin")
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                this.Close();
            } else if (login == "user" && password == "user") {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

            
        }
    }
}
