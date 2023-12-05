using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();
        
        Video video1 = new Video("How to bake a cake", "Marissa Smith", 605);
        // video1._title = "How to bake a cake";
        // video1._author = "Marissa Smith";
        // video1._length = 605;

        Comment comment1 = new Comment("Jesse","This is a great recipe!");
        // comment1._name = "Jesse";
        // comment1._comment = "This is a great recipe!";

        Comment comment2 = new Comment("Sam", "Thank you for this video!");
        // comment2._name = "Sam";
        // comment2._comment = "Thank you for this video!";

        Comment comment3 = new Comment("Mike", "I love cake!");
        // comment3._name = "Mike";
        // comment3._comment = "I love cake!";

        Comment comment4 = new Comment("Jeff", "I have never seen cake made this way!");
        // comment4._name = "Jeff";
        // comment4._comment = "I have never seen cake made this way!";

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);


        Video video2 = new Video("Super Fast Race Car", "Jenny Fisher", 102);
        // video2._title = "Super Fast Race Car";
        // video2._author = "Jenny Fisher";
        // video2._length = 102;

        Comment comment5 = new Comment("Jake", "What kind of car is that");
        // comment5._name = "Jake";
        // comment5._comment = "What kind of car is that";

        Comment comment6 = new Comment("Ari", "That's my friend!");
        // comment6._name = "Ari";
        // comment6._comment = "That's my friend!";

        Comment comment7 = new Comment("Ash", "I've watched this video like 100 times!!");
        // comment7._name = "Ash";
        // comment7._comment = "I've watched this video like 100 times!!";

        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);


        Video video3 = new Video("Sephora Haul", "Ava Jackson", 300);
        // video3._title = "Sephora Haul";
        // video3._author = "Ava Jackson";
        // video3._length = 300;

        Comment comment8 = new Comment("Braden Smith", "Is this all from a Sephora store in Utah?");
        // comment8._name = "Braden Smith";
        // comment8._comment = "Is this all from a Sephora store in Utah?";

        Comment comment9 = new Comment("Jolie", "What brand is the makeup you bought?");
        // comment9._name = "Jolie";
        // comment9._comment = "What brand is the makeup you bought?";

        Comment comment10 = new Comment("Everly", "That lipstick looks great.");
        // comment10._name = "Everly";
        // comment10._comment = "That lipstick looks great.";

        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);


        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);


        foreach (Video v in videosList)
        {
            Console.WriteLine(v.ToString());

            

            foreach (Comment c in v.ReturnCommentsList())
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine();
        }
    }
}