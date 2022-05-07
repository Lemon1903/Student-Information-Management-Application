namespace StudentManagementLibrary
{
    public class StudentInsert
    {
        // class fields
        private string studentNumber = string.Empty;
        private int studentCount = 1;

        // capturing data from the user
        public Student CaptureData()
        {
            Student output = new Student();
            studentNumber = $"2022-{studentCount++:D4}-MN-0";

            Console.WriteLine($" Student {studentNumber} Information\n");
            output.StudentNumber = studentNumber;
            Console.Write(" Enter the student's name: ");
            output.Name = Console.ReadLine();
            Console.Write(" Enter the student's section: ");
            output.Section = Console.ReadLine();
            Console.Write(" Enter the student's college: ");
            output.College = Console.ReadLine();

            return output;
        }

        // inserting it from the collection of information of students
        public void InsertData(StudentInformation sInfo, Student student)
        {
            sInfo.Students[studentNumber] = student;
            DisplayMessages.Loading("Inserting student information");
            DisplayMessages.ReturnToOptions("Inserted Successfully. ");
        }
    }
}
