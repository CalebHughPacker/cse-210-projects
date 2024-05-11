using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

public class Scripture 
{
    //create reference object
    private Reference _reference;

    //create list of word objects
    public List<Word> _words = new List<Word>();

    //constructor
    public Scripture (Reference reference, string text)
    {
        //add word objects to list
        _reference = reference;
        string[] wordsInText = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string newWord in wordsInText)
        {
            Word word = new(newWord);
            _words.Add(word);
        }
        
    }

    //get and set reference object
    public Reference Reference
    {
        get {return _reference;}
        set {_reference = value;}
    }

    //picks random words from the passage and hides them
    public bool HideRandomWords(int numberToHide)
    {
        Random random = new();
        while (numberToHide > 0) //loop until the number of hidden words matches the int parameter
        {
            bool allHidden = true;
            foreach (Word word in _words) //parse through each word in list
            {
                
                if (word.IsHidden() == false && numberToHide != 0)
                {
                    allHidden = false; //indicate that not all the words in the passage have been hidden
                    if (random.Next(0, _words.Count + 1) == 1)
                    {    
                        word.Hide(); //call hide method to hide the word
                        numberToHide -= 1; //mark another word as hidden 
                    }
                }
            }
            if (allHidden)
            {
               return true; //indicate that every word has been hidden
            }
        }
        return false;
    }

    //parses through each word object and concatenates the string member Text into a single string to be returned
    public string GetDisplayText()
    {
        string displayText = ""; 
        foreach(Word word in _words) 
        {
            displayText += word.Text;
            displayText += " ";
        } 

        return displayText;
    }
}