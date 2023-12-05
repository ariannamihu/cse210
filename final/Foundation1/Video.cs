using System;

public class Video
{
    private string _title = "";
    private string _author = "";
    private double _length = 0;
    private List<Comment> _commentsList = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _commentsList.Add(comment);
    }

    public int NumberOfComments()
    {
        return _commentsList.Count();
    }

    public List<Comment> ReturnCommentsList()
    {
        return _commentsList;
    }

    public override string ToString()
    {
        return $"{_title}, {_author}, {_length}, {NumberOfComments()}";
    }
}