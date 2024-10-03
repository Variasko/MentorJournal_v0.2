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

namespace MentorJournal_v0._2
{
    /// <summary>
    /// Логика взаимодействия для HobbiePage.xaml
    /// </summary>
    public partial class HobbiePage : Page
    {
        public HobbiePage()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new AddHobbiePage());
        }
    }
}
