using System;
using System.Runtime.InteropServices;

public class Reference 
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse; 

    //two different constructors
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //constructor for scriptures that span multiple verses
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //getters and setters 
    public string Book
    {
        get {return _book;}
        set {_book = value;}
    }
     public int Chapter
    {
        get {return _chapter;}
        set {_chapter = value;}
    }
    public int Verse
    {
        get {return _verse;}
        set {_verse = value;}
    }
    public int EndVerse
    {
        get {return _endVerse;}
        set {_endVerse = value;}
    }
   
   //returns a formatted string citing the scripture
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{Book} {Chapter}:{Verse}";
        }
        else
        {
            return $"{Book} {Chapter}:{Verse}-{EndVerse}";
        }
    }
}