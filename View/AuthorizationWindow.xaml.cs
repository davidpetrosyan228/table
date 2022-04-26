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
using Table.View;
using Table.ViewModel;

namespace Table
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new AuthorizationViewModel();
        }

        private void ExitProgram_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Minimized_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ViewPass_Checked(object sender, RoutedEventArgs e)
        {
            PasswordText.Visibility = Visibility.Visible;
            PasswordBox.Visibility = Visibility.Hidden;
        }

        private void ViewPass_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordText.Visibility = Visibility.Hidden;
            PasswordBox.Visibility = Visibility.Visible;
            PasswordBox.Password = PasswordText.Text;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordText.Text = PasswordBox.Password;
            if (this.DataContext != null) { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();
            this.Hide();
        }

        private void ExitProgram_MouseEnter(object sender, MouseEventArgs e)
        {
                ExitProgram.Foreground = Brushes.Red;
        }

        private void ExitProgram_MouseLeave(object sender, MouseEventArgs e)
        {
            ExitProgram.Foreground = Brushes.Black;
        }

        private void Minimized_MouseEnter(object sender, MouseEventArgs e)
        {
            Minimized.Foreground = Brushes.Gray;
        }

        private void Minimized_MouseLeave(object sender, MouseEventArgs e)
        {
            Minimized.Foreground = Brushes.Black;
        }
    }
}
