using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string TextbookSection
    {
        get { return _textbookSection; }
    }

    public string Problems
    {
        get { return _problems; }
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}\n{_textbookSection} – {_problems}";
    }
}