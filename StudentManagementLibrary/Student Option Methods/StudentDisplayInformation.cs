namespace StudentManagementLibrary
{
    public class StudentDisplayInformation
    {
        // display the student information
        public static void Display(StudentInformation sInfo)
        {
            DisplayMessages.InformationHeader();

            if (sInfo.Students.Count == 0)
            {
                Console.WriteLine(" ------------------------ No information added yet ------------------------");
            }
            else
            {
                // iterate each student in student information
                foreach (var (_, student) in sInfo.Students)
                {
                    Console.WriteLine($" {student.StudentNumber,-17} | {student.Name,-28} | {student.Section,-10} | {student.College,-10}");
                }
            }

            Console.WriteLine();
            DisplayMessages.ReturnToOptions("");
        }
    }
}
