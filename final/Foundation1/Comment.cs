using System;

public class Comment
{
    public string _userName;
    public string _comment;

    public Comment(string userName, string comment)
    {
        _userName = userName;
        _comment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"> {_userName}: {_comment}");
    }
}