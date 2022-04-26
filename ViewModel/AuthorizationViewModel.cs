using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Table.Model;
using Table.Model.Entity;

namespace Table.ViewModel
{
    public class AuthorizationViewModel : BaseViewModel
    {
        private string _password;
        private string _login;
        private RelayCommand _loginCommand;
        public string Password
        {
            get => _password;
            set => SetPropertyChanged(ref _password, value, nameof(_password));
        }
        public string Login
        {
            get => _login;
            set => SetPropertyChanged(ref _login, value, nameof(_login));
        }

        public RelayCommand LoginCommand
        {
            get { return _loginCommand ?? (_loginCommand = new RelayCommand(obj => { enterbtn(); })); }
        }

        public void enterbtn()
        {

            using (var context = new TableCollegeEntities())
            {
                var user = context.User.FirstOrDefault(e => e.Login == Login && e.Password == Password);
                

                if (user != null)
                {
                    CurrentUser.Name = user.FullName;
                    View.MainWindow contentWindow = new View.MainWindow();
                    contentWindow.Show();
                    Application.Current.MainWindow.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Данные введенны неверно. Повторите попытку.");
                }

            }



        }
    }
}
