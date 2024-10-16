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
    /// Логика взаимодействия для ActivistPage.xaml
    /// </summary>
    public partial class ActivistPage : Page
    {
        public ActivistPage()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditActivistWindow a = new AddEditActivistWindow();
            a.ShowDialog();
            if (a.DialogResult == true)
                MessageBox.Show("Вы сохранили");
            else
                MessageBox.Show("Вы отменили");
        }
    }
}
