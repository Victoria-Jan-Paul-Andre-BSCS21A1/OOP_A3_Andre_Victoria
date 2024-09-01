using System;
using System.Collections.Generic;

namespace OOP_DRAFT_COFFEE
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Print("Welcome to the Coffee Shop!");

            Dictionary<string, double> menu = new Dictionary<string, double>(); //store itemName and itemPrice
            List<string> productOrder = new List<string>(); //store the orders by the user
            Menu m = new Menu();
            PointOfSale pos = new PointOfSale();
            Order order = new Order();

            while (true)
            {
                try
                {

                    Print("\n1. Add Menu Item\r\n2. View Menu\r\n3. Place Order\r\n4. View Order\r\n5. Calculate Total\r\n6. Exit");

                    Console.Write("\nSelect an option: ");
                    int userChoice = Convert.ToInt32(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            m.AddMenuItem(menu);
                            break;
                        case 2:
                            m.ViewMenu(menu);
                            break;
                        case 3:
                            order.PlaceOrder(menu, productOrder);
                            break;
                        case 4:
                            order.ViewOrder(menu,productOrder);
                            break;
                        case 5:
                            pos.CalculateTotal(menu, productOrder);
                            break;
                        case 6:
                            Print("Thank you for coming!");
                            return;
                        default:
                            Print("\nTry again.\n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Print($"An error occurred: {ex.Message}"); //displays any error possible, indicating the detailed error
                }
            }
        }

        static void Print(string output)
        {
            Console.WriteLine(output);
        }

        }
    }
