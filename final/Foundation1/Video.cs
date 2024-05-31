using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthHours;
    private int _lengthMinutes;
    private int _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthHours, int lengthMinutes, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthHours = lengthHours;
        _lengthMinutes = lengthMinutes;
        _lengthSeconds = lengthSeconds;
    }

    private string GetTimeString()
    {
        string timeString = "";
        if (_lengthHours != 0)
        {
            timeString += _lengthHours.ToString();
            timeString+=":";
            if (_lengthMinutes >= 0)
            {
                timeString += "0";
            }
        }
        timeString+= _lengthMinutes.ToString();
        timeString+=":";
        if (_lengthSeconds <= 9)
        {
            timeString += "0";
        }
        timeString+= _lengthSeconds.ToString();
        return timeString;
    }

    public void AddComment(string commenter, string text)
    {
        Comment comment = new Comment(commenter, text);
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.Commenter} -> {comment.Text}");
        }
        
    }

    public void DisplayVideoInfo()
    {   
        Console.WriteLine($"{_title} – {_author} | {GetTimeString()}");
        
    }
}