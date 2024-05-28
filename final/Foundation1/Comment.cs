using System;

public class Comment
{
    public string _authorName;
    public string _comment;

    public void DisplayComment()
    {
        Console.WriteLine($"{_comment} - {_authorName}");
    }
}