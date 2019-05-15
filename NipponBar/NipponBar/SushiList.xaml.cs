﻿using NipponBar.DB;
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
using System.Data.Entity;

namespace NipponBar
{
    /// <summary>
    /// Логика взаимодействия для SushiList.xaml
    /// </summary>
    public partial class SushiList : UserControl
    {
        public static SushiContext db;
        List<Sushi1> shoppingCart;
        
        public SushiList(List<Sushi1> sushi1s)
        {
            InitializeComponent();
            db = new SushiContext();
            db.Sushi1s.Load(); // загружаем данные
            sushisList.ItemsSource = db.Sushi1s.Local.ToBindingList(); // устанавливаем привязку к кэшу

            shoppingCart = sushi1s;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //SushiCart form = new SushiCart();
            Button button = (Button)sender;
            int id = (int)button.DataContext;
            
            

            shoppingCart.Add(db.Sushi1s.Where(m => m.Id == id).FirstOrDefault());

           // MessageBox.Show(Convert.ToString(id));
            
        }
        

    }
}
