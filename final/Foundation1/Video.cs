using System;

public class Video 
{
    public string title;
    public string author;
    public int length;
    public List<Comments> CommentsList = new List<Comments>();

    public Video(string _title, string _author, int _length)
    {
        title = _title;
        author = _author;
        length = _length;
    }

     public int commentsCount()
    {
        return CommentsList.Count();
    }


    public string displayVideoInfo()
    {
        return String.Format("Title: {0}, Author: {1}, Duration: {2} minutes, Number of comments: {3}", title, author, length, commentsCount());
    }


}