public class MathAssignment : Assignment

{
    private string _textbookCollection = "";
    private string _problems = "";

    public MathAssignment(string name, string topic, string textbook, string problems)
        : base(name, topic)
    {
        
        _textbookCollection = textbook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookCollection} {_problems}";
    }
}