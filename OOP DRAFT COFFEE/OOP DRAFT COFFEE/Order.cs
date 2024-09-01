namespace OOP_DRAFT_COFFEE
{
    internal partial class Program
    {
        public class Order
        {

            public void PlaceOrder(Dictionary<string, double> menu, List<string> productOrder)
            {
                if (menu.Count == 0)
                {
                    Print("The menu is empty. Please add items to the menu first.");
                    return;
                }

                Print("\nMenu:");
                int count = 1;
                List<string> fValue = new List<string>(menu.Keys); //contains all the itemnames in the dictionary
                foreach (var item in menu)
                {
                    Print($"{count}. {item.Key} - ${item.Value:F2}");
                    count++;
                }

                Console.Write("Enter the item number to order: ");
                int itemNumber = Convert.ToInt32(Console.ReadLine());

                if (itemNumber > 0 && itemNumber <= menu.Count)
                {
                    string orderedItem = fValue[itemNumber - 1]; // subtracts 1 to make it 0 for the first value and so on
                    productOrder.Add(orderedItem); // adds the item in the list
                    Print("Item added to order!\n");
                }
                else
                {
                    Print("No corresponding item number in the menu. Try again!\n");
                }
            }

            public void ViewOrder(Dictionary<string, double> menu, List<string> productOrder)
            {
                if (productOrder.Count == 0)
                {
                    Print("Your order is empty.");
                }
                else
                {
                    Print("Your Order:");
                    foreach (var item in productOrder) //iterates over each element in the list
                    {
                        double itemPrice = menu[item]; // looks up the price in the list produtOrder
                        Print($"{item} - ${itemPrice:F2}");
                    }
                }
            }
        }
        }
    }
