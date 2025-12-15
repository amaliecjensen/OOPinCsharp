using System;
using System.Linq;

namespace ExtensionMethods
{
static void Main(string[] args)
{
    string post = "This is supposed to be a very long blog post blah blah blah...";
    var shortenedPost = post.Shorten(5);

    System.Console.WriteLine(shortenedPost);
}

public static class StringExtensions
{
    public static string Shorten(this string str, int numberOfWords)
    {
        if (numberOfWords < 0)
            throw new ArgumentOutOfRangeException("number of words should be greather than 0");

        if (numberOfWords == 0)
            return "";
        var words = str.Split(' ');

        if (words.Length <= numberOfWords)
            return str;


        return string.Join(" ", words.Take(numberOfWords));
    }
}
}
