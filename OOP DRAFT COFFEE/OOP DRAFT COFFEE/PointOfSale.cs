namespace OOP_DRAFT_COFFEE
{
    internal partial class Program
    {
        public class PointOfSale
        {
            public void CalculateTotal(Dictionary<string, double> menu, List<string> productOrder)
            {
                if (productOrder.Count <= 0)
                {
                    Print("There are no inputted orders, try again!");
                }
                else
                {
                    double totalPrice = 0;
                    foreach (var item in productOrder) //gets all the items in the productOrder list
                    {
                        totalPrice += menu[item]; //retrieves the price of the current item from the dictionary using the item name
                    }
                    Print($"Total Amount Payable by admin: ${totalPrice:F2}");
                }
            }

        }

        }
    }
