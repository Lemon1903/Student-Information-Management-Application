namespace StudentManagementLibrary
{
    public class StudentDelete : StudentMethods
    {
        // delete student information
        private static void DeleteInformation(StudentInformation sInfo, string key)
        {
            sInfo.Students.Remove(key);
        }

        // overriding Action method to delete action
        private protected override void Action(StudentInformation studentInfo, string studentNo)
        {
            StudentSearch.DisplayResult(studentInfo.Students[studentNo], "Found");
            DeleteInformation(studentInfo, studentNo);
            DisplayMessages.Loading("Deleting student information");
            DisplayMessages.ReturnToOptions("Deleted successfully. ");
        }
    }
}
