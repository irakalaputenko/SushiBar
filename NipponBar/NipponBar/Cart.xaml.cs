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
using NipponBar.DB;
using System.Data.Entity;



namespace NipponBar
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : UserControl
    {
        //public static SushiContext Database;
        public static SushiContext db;
        public Cart()
        {
            InitializeComponent();

           db = new SushiContext();
           db.Sushi1s.Load(); // загружаем данные
           sushisGrid.ItemsSource = db.Sushi1s.Local.ToBindingList(); // устанавливаем привязку к кэшу

            
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
           /* using (SushiContext db = new SushiContext())
            {
                Sushi1 sushi1 = new Sushi1 {ImagePath= "E:/Навчання/img1.jpg", Id = 1, SushiName="Sushi Set Dragon", Option= "Ролл с лососем, манго, сыром Филадельфия;", Price = 1200 };
                Sushi1 sushi2 = new Sushi1 { ImagePath = "E:/Навчання/img1.jpg", Id = 2, SushiName = "Krash Fish", Option = "Ролл филадельфия с лососем,ролл ясай,ролл филадельфия сифуд,ролл с окунем,ролл спайс лосось", Price = 1115 };
                Sushi1 sushi3 = new Sushi1 { ImagePath = "E:/Навчання/img1.jpg", Id = 3, SushiName = "Set Philadelphia Salmon", Option = "Филадельфия ролл,Филадельфия Норвежская ролл,Филадельфия Сякэ ролл,", Price = 950 };
                Sushi1 sushi4 = new Sushi1 { ImagePath = "E:/Навчання/img1.jpg", Id = 4, SushiName = "Filadelfia Set", Option = "Филадельфия классическая;Филадельфия сякэ в кунжуте;Филадельфия макси;Феликс ролл с лососем;Авокадо ролл", Price = 1200 };

                db.Sushi1s.Add(sushi1);
                db.Sushi1s.Add(sushi2);
                db.Sushi1s.Add(sushi3);
                db.Sushi1s.Add(sushi4);
                db.SaveChanges();
                MessageBox.Show("Secsessufl");
            }*/
            db.SaveChanges();
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (sushisGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < sushisGrid.SelectedItems.Count; i++)
                {
                    Sushi1 sushi = sushisGrid.SelectedItems[i] as Sushi1;
                    if (sushi != null)
                    {
                        db.Sushi1s.Remove(sushi);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
