namespace StudentManagementLibrary
{
    public class Options
    {
        // class property
        public static int ChosenOption { get; set; }

        // show the list of options
        public static void ShowOptions()
        {
            Console.WriteLine(" Welcome to Student Information Management Application!\n");
            Console.WriteLine(" What do you want to do?");
            Console.WriteLine(" 1. Display student information");
            Console.WriteLine(" 2. Insert new student information");
            Console.WriteLine(" 3. Delete student information");
            Console.WriteLine(" 4. Search student information");
            Console.WriteLine(" 5. Edit student information");
            Console.WriteLine(" 6. Exit application\n");
        }
    }
}
