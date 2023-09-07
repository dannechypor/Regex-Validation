using System.Text.RegularExpressions;

namespace RegexValidation;

public static partial class RegexPatterns
{
    [GeneratedRegex("[A-Z]")]
    private static partial Regex UppercaseLetter();
    [GeneratedRegex("[a-z]")]
    private static partial Regex LowercaseLetter();
    [GeneratedRegex("\\d")]
    private static partial Regex Digit();
    [GeneratedRegex("[!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~]")]
    private static partial Regex SpecialCharacter();
    [GeneratedRegex("\\s")]
    private static partial Regex Whitespace();
    
    public static bool ContainsUppercaseLetter(string input)
    {
        return UppercaseLetter().IsMatch(input);
    }

    public static bool ContainsLowercaseLetter(string input)
    {
        return LowercaseLetter().IsMatch(input);
    }

    public static bool ContainsDigit(string input)
    {
        return Digit().IsMatch(input);
    }

    public static bool ContainsSpecialCharacter(string input)
    {
        return SpecialCharacter().IsMatch(input);
    }

    public static bool ContainsWhitespace(string input)
    {
        return Whitespace().IsMatch(input);
    }
}