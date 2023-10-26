public class WritingAssignment : Assignment
{
    private string _title;

    // the WritingAssignment constructor has 3 parameters and the base constructor has 2 parameters.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // the WritingAssignment class variables specific
        _title = title;
    }

    public string GetWritingInformation()
    {
        // getter  _studentName to access the value
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}