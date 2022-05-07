namespace StudentManagementLibrary
{
    public class StudentSearch : StudentMethods
    {
        // checking if student list is empty
        public static bool IsStudentListEmpty(StudentInformation sInfo)
        {
            return sInfo.Students.Count == 0;
        }

        // searching for student number
        public static bool Search(StudentInformation sInfo, string key)
        {
            return sInfo.Students.ContainsKey(key);
        }

        // displaying the search result
        public static void DisplayResult(Student student, string status)
        {
            if (status == "Found")
            {
                DisplayMessages.InformationHeader();
                Console.WriteLine($" {student.StudentNumber,-17} | {student.Name,-28} | {student.Section,-10} | {student.College,-10}\n");
            }
            else if (status == "Not Found")
            {
                DisplayMessages.InformationHeader();
                Console.WriteLine(" ---------------------- No student information found ----------------------\n");
            }
        }

        // overriding Action method to display search result action
        private protected override void Action(StudentInformation studentInfo, string studentNo)
        {
            DisplayResult(studentInfo.Students[studentNo], "Found");
            DisplayMessages.ReturnToOptions("Student found! ");
        }
    }
}
