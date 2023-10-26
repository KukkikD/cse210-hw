public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // the MathAssignment constructor has 4 parameters as a derived class and then, base construction has 2 parameters.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // the MathAssignment specific variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}