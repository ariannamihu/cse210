using System;
using System.Collections.Generic;

public class Reference
//It stores the reference of the scripture and gives the option to include one verse or multiple verses.
{
    private string _bookName = "";
    private int _chapter = 0;
    private List<int> _verses = new List<int>();
    
    public Reference(string referenceString)
    // Ex: Mosiah 2:41-76
    {
        char[] delimiter = new char[] { ' ', ':' };
        string[] words = referenceString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length >= 2)
        {
            _bookName = words[0];

            _chapter = int.Parse(words[1]);
            var verseStrings = words[2].Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            if(verseStrings.Length == 1)
            {
                _verses.Add(int.Parse(verseStrings[0]));
            }
            //for extra make it so that they can put more than just the first and last verse
            else
            {
                _verses.Add(int.Parse(verseStrings[0]));
                _verses.Add(int.Parse(verseStrings[1]));
            }
        }
    }

    private string getVersesString()
    {
        if(_verses.Count == 1)
        {
            return _verses[0].ToString();
        }
        else
        {
            return $"{_verses[0]}-{_verses[_verses.Count-1]}";
        }
    }

    public override string ToString()
    {
        if(_verses.Count == 1)
        {
            return $"{_bookName} {_chapter}:{_verses[0]}";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_verses[0]}-{_verses[1]}";
        }
    }
}