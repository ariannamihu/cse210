using System.Collections;
using System;

public class Scripture
//It should store the scripture and make it accessible to other classes. 
{
    public static List<Scripture> scripturesList= new List<Scripture>
    {
        new Scripture("Mosiah 2:41", "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."),

        new Scripture("Helaman 5:12","And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."),

        new Scripture("Mosiah 18:8-10","And it came to pass that he said unto them: Behold, here are the waters of Mormon (for thus were they called) and now, as ye are desirous to come into the fold of God, and to be called his people, and are willing to bear one another’s burdens, that they may be light \nYea, and are willing to mourn with those that mourn; yea, and comfort those that stand in need of comfort, and to stand as witnesses of God at all times and in all things, and in all places that ye may be in, even until death, that ye may be redeemed of God, and be numbered with those of the first resurrection, that ye may have eternal life— \nNow I say unto you, if this be the desire of your hearts, what have you against being baptized in the name of the Lord, as a witness before him that ye have entered into a covenant with him, that ye will serve him and keep his commandments, that he may pour out his Spirit more abundantly upon you?")
    };

    private Reference _verseReference;
    private List<Word> wordList = new List<Word>();

    public Scripture(string reference, string text)
    {
        _verseReference = new Reference(reference);
        wordList =textToWordList(text);
    }

    private List<Word> textToWordList(string text)
    {
        char[] delimiter = new char[] { ' ' };
        string[] words = text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

        List<Word> wordList = new List<Word>();
        foreach (string word in words)
        {
            wordList.Add(new Word(word));
        }

        return wordList;
    }

    public override string ToString()
    {
        return _verseReference.ToString() + " " + string.Join(" ", wordList);
    }

    public void hideRandomWord()
    {
        Random random = new Random();

        for(var i = 0; i<5; i++)
        {
            int randomIndex = random.Next(0, wordList.Count);
            Word randomWord = wordList[randomIndex];
            randomWord.IsHidden = true;
        }
    }
}