using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrintShop.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;

namespace PrintShop
{
    public partial class OrdersWindow : Window
    {
        Entities db = Helper.GetContext();
        public OrdersWindow()
        {
            InitializeComponent();
            var querry = db.Orders;
            dtg_orders.ItemsSource = querry.ToList();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            // получаем выбранный элемент
            Orders selectedItem = dtg_orders.SelectedItem as Orders;

            if (selectedItem != null)
            {

                // получаем DbSet для таблицы, содержащей элементы
                DbSet<Orders> items = db.Orders;

                // удаляем элемент из DbSet
                items.Remove(selectedItem);

                // сохраняем изменения в базе данных
                db.SaveChanges();
                refresh();
            }
        }
        public void refresh()
        {
            InitializeComponent();
            var querry = db.Orders;
            dtg_orders.ItemsSource = querry.ToList();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if ((tb_address.Text.Equals("")) || (tb_name.Text.Equals("")) || (tb_time.Text.Equals("")) || (tb_service.Text.Equals("")) || (tb_price.Text.Equals("")))
            {
                MessageBox.Show("Заполни данные");
            }
            else
            {
                Orders newOrder = new Orders();
                newOrder.Delivery_Address = tb_address.Text.ToString();
                newOrder.Recipients_Name = tb_name_rec.Text.ToString();
                DateTime date = DateTime.Parse(tb_time.Text.ToString());
                newOrder.Time = date;
                newOrder.ID_Customers = int.Parse(tb_name.Text);
                newOrder.ID_Services = int.Parse(tb_service.Text);
                newOrder.Total_Price = int.Parse(tb_price.Text);
                Create(newOrder);
            }
        }

        public void Create(Orders orders)
        {
            try
            {
                db.Orders.Add(orders);
                db.SaveChanges();
                refresh();
            }
            catch
            {
                MessageBox.Show("Опа, ошибочка...");
            }
        }

        private void btn_red_Click(object sender, RoutedEventArgs e)
        {
            // получаем выбранный элемент
            Orders selectedItem = dtg_orders.SelectedItem as Orders;

            if (selectedItem != null)
            {
                try
                {
                    db.Entry(selectedItem).State = EntityState.Modified;

                    // сохраняем изменения в базе данных
                    db.SaveChanges();
                    refresh();
                }
                catch 
                {
                    MessageBox.Show("Опа, ошибочка...");
                }
            }
        }
    }
}
