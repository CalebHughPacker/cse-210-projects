using System;

public class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    public string Commenter
    {
        get {return _commenter;}
        set {_commenter = value;}
    }

    public string Text
    {
        get {return _text;}
        set {_text = value;}
    }

    
}