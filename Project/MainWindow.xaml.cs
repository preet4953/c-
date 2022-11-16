using System;
using System.Collections;
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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //          Student Name:     Harpreet Singh
    //          Student Course    MSD Section 3 Term 1 May 2021
    //                            C# Assignment 3



    //Data is saved into PersonSeatNum.json

 
    public partial class MainWindow : Window
    {
        //All Total number of buttons list
        private List<Button> totalBtnList = new List<Button>();

        


        //Specifically Chosen seats list
        private List<Button> btnList = new List<Button>();
        
        //List for saving username and seat number
        private List<Seat> al = new List<Seat>();

        String Seatselected = "";

        Button btnclick;
        public MainWindow()
        {
            InitializeComponent();
            totalBtnList.Add(A1);
            totalBtnList.Add(A2);
            totalBtnList.Add(A3);
            totalBtnList.Add(A4);

            totalBtnList.Add(B1);
            totalBtnList.Add(B2);
            totalBtnList.Add(B3);
            totalBtnList.Add(B4);
            
            totalBtnList.Add(C1);
            totalBtnList.Add(C2);
            totalBtnList.Add(C3);
            totalBtnList.Add(C4);
            
            totalBtnList.Add(D1);
            totalBtnList.Add(D2);
            totalBtnList.Add(D3);
            totalBtnList.Add(D4);
            
        }


        public void setItems(Button bt)
        {
            if (bt.Background == Brushes.Red)
            {
                bt.Background = Brushes.LimeGreen;
                bt.Foreground = Brushes.Black;
                SeatNumberDisplay.Text = " ";
                Seatselected = "";

            }
            else
            {
                Seatselected = bt.Name.ToString();
                SeatNumberDisplay.Text = Seatselected;
                bt.Background = Brushes.Red;
                bt.Foreground = Brushes.White;
                //bt.Opacity = 0.7;



            }



        }



        //Row D Seats
        private void D1_Click(object sender, RoutedEventArgs e)
        {
            setItems(D1);
            btnclick = D1;
            

            /*SeatNumberDisplay.Text = "D1";
            D1.Background = Brushes.Red;
            D1.Foreground = Brushes.White;
            D1.Opacity = 0.7;*/
        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {
            setItems(D2);
            btnclick = D2;
            

        }

        private void D3_Click(object sender, RoutedEventArgs e)
        {
            setItems(D3);
            btnclick = D3;
            

        }

        private void D4_Click(object sender, RoutedEventArgs e)
        {
            setItems(D4);
            btnclick = D4;
            

        }

        //Row C Seats

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            setItems(C1);
            btnclick = C1;
            

        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            setItems(C2);
            btnclick = C2;
            
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            setItems(C3);
            btnclick = C3;
            
        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {
            setItems(C4);
            btnclick = C4;
                    }

        //Row B Seats
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            setItems(B1);
            btnclick = B1;
            

        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            setItems(B2);
            btnclick = B2;
            
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            setItems(B3);
            btnclick = B3;
            
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            setItems(B4);
            btnclick = B4;
            
        }

        //Row A Seats
        private void A1_Click(object sender, RoutedEventArgs e)
        {
            setItems(A1);
            btnclick = A1;
            
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            setItems(A2);
            btnclick = A2;
            
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            setItems(A3);
            btnclick = A3;
            
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            setItems(A4);
            btnclick = A4;
            
        }

        // Confirm Button
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            confirmedfunction();

        }

        //Confirmedfunction
        private void confirmedfunction()
        {
            //i change
            if (al.Count != 16)
            {
                //These two if conditions
                if (UserInput.Text.Length != 0)
                {
                    if (Seatselected.Length != 0)
                    {
                        Seat s = new Seat();
                        s.CustomerName = UserInput.Text.ToUpper();
                        s.SeatNumber = Seatselected;
                        al.Add(s);

                        Textprint.Items.Clear();
                        foreach (Seat s2 in al)
                        {

                            Textprint.Items.Add(s2);

                        }

                        btnclick.Background = Brushes.Red;
                        UserInput.Text = "";
                        SeatNumberDisplay.Text = "";
                        Seatselected = "";
                        btnclick.IsEnabled = false;
                        /*Textprint.Items.Refresh();*/
                        btnList.Add(btnclick);
                        
                        //Textprint.Items.Add("");
                        if (!Seat_Avalilable_List_view.Items.IsEmpty) {
                            showItems();
                        }
                        
                    }
                    else { MessageBox.Show("Please Select a seat"); }

                }
                else
                {
                    MessageBox.Show(" Please Enter a customer name");

                }

            }
            else
            {
                MessageBox.Show("We are Full! Please Either exit the Program or Delete some people from List");
            }

        }

        //delete Button
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (SearchInput.Text.Length != 0)
            {
                foreach (Seat s in al)
                {
                    if (s.CustomerName.ToLower().Equals(SearchInput.Text.ToLower()) || s.SeatNumber.Equals(SearchInput.Text))
                    {
                        al.Remove(s);

                        btnEnable(s.SeatNumber);
                        Textprint.Items.Remove(s);

                        return;
                    }

                }
                MessageBox.Show("Name/Number is Not in List");

            }
            else { MessageBox.Show("Enter Either Name or Seat Number"); }
        }


        // TO enable the Seat when deleting the person that reserved that seat before
        private void btnEnable(String btn)
        {
            foreach (Button b in btnList)
            {
                if (btn.Equals(b.Name))
                {
                    MessageBox.Show("Seat Available!!!!", b.Name);
                    b.IsEnabled = true;
                    b.Background = Brushes.LimeGreen;
                    b.Foreground = Brushes.Black;
                    SearchInput.Text = "";
                    showItems(name:b.Name);


                }
            }
        }

        // Master Reset Button

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            if (SeatNumberDisplay.Text.Length == 0)
            {
                if (al.Count == 0)
                {

                    WipeOut();

                }
                else
                {
                    ShowWarning();

                }
            }
            else
            {
                if (al.Count == 0)
                {
                    WipeOut();

                }
                else
                {
                    ShowWarning();
                }

            }

        }

        // Warning message
        private void ShowWarning()
        {
            if (MessageBox.Show("Warning! You are about to wipe out whole data \n Do you want to delete Everything?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                al.Clear();
                foreach (Button b in btnList)
                {
                    Textprint.Items.Clear();
                    b.IsEnabled = true;
                    b.Background = Brushes.LimeGreen;
                    b.Foreground = Brushes.Black;
                }
                btnList.Clear();
                UserInput.Text = "";
                SeatNumberDisplay.Text = "";
                Seatselected = "";
                Seat_Avalilable_List_view.Items.Clear();
                
            }

        }


        //Wipe out notifications
        private void WipeOut()
        {
            MessageBox.Show("There is no data to wipe out", "MasterReset");
            if (btnclick != null)
            {
                btnclick.Background = Brushes.LimeGreen;
                btnclick.Foreground = Brushes.Black;
                SeatNumberDisplay.Text = "";
                Seatselected = "";
                UserInput.Text = "";
                Seat_Avalilable_List_view.Items.Clear();

            }
            else
            {
                SeatNumberDisplay.Text = "";
                Seatselected = "";
                UserInput.Text = "";
                Seat_Avalilable_List_view.Items.Clear();

            }




        }

        //Names from z to a
        private void MenuItem_Reverse(object sender, RoutedEventArgs e)
        {
            var query = al.OrderByDescending(x => x.CustomerName);
            Textprint.Items.Clear();
            foreach (Seat s in query)
            {
                
                Textprint.Items.Add(s);
            }

        }

        //names based on length
        private void MenuItem_Length(object sender, RoutedEventArgs e)
        {
            var query = al.OrderBy(x => x.CustomerName.Length);
            Textprint.Items.Clear();
            foreach(Seat s in query)
            {
                Textprint.Items.Add(s);
            }
        }

        //Available list showing button from menu
        private void MenuItem_Available(object sender, RoutedEventArgs e)
        {
            showItems();
            
            

        }

        //Method for showing avaialble seats list
        private void showItems(String name = "")
        {
            List<String> availbeList = new List<String>();
            if (name.Length != 0)
            {
                availbeList.Add(name);
                foreach (Button b in totalBtnList)
                {

                    if (btnList.Contains(b))
                    {

                    }
                    else { 
                        availbeList.Add(b.Name);
                        availbeList.Sort();
                    
                    }

                }

            }
            else
            {
                foreach (Button b in totalBtnList)
                {

                    if (btnList.Contains(b))
                    {

                    }
                    else { availbeList.Add(b.Name); }

                }
            }
            Seat_Avalilable_List_view.Items.Clear();
           foreach(String s in availbeList) { Seat_Avalilable_List_view.Items.Add(s); }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            string json = JsonSerializer.Serialize(al);
            
            //
            // string json2 = JsonSerializer.Serialize(btnList);
            File.WriteAllTextAsync("PersonSeatNum.json", json );
            // File.WriteAllTextAsync("Booked.json", json2);
            MessageBox.Show("Your Seating plan has been saved Successfully","Success");


        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Textprint.Items.Clear();
            var peopleList = File.ReadAllText("PersonSeatNum.json");
            var newList = JsonSerializer.Deserialize<List<Seat>>(peopleList);
            //var bookedList = File.ReadAllText("Booked.json");
            // var bookList = JsonSerializer.Deserialize<List<Button>>(bookedList);

                foreach (Seat s in newList)
                {
                    al.Add(s);
                    Textprint.Items.Add(s);
                    btnDisable(s.SeatNumber);
                }
            Seat_Avalilable_List_view.Items.Clear();
            
            MessageBox.Show("Seating plan has been Loaded Successfully", "Success");
        }

        private void btnDisable(string seatnum)
        {

         foreach(Button b in totalBtnList)
            {
                if (b.Name.Equals(seatnum))
                {
                    b.IsEnabled = false;
                    b.Foreground = Brushes.White;
                    btnList.Add(b);
                    
                }
            }  



        }



    }
}
