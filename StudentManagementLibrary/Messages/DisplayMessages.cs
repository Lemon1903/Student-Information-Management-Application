namespace StudentManagementLibrary
{
    public class DisplayMessages
    {
        public static void InvalidMessage()
        {
            Console.Write(" Invalid input! Try again.");
            Console.ReadKey();
        }

        public static void ReturnToOptions(string text)
        {
            Console.Write($" {text}Press any key to go back to options.");
            Console.ReadKey();
        }

        public static void Loading(string text)
        {
            Console.Write($"\n {text}\r");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($" {text += "."}\r");
                Thread.Sleep(1000);
            }
        }

        public static void InformationHeader()
        {
            Console.WriteLine(" --------------------------------------------------------------------------");
            Console.WriteLine($" {"Student Number",-17} | {"Name",-28} | {"Section",-10} | {"College",-10}");
            Console.WriteLine(" --------------------------------------------------------------------------");
        }
    }
}
