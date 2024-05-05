using System;

public class Entry
{
    public string _date;
    public string _entryText;
    public string _promptText;

    public Entry()
    {
        DateTime CurrentTime = DateTime.Now;
        _date = CurrentTime.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} – Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}