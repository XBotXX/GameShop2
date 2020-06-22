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

namespace Registration_Tren
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Entities context = new Entities();
        public MainWindow()
        {
            InitializeComponent();
            Login.Focus();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if(context.Users.Where(i => i.Login.Equals(Login.Text) && i.Password.Equals(Pass.Password)).ToList().Any())
            {
                FormVideo formVideo = new FormVideo();
                formVideo.Show();
                this.Close();
            }
            else
            {
                Login.BorderBrush = Brushes.Red;
                Pass.BorderBrush = Brushes.Red;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
