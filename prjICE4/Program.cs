using System;

namespace prjICE4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double VAT = 0.14;
            double itemPrice = 0;
            string itemName = "";
            int choice = 0;

            Console.WriteLine("Welcome to the program!!!");

            try
            {
                while (true)
                {
                    Cart crt1 = new Cart();
                    for (int x = 0; true; x++)
                    {
                        Console.WriteLine("\nPlease select what to do: " +
                                            "\n1- Add an item" +
                                            "\n2- Show slip" +
                                            "\n3- View metrics"+
                                            "\n4- Exit");
                        
                        Console.Write("You: ");
                        choice = int.Parse(Console.ReadLine());
                        if (choice == 4)
                        {
                            System.Environment.Exit(0);
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine(crt1.ToString(x));
                            Console.ReadKey();
                        }
                        else if(choice == 1)
                        {
                            Console.WriteLine("\nPlease select the type of item you are adding:\n1-Grocery Item\n2-Big Box Item");
                            Console.Write("You: ");
                            if (int.Parse(Console.ReadLine()) == 2)
                            {
                                crt1.totalBB++;
                                Console.WriteLine("\nPlease enetr the name of the item");
                                Console.Write("You: ");
                                itemName = Console.ReadLine();
                                Console.WriteLine("Program: Please enter the price of the item");
                                Console.Write("You: R");
                                itemPrice = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Please enter the delivery fee for " + itemName);
                                Console.Write("You: ");
                                BigBox item = new BigBox(double.Parse(Console.ReadLine()), DateTime.Now);
                                item.itemName = itemName;
                                crt1.totalBBValue += itemPrice;
                                crt1.totalDelivery += item.deliveryFee;
                                item.itemPrice = itemPrice;                               
                                item.itemVat = VAT;
                                crt1.warrenty = item.endDate;
                                crt1.storeInCart(item.itemName, item.itemPrice, item.itemVat);
                            }
                            else
                            {
                                items item = new items();
                                Console.WriteLine("\nPlease enetr the name of the item");
                                Console.Write("You: ");
                                item.itemName = Console.ReadLine();
                                Console.WriteLine("Program: Please enter the price of the item");
                                Console.Write("You: R");
                                itemPrice = Convert.ToDouble(Console.ReadLine());
                                crt1.totalGrocery++;
                                crt1.totalGroceryValue += itemPrice;
                                item.itemPrice = itemPrice;
                                item.itemVat = VAT;
                                crt1.storeInCart(item.itemName, item.itemPrice, item.itemVat);
                            }                          
                        }
                        else
                        {
                            Console.WriteLine(crt1.ToString());
                            Console.ReadKey();
                        }
                    }
                } 
            }


            catch (FormatException)
            {
                Console.WriteLine("Please enter the item price in the following format: # or #,##");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
