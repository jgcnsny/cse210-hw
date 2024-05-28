using System;
using System.Transactions;

public class Video 
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();
    

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title} - {_author} ");
        Console.WriteLine($"{_length} seconds");
    }

    public void  StoreComment(Comment comment)
    {
        _comments.Add(comment);  
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public void DisplayAllComments()
        {
            foreach (var comment in _comments)
            {
                comment.DisplayComment();
            }
        }

}