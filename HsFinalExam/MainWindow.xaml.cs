using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace HsFinalExam
{
    //Student Name:- Harpreet Singh
    //Student Number:- 8715459
    //Class : MSD Section3 
    //C# Exam
    //20 August 2021 11:58pm
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance;
        private readonly List<Item> ItemList = new List<Item>();

        private readonly List<Order> Ol = new List<Order>();
        public MainWindow()
        {
            
            InitializeComponent();
            //Creating objects 
            Tyre tyre = new Tyre()
            {
                ItemName = "Tyre",
                ItemNumber = "1",
                Cost = 200,
                Weight = 30
            };
            Batteries batteries = new Batteries()
            {
                ItemName = "Batteries",
                ItemNumber = "2",
                Cost = 100,
                Weight = 10
            };
            WindShieldWipers windShieldWipers = new WindShieldWipers()
            {
                ItemName = "WindShield Wipers",
                ItemNumber = "3",
                Cost = 15,
                Weight = 1
            };
            //Adding into List
            ItemList.Add(tyre);
            ItemList.Add(batteries);
            ItemList.Add(windShieldWipers);
            PrintList.ItemsSource = ItemList;
            instance = this;
            Total_label.Content = "$0";
            
        }

        //Show New Window on selected item
        private void Item_Selection(object sender,SelectionChangedEventArgs e)
        {
            /*    MessageBox.Show(PrintList.SelectedItem.ToString(), "Item", MessageBoxButton.OK, MessageBoxImage.Information);
            */
            InputWindow inputwindow = new InputWindow(PrintList.SelectedItem,Ol);
            inputwindow.Show();

            
        
        }

        //Save the order details in json format
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(Ol);
            File.WriteAllTextAsync("Orders.json", json);
            MessageBox.Show("Your OrdersList has been saved Successfully", "Success");
        }

        //Load Order details
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            OrderList.Items.Clear();
            var OList = File.ReadAllText("Orders.json");
            var newList = JsonSerializer.Deserialize<List<Order>>(OList);
            foreach (Order o in newList)
            {
                count += o.Total;
                Ol.Add(o);
                Total_label.Content = "$" + count;
                OrderList.Items.Add(o);
            }
            
            MessageBox.Show("OrderList has been Loaded Successfully", "Success");

        }

        //Show warning if user try to close the window
         void Show_Warning(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Warning! Do you want to exit?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
            }

        }

        //Show info on tap info button
        private void Info_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Attention! Tap on Available List items to Order\nYou can order 1 Item at a time\nDue to Pandemic we only do Home Delivery\nHowever Item such as Tires are not Deliverable", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        //Linq button 
        private void Linq_Click(object sender, RoutedEventArgs e)
        {
            if (Ol.Count != 0)
            {
                var query = Ol.GroupBy(x => x.ItemName).Select(n => new { ItemName = n.Key, ItemCount = n.Count() }).OrderByDescending(n => n.ItemCount).First();
                MessageBox.Show(query.ItemName + " is the most purchased item with count " + query.ItemCount, "Info");
            }
            else
            {
                MessageBox.Show("No Order Data found");
            }
        }
    }
}
