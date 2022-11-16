using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HsFinalExam
{
    /// <summary>
    /// Interaction logic for InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {   
        public static InputWindow instance;
        object objName;
        
        List<Order> ol;
        public InputWindow(object obj,object obj1)
        {
            InitializeComponent();
            //calling check object method to check and set appropriate layout
            CheckObj(obj);
            //setting object name
            this.objName = obj;
            //saving reference to the list created in Mainwindow
            this.ol = (List<Order>)obj1;
            //saving instance of this window
            instance = this;
        }

       /* void Show_Warning(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Warning! Do you want to Cancel this order? \n", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
            }

        }*/






        private void CheckObj(object obj)
        {   //checking type of the object and on basis of that choosing layout
            var name = obj.GetType().Name;
            switch(name){
                case "Tyre":
                    var item = obj as Tyre;
                    this.Title = item.ItemName;
                    NameSet.Content = item.ItemName;
                    SetPrice.Content = "$" + item.Cost;
                    HomeDelivery.Content = "No";
                    Weight.Content = item.Weight + "Kg";
                    DeliveryCost_label.Content = "";
                    HomeDelivery_cost.Visibility = Visibility.Hidden;
                    Order_total.Content = "$" + item.Cost;
                    break;
                case "Batteries":
                    var item2 = obj as Batteries;
                    this.Title = item2.ItemName;
                    NameSet.Content = item2.ItemName;
                    SetPrice.Content = "$" + item2.Cost;
                    ModelName.Content = "";
                    ModelName_Input.Visibility = Visibility.Hidden;
                    ChangeLabelName.Content = "Voltage:-";
                    Weight.Content = item2.Weight + "Kg";
                    HomeDelivery.Content = "Yes";
                    HomeDelivery_cost.Content = "$" + item2.ShippingPrice;
                    Order_total.Content = "$" + (item2.Cost + item2.ShippingPrice);
                    break;
                case "WindShieldWipers":
                    var item3 = obj as WindShieldWipers;
                    this.Title = item3.ItemName;
                    NameSet.Content = item3.ItemName;
                    SetPrice.Content = "$" + item3.Cost;
                    ModelName.Content = "";
                    ModelName_Input.Visibility = Visibility.Hidden;
                    Weight.Content = item3.Weight+"Kg";
                    ChangeLabelName.Content = "Length:-";
                    HomeDelivery.Content = "Yes";
                    HomeDelivery_cost.Content = "$" + item3.ShippingPrice;
                    Order_total.Content = "$" + (item3.Cost + item3.ShippingPrice);
                    break;
            }
        }

        //validaing the appropriate input fields for different items
        private void validation(object obj)
        {
            var name = obj.GetType().Name;
            int count = 0;
            switch (name)
            {
                case "Tyre":
                    var objTyre = obj as Tyre;
                    int diameter;
                    if (ModelName_Input.Text.Length!= 0)
                    {
                        if (ChangeLabel_input.Text.Length != 0 )
                        {
                            if(int.TryParse(ChangeLabel_input.Text, out diameter))
                            {
                                objTyre.Diameter = diameter;
                                objTyre.ModelName = ModelName_Input.Text;
                                
                                //Created new order object

                                Order newOrder = new Order()
                                {
                                    OrderName = ItemName_input.Text,
                                    ItemName = objTyre.GetType().Name.ToString(),
                                    ItemNumber = "1",
                                    Weight = objTyre.Weight,
                                    Cost = objTyre.Cost,
                                    HomeDelivery = HomeDelivery.Content.ToString(),
                                    Total = objTyre.Cost
                                };
                                
                                //added to the list in mainwindow
                                ol.Add(newOrder);
                                MainWindow.instance.OrderList.Items.Clear();
                                
                                //set the orderList and total cost of orders 
                                foreach (Order o in ol)
                                {
                                    count += o.Total;
                                    MainWindow.instance.Total_label.Content = "$" + count;
                                    MainWindow.instance.OrderList.Items.Add(o);
                                }
                                 //close window after submit order
                                this.Close();
                               

                            }
                            else { MessageBox.Show("Please enter valid diameter"); }

                        }
                        else { MessageBox.Show("Please enter Diameter"); }
                    }
                    else { MessageBox.Show("please enter ModelName"); }
                    

                    break;
                case "Batteries":
                    int voltage;
                    var objBattery = obj as Batteries;
                        if (ChangeLabel_input.Text.Length != 0)
                        {
                            if (int.TryParse(ChangeLabel_input.Text, out voltage))
                            {
                            Order newOrder = new Order()
                            {
                                OrderName = ItemName_input.Text,
                                ItemName = objBattery.GetType().Name.ToString(),
                                ItemNumber = "1",
                                Cost = objBattery.Cost,
                                ShippingPrice = objBattery.ShippingPrice,
                                Weight = objBattery.Weight,
                                HomeDelivery = HomeDelivery.Content.ToString(),
                                Total = objBattery.Cost + objBattery.ShippingPrice,
                                };
                                ol.Add(newOrder);
                                MainWindow.instance.OrderList.Items.Clear();
                                foreach (Order o in ol)
                                {
                                count += o.Total;
                                MainWindow.instance.Total_label.Content = "$" + count;
                                MainWindow.instance.OrderList.Items.Add(o);
                                }

                                this.Close();


                            }
                            else { MessageBox.Show("Please enter valid voltage"); }

                        }
                        else { MessageBox.Show("Please enter voltage"); }
                    break;
                case "WindShieldWipers":
                    int length;
                    var objWind = obj as WindShieldWipers;
                    if (ChangeLabel_input.Text.Length != 0)
                    {
                        if (int.TryParse(ChangeLabel_input.Text, out length))
                        {
                            Order newOrder = new Order()
                            {
                                OrderName = ItemName_input.Text,
                                ItemName = objWind.GetType().Name.ToString(),
                                ItemNumber = "1",
                                Cost = objWind.Cost,
                                ShippingPrice = objWind.ShippingPrice,
                                Weight = objWind.Weight,
                                HomeDelivery = HomeDelivery.Content.ToString(),
                                Total = objWind.Cost + objWind.ShippingPrice,
                            };
                            ol.Add(newOrder);
                            MainWindow.instance.OrderList.Items.Clear();
                            
                            foreach (Order o in ol)
                            {   
                                count += o.Total;
                                MainWindow.instance.Total_label.Content ="$"+count;
                                MainWindow.instance.OrderList.Items.Add(o);
                                
                            }

                            this.Close();


                        }
                        else { MessageBox.Show("Please enter valid length"); }

                    }
                    else { MessageBox.Show("Please enter length"); }
                    break;

            }
        }

        //on click order button calling the validation method
        private void Order(object sender, RoutedEventArgs e)
        {

            if (ItemName_input.Text.Length != 0)
            {
                validation(objName);

            }
            else
            {
                MessageBox.Show("Please type the item name");
            }

        }
    }
}
