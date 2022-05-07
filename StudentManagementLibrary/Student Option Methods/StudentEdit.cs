namespace StudentManagementLibrary
{
    public class StudentEdit : StudentMethods
    {
        // editing student identification
        private static void Edit(Student student, string identification)
        {
            switch(identification)
            {
                case "Name":
                    student.Name = UserDataCapture.NewIdentification(identification.ToLower());
                    break;
                case "Section":
                    student.Section = UserDataCapture.NewIdentification(identification.ToLower());
                    break;
                case "College":
                    student.College = UserDataCapture.NewIdentification(identification.ToLower());
                    break;
            }
        }

        // overriding Action method to edit action
        private protected override void Action(StudentInformation studentInfo, string studentNo)
        {
            StudentSearch.DisplayResult(studentInfo.Students[studentNo], "Found");
            string? identification = UserDataCapture.EnterIdentification();

            if (!ValidateInput.IsValidInput(identification, "edit"))
            {
                DisplayMessages.InvalidMessage();
            }
            else
            {
                Edit(studentInfo.Students[studentNo], identification);
                DisplayMessages.Loading("Editing student information");
                DisplayMessages.ReturnToOptions("Edited successfully! ");
            }
        }
    }
}
