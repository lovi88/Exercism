using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        var letters = statement
            .Where(c => !(char.IsDigit(c) || char.IsPunctuation(c) || char.IsWhiteSpace(c) || char.IsSymbol(c))).ToList();

        if (letters.Count > 0 &&
            letters.All(c => char.IsUpper(c) || char.IsPunctuation(c) || char.IsDigit(c)))
        {
            return "Whoa, chill out!";
        }

        if (statement.TrimEnd().Last() == '?')
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}