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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MentorJournal_v0._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Image _currentImage;
        private DropShadowEffect shadowEffect = new DropShadowEffect
        {
            BlurRadius = 40,
            Color = Color.FromRgb(178, 68, 242)
        };

        string[] imageToolTip =
        {
            "Профиль",
            "Хобби",
            "Активисты",
            "Лист наблюдений",
            "Студенты в общежитии",
            "Социальный паспорт группы",
            "Родительские собрания",
            "Индивидуальная работа со студентами/родителями",
            "Посещение классных часов",
            "Выйти"
        };

        public MainWindow()
        {
            InitializeComponent();
            _currentImage = profilePic;
            _currentImage.Effect = shadowEffect;
            mainFrame.Navigate(new ProfilePage());

            var imageChildrens = sideMenu.Children.OfType<Image>();

            foreach (var image in imageChildrens)
            {
                image.MouseDown += picture_MouseDown;
            }
            for (int i = 0; i < imageChildrens.Count(); i++)
            {
                imageChildrens.ElementAt(i).ToolTip = new TextBlock
                {
                    Text = imageToolTip[i],
                };
            }

        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Application a = Application.Current;
            a.Shutdown();
        }

        private void logoutPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
            Close();
        }

        private void picture_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _currentImage.Effect = null;
            _currentImage = sender as Image;
            _currentImage.Effect = shadowEffect;
        }

        private void profilePic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new ProfilePage());
        }

        private void hobbiePic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new HobbiePage());
        }

        private void activistPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new ActivistPage());
        }

        private void characteristicPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new CharacteristicPage());
        }

        private void dormitoryPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new DormitoryPage());
        }

        private void socialPassportPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new SocialPassportPage());
        }

        private void eventPlanPic_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void parrentConferencePic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new ParrentConferencePage());
        }

        private void individualWorkPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new IndividualWorkPage());
        }

        private void classHourPic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new ClassHourPage());
        }
    }
}
