using System;

class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;
    private List<Comment> comments = new List<Comment>();

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
                result += $"\n{comment.CommenterName}: {comment.CommentText}";
            }
        }

        return result + "\n";
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
}