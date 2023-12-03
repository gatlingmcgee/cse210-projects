using System;

public class Video
{
    private string Title;
    private string Author;
    private int LengthInSeconds;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        comments.Add(comment);
    }

    public override string ToString()
    {
        string result = $"Title: {Title}\nAuthor: {Author}\nLength: {LengthInSeconds} seconds\nNumber of Comments: {GetNumberOfComments()}";

        if (GetNumberOfComments() > 0)
        {
            result += "\nComments:";
            foreach (var comment in comments)
            {
                result += $"\n{comment.GetName()}: {comment.GetComment()}";
            }
        }

        return result + "\n";
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
}


