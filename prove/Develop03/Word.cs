using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    //constructor
    public Word (string text)
    {
        _text = text;
    }

    //get and set Text variable
    public string Text
    {
        get {return _text;}
        set {_text = value;}
    }

    //"Hides" a string by replacing wach character with underscores
    public void Hide()
    {
        string hiddenText = new('_', Text.Length);
        Text = hiddenText;
    }

    //assignes a boolean value to a word object to set it's status as hidden or shown
    public bool IsHidden()
    {
        foreach (char letter in Text) //parse through each char to check for underscores
        {
            if (letter == '_') 
            {
                _isHidden = true;
                return _isHidden;
            }
            else
            {
                _isHidden = false;
            }
        }
        return _isHidden;
    }
}