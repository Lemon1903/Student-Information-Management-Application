namespace StudentManagementLibrary
{
    // super class to be inherited
    public class StudentMethods
    {
        // DoMethod class to be inherited
        public void DoMethod(StudentInformation studentInfo)
        {
            // first, check if student information list is empty
            if (StudentSearch.IsStudentListEmpty(studentInfo))
            {
                StudentDisplayInformation.Display(studentInfo);
                DisplayMessages.ReturnToOptions("");
                return;
            }

            // second, check if student is in the list 
            string? studentNo = UserDataCapture.EnterStudentNo();
            DisplayMessages.Loading("Searching student information");

            if (StudentSearch.Search(studentInfo, studentNo))
            {
                Action(studentInfo, studentNo);
                return;
            }

            // third, display not found if student was not in the list
            StudentSearch.DisplayResult(new Student(), "Not Found");
            DisplayMessages.ReturnToOptions("");
        }

        // method to be overriden for specific method chosen
        private protected virtual void Action(StudentInformation studentInfo, string studentNo) { }
    }
}
