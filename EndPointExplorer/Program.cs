using EndPointExplorer.Models;
using EndPointExplorer.Services;
using EndPointExplorer.Utilities;

class Program
{
    static async Task Main(string[] args)
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
                    var getUrl = ConsoleUtility.ReadInput("Enter URL: ");
                    // For simplicity, headers and body are not included in a GET request
                    var getRequest = new RequestModel
                    {
                        Url = getUrl,
                        Method = "GET"
                    };
                    try
                    {
                        var getResponse = await new ApiRequester().SendRequestAsync(getRequest);
                        ConsoleUtility.PrintSuccess($"Response: {getResponse}");
                    }
                    catch (Exception ex)
                    {
                        ConsoleUtility.PrintError($"Error: {ex.Message}");
                    }
                    break;
                case "2":
                    var postUrl = ConsoleUtility.ReadInput("Enter URL: ");
                    var postBody = ConsoleUtility.ReadInput("Enter request body (JSON): ");
                    var postRequest = new RequestModel
                    {
                        Url = postUrl,
                        Method = "POST",
                        Body = postBody
                    };
                    try
                    {
                        var postResponse = await new ApiRequester().SendRequestAsync(postRequest);
                        ConsoleUtility.PrintSuccess($"Response: {postResponse}");
                    }
                    catch (Exception ex)
                    {
                        ConsoleUtility.PrintError($"Error: {ex.Message}");
                    }
                    break;
                case "3":
                    var putUrl = ConsoleUtility.ReadInput("Enter URL: ");
                    var putBody = ConsoleUtility.ReadInput("Enter request body (JSON): ");
                    var putRequest = new RequestModel
                    {
                        Url = putUrl,
                        Method = "PUT",
                        Body = putBody
                    };
                    try
                    {
                        var putResponse = await new ApiRequester().SendRequestAsync(putRequest);
                        ConsoleUtility.PrintSuccess($"Response: {putResponse}");
                    }
                    catch (Exception ex)
                    {
                        ConsoleUtility.PrintError($"Error: {ex.Message}");
                    }
                    break;
                case "4":
                    var deleteUrl = ConsoleUtility.ReadInput("Enter URL: ");
                    var deleteRequest = new RequestModel
                    {
                        Url = deleteUrl,
                        Method = "DELETE"
                    };
                    try
                    {
                        var deleteResponse = await new ApiRequester().SendRequestAsync(deleteRequest);
                        ConsoleUtility.PrintSuccess("Resource deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        ConsoleUtility.PrintError($"Error: {ex.Message}");
                    }
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