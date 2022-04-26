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

namespace Table.View
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
            MainFrame.Content = new TablePage();
        }
        private void ExitProgram_MouseEnter(object sender, MouseEventArgs e)
        {
            ExitProgram.Foreground = Brushes.Red;
        }

        private void ExitProgram_MouseLeave(object sender, MouseEventArgs e)
        {
            ExitProgram.Foreground = Brushes.Black;
        }
        private void Minimized_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExitProgram_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Minimized_MouseEnter(object sender, MouseEventArgs e)
        {
            Minimized.Foreground = Brushes.Gray;
        }

        private void Minimized_MouseLeave(object sender, MouseEventArgs e)
        {
            Minimized.Foreground = Brushes.Black;
        }

        private void Table_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TablePage());
        }

        private void Teacher_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TeacherPage());
        }
    }
}
