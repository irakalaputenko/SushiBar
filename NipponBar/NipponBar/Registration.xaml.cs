using NipponBar.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace NipponBar
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
       public static SushiContext Database;

        public Registration()
        {
            InitializeComponent();
        }
       
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text.Length > 0) // проверяем логин
            {
                if (password.Password.Length > 0) // проверяем пароль
                {
                    if (password_Copy.Password.Length > 0) // проверяем второй пароль
                    {


                    }
                    else MessageBox.Show("Повторіть пароль");
                }
                else MessageBox.Show("Вкажіть пароль");
            }
            else MessageBox.Show("Вкажіть логін");


            Database = new SushiContext();

            var existUser = Database.Users.Where(u => u.Login == login.Text).FirstOrDefault();

            if (existUser != null)
            {
                MessageBox.Show("User with this login are already exist");
                return;
            }

            if (password.Password == password_Copy.Password) // проверка на совпадение паролей
            {
                MessageBox.Show("Користувач зареєстрований");

            }
            else MessageBox.Show("Паролі не співпадають");
            User newUser = new User();
            newUser.Login = login.Text;
            newUser.Password = password.Password;
            newUser.RoleId = (Convert.ToBoolean(Admin.IsChecked)) ? 1 : 2;

            Database.Users.Add(newUser);
            Database.SaveChanges();


            
        }
    }
}
