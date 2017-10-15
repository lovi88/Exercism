using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        //Response to nothing
        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        //Response to shouting
        if (statement.Any(char.IsLetter) && statement.ToUpperInvariant() == statement)
        {
            return "Whoa, chill out!";
        }

        //Response to question
        if (statement.TrimEnd().Last() == '?')
        {
            return "Sure.";
        }

        //Response to everithing else
        return "Whatever.";
    }
}