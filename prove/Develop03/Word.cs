using System;

public class Word
//takes the words from the scripture and randomly hides the words each time the user presses the return key.
{   
    private string _word = "";
    public bool IsHidden {get; set;}

    public Word(string word)
    {
        _word = word;
    }
    
    // private string _hiddenWord = "";
    // private string _shownWord = "";



    public override string ToString()
    {
        if(IsHidden == true)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}