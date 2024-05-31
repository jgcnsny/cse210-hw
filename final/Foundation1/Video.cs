using System;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video 
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    
    public void  StoreComment(Comment comment)
    {
        _comments.Add(comment);  
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title} - {_author} ");
        Console.WriteLine($"({_length} seconds)");
        Console.WriteLine($"Comments: {CommentCount()}");   

        foreach (var comment in _comments)
            {
                comment.DisplayComment();
            }
    }

    public int CommentCount()
    {
        return _comments.Count;
    }


}