//parent class
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

// create a getter for the _studentName to access the value 
    public string GetStudentName()
    {
        return _studentName;
    }

// create a getter for the _topic to access the value 
    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}