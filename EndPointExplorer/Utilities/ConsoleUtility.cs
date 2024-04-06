namespace EndPointExplorer.Utilities
{
    internal class ConsoleUtility
    {
        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static string ReadInput(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(prompt);
            var input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }

        public static void DisplayMenu()
        {
            Console.Clear(); // Clear the console to keep it neat

            Console.WriteLine(@" _____  ______  _____ ");
            Console.WriteLine(@"|  ___|| ___ \\|  ___|");
            Console.WriteLine(@"| |__  | |_/ /| |__  ");
            Console.WriteLine(@"|  __| |  __/ |  __| ");
            Console.WriteLine(@"| |___ | |    | |___ ");
            Console.WriteLine(@"\\____/ \\_|    \\____/ ");
            Console.WriteLine();
            Console.WriteLine("Welcome to the API Testing Tool");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            // Menu options
            Console.ForegroundColor = ConsoleColor.Green; // Use a different color for options
            Console.WriteLine("1. Send GET request");
            Console.WriteLine("2. Send POST request");
            Console.WriteLine("3. Send PUT request");
            Console.WriteLine("4. Send DELETE request");
            Console.WriteLine("5. Exit");
            Console.ResetColor(); // Reset to default colors
            Console.Write("\nSelect an option: ");
        }
    }

}
