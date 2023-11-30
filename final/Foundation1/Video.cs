using System;

public class Video
{
    public string _title = "";
    public string _author = "";
    public double _length = 0;
    public List<Comment> _commentsList = new List<Comment>();

    public int NumberOfComments()
    {
        return _commentsList.Count();
    }
}