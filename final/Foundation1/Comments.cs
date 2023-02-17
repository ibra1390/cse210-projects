using System;

public class Comments
{
    public string name;
    public string commentText;

    public Comments(string _name, string _commentText)
    {
        name = _name;
        commentText = _commentText;
    }

    public string FormatComment()
    {
        return string.Format("\t- {0} \n \t- '{1}'", name, commentText);
    }
}

