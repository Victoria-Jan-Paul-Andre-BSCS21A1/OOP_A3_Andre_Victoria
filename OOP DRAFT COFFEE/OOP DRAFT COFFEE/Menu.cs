namespace OOP_DRAFT_COFFEE
{
    internal partial class Program
    {
        public class Menu
        {
            public void AddMenuItem(Dictionary<string, double> menu)
            {
                Console.Write("Enter item name: ");
                var itemName = Console.ReadLine();
                Console.Write("Enter item price: ");
                var itemPrice = Convert.ToDouble(Console.ReadLine());

                menu.Add(itemName, itemPrice);
                Print("\nItem Added Successfully!");
            }

            public void ViewMenu(Dictionary<string, double> menu)
            {
                if (menu.Count == 0) //Checks the dicitionary if there are elements using count method
                {
                    Print("The menu is empty.");
                }
                else
                {
                    Print("\nMenu:");
                    int productNumber = 1; //for product number
                    foreach (var item in menu)
                    {
                        Print($"{productNumber}. {item.Key} - ${item.Value:F2}"); // displays alltogether (product number, itemName, itemPrice)
                        productNumber++;
                    }
                }
            }
        }

        }
    }
