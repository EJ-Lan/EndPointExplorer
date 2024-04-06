using EndPointExplorer.Utilities;

class Program
{
    static void Main(string[] args)
    {
        // Set initial console properties
        Console.Title = "API Testing Tool";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();

        bool running = true;
        while (running)
        {
            ConsoleUtility.DisplayMenu();
            var choice = ConsoleUtility.ReadInput("Select an option: ");
            switch (choice)
            {
                case "1":
                    // Handle GET request
                    // You can call a method here that performs the GET operation
                    ConsoleUtility.PrintSuccess("GET request executed.");
                    break;
                case "2":
                    // Handle POST request
                    // Similar to the GET, call a method for the POST operation
                    ConsoleUtility.PrintSuccess("POST request executed.");
                    break;
                case "3":
                    // Handle PUT request
                    ConsoleUtility.PrintSuccess("PUT request executed.");
                    break;
                case "4":
                    // Handle DELETE request
                    ConsoleUtility.PrintSuccess("DELETE request executed.");
                    break;
                case "5":
                    // Exit the application
                    running = false;
                    ConsoleUtility.PrintSuccess("Exiting application. Goodbye!");
                    break;
                default:
                    ConsoleUtility.PrintError("Invalid option, please try again.");
                    break;
            }

            if (running)
            {
                ConsoleUtility.ReadInput("Press Enter to continue..."); // Pause before clearing the screen
                Console.Clear(); // Clear the console for a fresh start
            }
        }
    }

}