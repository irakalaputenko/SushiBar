using NipponBar.DB;
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

namespace NipponBar
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        User currentUser;
        public List<Sushi1> shoppingCart;
        public static  SushiContext db;
        public Menu(User user)
        {
            InitializeComponent();
           currentUser = user;
            shoppingCart = new List<Sushi1>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(currentUser.RoleId != ModelConstants.AdminRoledId)
            {
                goods.Visibility = Visibility.Hidden;
            }
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);


            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Home());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new SushiCart(shoppingCart));
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new SushiList(shoppingCart));
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Contacts());
                    break;
                case 4:
                    //GridPrincipal.Children.Clear();
                    //GridPrincipal.Children.Add(new Contacts());
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                    break;
                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Cart());
                    
                    break;
                default:
                    break;
            }
            
        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        
    }
}
