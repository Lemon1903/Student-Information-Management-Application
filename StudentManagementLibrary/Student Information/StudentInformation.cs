namespace StudentManagementLibrary
{
    public class StudentInformation
    {
        // student information properties
        public Dictionary<string, Student> Students { get; set; } = new Dictionary<string, Student>();
        public List<string> StudentIdentification { get; } = new List<string>() { "Name", "Section", "College" };
    }
}
