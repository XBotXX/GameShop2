using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Registration_Tren
{
    /// <summary>
    /// Логика взаимодействия для UserControlCreate.xaml
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        Entities context = new Entities();
        ObservableCollection<string> games = new ObservableCollection<string>();
        public UserControlCreate()
        {
            InitializeComponent();
            Games.ItemsSource = context.Games.ToList();
            Podborka.ItemsSource = context.Games.ToList();
        }

        private void GotFocusSearch(object sender, RoutedEventArgs e) => SeachGames.Clear();

        private void LostFocusSearch(object sender, RoutedEventArgs e) => SeachGames.Text = "Поиск";

        private void BigIcon_MouseEnter(object sender, MouseEventArgs e) => ((Label)e.OriginalSource).Foreground = Brushes.White;

        private void BigIcon_MouseLeave(object sender, MouseEventArgs e) => ((Label)e.OriginalSource).Foreground = new SolidColorBrush(Color.FromRgb(84, 172, 255));

        private void BigIcon_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            string label = ((Label)sender).Name.ToString();
            MessageBox.Show(label);
            if (label.Equals("Big"))
            {

            }
            else if (label.Equals("Sred"))
            {
                MessageBox.Show("OK1");
            }
            else if (label.Equals("Smoll"))
            {
                MessageBox.Show("OK2");
            }
        }
    }
}
