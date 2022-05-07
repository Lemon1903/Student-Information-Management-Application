namespace StudentManagementLibrary
{
    public class UserDataCapture
    {
        // getting user input for options
        public static string? PickOption()
        {
            Console.Write(" Enter your option: ");
            return Console.ReadLine();
        }

        // getting user input for student number
        public static string? EnterStudentNo()
        {
            Console.Write(" Enter student number: ");
            return Console.ReadLine();
        }

        // getting user input for student's identification 
        public static string? EnterIdentification()
        {
            Console.Write(" Enter the student identification you want to modify: ");
            return Console.ReadLine();
        }

        // getting user input for new identification
        public static string? NewIdentification(string identification)
        {
            Console.Write($" Enter the student's {identification}: ");
            return Console.ReadLine();
        }
    }
}
