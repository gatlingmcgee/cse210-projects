using System;

public class Comment
{
    public string CommenterName;
    public string CommentText;

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    public string GetName()
    {
        return CommenterName;
    }

    public string GetComment()
    {
        return CommentText;
    }
}