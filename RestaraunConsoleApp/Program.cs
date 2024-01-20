namespace RestaraunConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Restaurant Menu!");

            DisplayMainMenu();
            int chose = GetMenuChoice(1, 4);
            switch (chose)
            {
                case 1:
                    // Hot meals submenu
                    DisplayHotMealsMenu();
                    int hotMealsChoice = GetMenuChoice(1, 4);
                    ProcessHotMealsChoice(hotMealsChoice);
                    break;

                case 2:
                    // Pot dishes submenu
                    DisplayPotDishesMenu();
                    int potDishesChoice = GetMenuChoice(1, 4);
                    ProcessPotDishesChoice(potDishesChoice);
                    break;

                case 3:
                    // Drinks submenu
                    DisplayDrinksMenu();
                    int drinksChoice = GetMenuChoice(1, 4);
                    ProcessDrinksChoice(drinksChoice);
                    break;

                case 4:
                    // Desserts submenu
                    DisplayDessertsMenu();
                    int dessertsChoice = GetMenuChoice(1, 4);
                    ProcessDessertsChoice(dessertsChoice);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;

            }

            static void DisplayMainMenu()
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1 - Hot meals");
                Console.WriteLine("2 - Pot dishes");
                Console.WriteLine("3 - Drinks");
                Console.WriteLine("4 - Desserts");
            }

            static void DisplayHotMealsMenu()
            {
                Console.WriteLine("Hot Meals Menu:");
                Console.WriteLine("1 - Stuffing");
                Console.WriteLine("2 - Homemade potatoes");
                Console.WriteLine("3 - Shawarma");
                Console.WriteLine("4 - Any food name");
            }

            static void DisplayPotDishesMenu()
            {
                Console.WriteLine("Pot Dishes Menu:");
                Console.WriteLine("1 - Soop");
                Console.WriteLine("2 - Easy American goulash");
                Console.WriteLine("3 - Chicken Alfredo");
                Console.WriteLine("4 - Any food name");
            }

            static void DisplayDrinksMenu()
            {
                Console.WriteLine("Drinks Menu:");
                Console.WriteLine("1 - Cola");
                Console.WriteLine("2 - Fanta");
                Console.WriteLine("3 - Whisky");
                Console.WriteLine("4 - Any food name");
            }

            static void DisplayDessertsMenu()
            {
                Console.WriteLine("Desserts Menu:");
                Console.WriteLine("1 - Chocolate soufflé cake");
                Console.WriteLine("2 - Tiramisu");
                Console.WriteLine("3 - Chocolate chip cookies");
                Console.WriteLine("4 - Any food name");
            }

            //You enter the maximum and minimum values in the menu
            static int GetMenuChoice(int minValue, int maxValue)
            {
                int choice;
                do
                {
                    Console.Write("Enter your choice: ");
                    if (!int.TryParse(Console.ReadLine(), out choice) || choice < minValue || choice > maxValue)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between {0} and {1}.", minValue, maxValue);
                    }
                } while (choice < minValue || choice > maxValue);

                return choice;
            }

            static void ProcessHotMealsChoice(int choice)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You ordered Stuffing.");
                        break;
                    case 2:
                        Console.WriteLine("You ordered Homemade potatoes.");
                        break;
                    case 3:
                        Console.WriteLine("You ordered Shawarma.");
                        break;
                    case 4:
                        Console.WriteLine("You ordered Any food name.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }

            static void ProcessPotDishesChoice(int choice)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You ordered Soop.");
                        break;
                    case 2:
                        Console.WriteLine("You ordered Easy American goulash.");
                        break;
                    case 3:
                        Console.WriteLine("You ordered Chicken Alfredo.");
                        break;
                    case 4:
                        Console.WriteLine("You ordered Any food name.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }

            static void ProcessDrinksChoice(int choice)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You ordered Cola.");
                        break;
                    case 2:
                        Console.WriteLine("You ordered Fanta.");
                        break;
                    case 3:
                        Console.WriteLine("You ordered Whisky.");
                        break;
                    case 4:
                        Console.WriteLine("You ordered Any food name.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }

            static void ProcessDessertsChoice(int choice)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You ordered hocolate soufflé cake.");
                        break;
                    case 2:
                        Console.WriteLine("You ordered Tiramisu.");
                        break;
                    case 3:
                        Console.WriteLine("You ordered Chocolate chip cookies.");
                        break;
                    case 4:
                        Console.WriteLine("You ordered Any food name.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}