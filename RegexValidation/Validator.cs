namespace RegexValidation;

public abstract class Validator
{
    protected readonly int MinLenght;
    protected readonly int MaxLenght;

    protected Validator(int minLenght, int maxLenght)
    {
        MinLenght = minLenght;
        MaxLenght = maxLenght;
    }
    
    public abstract bool IsMatch(string input);
}