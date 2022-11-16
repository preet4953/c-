using System;

namespace Assignment1
{//Student name=Harpreet singh
//Student Id=8715459
//Section = Section 3
//Date=June 4, time-3am
//Description simple fruit purchase system
    class Program
    {
        static void Main(string[] args)
        {
            
            String name;
            float weight,grandtotal,calculateAmount,paymentMethodAmount;
            Console.WriteLine("----Fruits Available----");
            Console.WriteLine(" . Apples \n . Oranges \n . Lemons \n . Limes \n");

            Console.WriteLine(" which item did you bought? Please enter Name \n");
            name = Console.ReadLine();
            //String.isNullOrEmpty(name) checks if user tried to enter empty,null,or whiteSpace 
            //and if it is then program will ask user again and again for valid input
            while (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("you must enter the name of item that you bought");
                name = Console.ReadLine();

            }
            switch (name.ToLower())
            {
                case "apples":
                    Console.WriteLine("Enter the quantity(in kg) of {0} that you bought \n", name);
                    String appleweight = Console.ReadLine();
                    bool success = float.TryParse(appleweight,out weight);
                    if (success) {
                        Items apples = new Items("apples", weight);
                        calculateAmount = getamount(apples, weight);
                        paymentMethodAmount = paymentMethod(calculateAmount);
                        if (paymentMethodAmount == -1) {
                            Console.WriteLine("an error has occured");
                            return;
                        } else {
                            grandtotal = tax(paymentMethodAmount);
                            printBill(item: apples, subtotal: calculateAmount, payment: paymentMethodAmount, grandtotal: grandtotal);
                        }
                    } else { Console.WriteLine("Please enter correct weight"); }
                  
                   
                    break;
                case "oranges":

                    Console.WriteLine("Enter the quantity of {0} that you bought \n", name);
                    String orangesweight = Console.ReadLine();
                    bool orangesuccess = float.TryParse(orangesweight, out weight);
                    if (orangesuccess) {
                        Items oranges = new Items("oranges", weight);
                        calculateAmount = getamount(oranges, weight);
                        paymentMethodAmount = paymentMethod(calculateAmount);
                        if (paymentMethodAmount == -1)
                        { 
                            Console.WriteLine("an error has occured");
                            return;
                        } 
                        else { 
                            grandtotal = tax(paymentMethodAmount);
                            printBill(item: oranges, subtotal: calculateAmount, payment: paymentMethodAmount, grandtotal: grandtotal);
                        }
                        
                    } else { Console.WriteLine("Please enter correct weight"); }
                    
                    break;
                case "lemons":
                    Console.WriteLine("enter the quantity of {0} that you bought \n", name);
                    String lemonsweight = Console.ReadLine();
                    bool lemonSuccess=float.TryParse(lemonsweight,out weight);
                    if (lemonSuccess) {
                        Items lemons = new Items("lemons", weight);
                        calculateAmount = getamount(lemons, weight);
                        paymentMethodAmount = paymentMethod(calculateAmount);
                        if (paymentMethodAmount == -1) {
                            Console.WriteLine("an error has occured");
                            return;
                        } else {
                            
                            grandtotal = tax(paymentMethodAmount);
                            printBill(item: lemons, subtotal: calculateAmount, payment: paymentMethodAmount, grandtotal: grandtotal);
                        }
                    }
                    else { Console.WriteLine("Please enter correct weight"); }
                    break;
                case "limes":
                    Console.WriteLine("enter the quantity of {0} that you bought \n", name);
                    String limesweight = Console.ReadLine();
                    bool limesSuccess = float.TryParse(limesweight,out weight);
                    if (limesSuccess) {
                        Items limes = new Items("limes", weight);
                        calculateAmount = getamount(limes, weight);
                        paymentMethodAmount = paymentMethod(calculateAmount);
                        if (paymentMethodAmount == -1) {
                            Console.WriteLine("an error has occured");
                            return;
                        } else {
                            
                            grandtotal = tax(paymentMethodAmount);
                            printBill(item: limes, subtotal: calculateAmount, payment: paymentMethodAmount, grandtotal: grandtotal);

                        }
                    }
                    else { Console.WriteLine("Please enter correct weight"); }
                    break;
                default:
                    Console.WriteLine("please enter a name that is in lists");
                    break;

            }

            Console.WriteLine("You are outside the program .this console readline is only to keep console opened");
            Console.ReadLine();
           



        }
        static float getamount(Items item, float givenweight)
        {
            return item.Baseprice * givenweight;
        }

        static float paymentMethod(float Amount)
        {
            //float subt;
            Console.WriteLine("which payment method you would like to use \n");
            Console.WriteLine("input 1 for Debit card || 2 Credit Card || 3 Cash \n");

            int paymentMeth;
            String inp = Console.ReadLine();
            bool success = Int32.TryParse(inp, out paymentMeth);
            if (success)
            {
                switch (paymentMeth)
                {
                    case 1:
                        Console.WriteLine("you have chose the debit card \n");
                        Console.WriteLine("There will be no transaction fee \n");
                        break;
                  
                    case 2:
                        Console.WriteLine("you have chose credit card \n");
                        Console.WriteLine("2% fee is applicable \n");
                        Amount=Amount+ (0.02f * Amount);
                        Console.WriteLine("Amount after payment method fee {0} \n", Amount);
                        break;
                    case 3:
                        Console.WriteLine("so you have chose to pay with cash \n");
                        Console.WriteLine(" There will be no transaction fee \n");
                        break;
                    default:
                        Console.WriteLine("\n Please choose a valid payment method");
                        break;
                }
                
                
            }
            //here is some issue
            else { Console.WriteLine("Attempted conversion failed."); return -1; }
            return Amount;
            
        }

        static float tax(float calculateGrand)
        {
            Console.WriteLine("a 13% tax will be added to your amount \n");
            return calculateGrand + (0.13f * calculateGrand);
        }

        static void printBill(Items item, float subtotal, float payment, float grandtotal)
        {
            /*he name of the item purchased
             * The base price
             * Payment fee amount
             * Subtotal Price
             * HST Amount
             * GrandTotal
            */

            Console.WriteLine("BILL");
            Console.WriteLine("-------------------");
            Console.WriteLine("The name of item purchased {0} \n", item.Name);
            Console.WriteLine("The base price ${0} \n", item.Baseprice);
            Console.WriteLine("Subtotal Amount ${0} \n", subtotal);
            Console.WriteLine("amount after fee payment fee ${0} \n", payment);
            Console.WriteLine("grand Total ${0} \n", grandtotal);
            Console.WriteLine("payable amount ${0} \n", Math.Round(grandtotal, 2));

        }

    }
}
