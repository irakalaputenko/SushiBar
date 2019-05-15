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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using NipponBar.Local_Abstract_Factory_;

namespace NipponBar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow mainWindow;
        public static SushiContext db;
        User currentUser;

        public MainWindow()
        {
            InitializeComponent();
            
        }
               
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (llogin.Text == "")
             {
                 MessageBox.Show("Enter your login");
                 return;
             }

             if (password.Password == "")
             {
                 MessageBox.Show("Enter your password");
                 return;
             }
             db = new SushiContext();
            
            User user = db.Users.Where(u => u.Login == llogin.Text && u.Password == password.Password).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Invalid login or password");
                return;
            }
            else
            {
                currentUser = user;
            }
           

           /*  using (SushiContext db = new SushiContext())
             {
                  Role role1 = new Role { Id = 1, RoleName = "admin" };
                  Role role2 = new Role { Id = 2, RoleName = "user" };
                  db.Roles.Add(role1);
                  db.Roles.Add(role2);

                 User user1 = new User { Login = "login", Password = "pass", RoleId = 1 };

                 db.Users.Add(user1);
                 db.SaveChanges();
                 MessageBox.Show("Secsessufl");

             }*/

            Menu menu = new Menu(currentUser);
            menu.Show();
            this.Close();

        }

        private void Regin_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Client c = new Client(new USAApp(), "Login", "There is no possibility?", "Create an account,", "it will take less than 1 minute.",
                "Remember me", "LOGIN", "REGISTRATION","Or access from:", "English", "Ukraine");
            _1.Content = c.login.A;
            _2.Text = c.text1.A;
            _3.Text = c.text2.A;
            _4.Text = c.text3.A;
            _5.Content = c.rem.A;
            enter.Content = c.log.A;
            regin.Content = c.reg.A;
            _6.Content = c.or.A;
            _7.Content = c.english.A;
            _8.Content = c.ukraine.A;

        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Client c = new Client(new UkrApp(), "Вхід", "Не ввиходить?", "Створи акаунт,", "це займе менше 1 хвилини.",
                "Запам'ятати", "Вхід", "Реєстрація", "Знайди нас:", "Англійська", "Українська");
            _1.Content = c.login.A;
            _2.Text = c.text1.A;
            _3.Text = c.text2.A;
            _4.Text = c.text3.A;
            _5.Content = c.rem.A;
            enter.Content = c.log.A;
            regin.Content = c.reg.A;
            _6.Content = c.or.A;
            _7.Content = c.english.A;
            _8.Content = c.ukraine.A;
        }
    }
}
