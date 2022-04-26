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
using Table.Model;

namespace Table.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NameUser.Text = CurrentUser.Name;
        }
        private void ExitProgram_MouseEnter(object sender, MouseEventArgs e)
        {
            ExitProgram.Foreground = Brushes.Red;
        }

        private void ExitProgram_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Minimized_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
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
