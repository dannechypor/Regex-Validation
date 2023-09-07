namespace RegexValidation;

public class InputValidator : Validator
{
    public InputValidator(int maxLenght, int minLenght) : base(maxLenght, minLenght)
    {
    }
    
    public override bool IsMatch(string input)
    {
        return IsValidLength(input) &&
               ContainsRequiredCharacters(input) &&
               !ContainsWhitespace(input);
    }
    
    private bool IsValidLength(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }
        
        return input.Length >= MinLenght && input.Length <= MaxLenght;
    }

    private static bool ContainsRequiredCharacters(string input)
    {
        return RegexPatterns.ContainsUppercaseLetter(input) &&
               RegexPatterns.ContainsLowercaseLetter(input) &&
               RegexPatterns.ContainsDigit(input) &&
               RegexPatterns.ContainsSpecialCharacter(input);
    }

    private static bool ContainsWhitespace(string input)
    {
        return RegexPatterns.ContainsWhitespace(input);
    }
}