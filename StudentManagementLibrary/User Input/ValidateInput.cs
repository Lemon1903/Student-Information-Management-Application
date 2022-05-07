namespace StudentManagementLibrary
{
    public class ValidateInput
    {
        // validate chosen option of the user
        public static bool IsValidInput(string option, string type)
        {
            StudentInformation sInfo = new StudentInformation();

            try     
            {
                // try to convert user input too number
                Options.ChosenOption = Convert.ToInt32(option);

                // if it is a number and input for options
                if (type.Equals("option", StringComparison.Ordinal))
                {
                    return Options.ChosenOption is >= 1 and <= 6; 
                }
            }
            catch
            {
                // in case of not a number and user under edit option
                return type.Equals("edit", StringComparison.Ordinal) && sInfo.StudentIdentification.Contains(option);
            }

            // for invalid user input for all cases
            return false;
        }
    }
}
