namespace RegexValidation.Tests;

public class InputValidatorTests
{
    private InputValidator _inputValidator;
    
    [SetUp]
    public void Setup()
    {
        _inputValidator = new InputValidator(6,12);
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("abc")]
    public void IsMatch_TooShortInput_ReturnsFalse(string input)
    {
        var result = _inputValidator.IsMatch(input);

        Assert.That(result, Is.False);
    }

    [TestCase("abcdefghijklmnopqr")]
    [TestCase("12345678901234567890")]
    public void IsMatch_TooLongInput_ReturnsFalse(string input)
    {
        var result = _inputValidator.IsMatch(input);

        Assert.That(result, Is.False);
    }

    [TestCase("Input1234@")]
    [TestCase("Input1@")]
    public void IsMatch_ValidInput_ReturnsTrue(string input)
    {
        var result = _inputValidator.IsMatch(input);

        Assert.That(result, Is.True);
    }

    [TestCase("nouppercase")]
    public void IsMatch_MissingUppercase_ReturnsFalse(string input)
    {
        var result = _inputValidator.IsMatch(input);

        Assert.That(result, Is.False);
    }

    [TestCase("NOLOWERCASE")]
    public void IsMatch_MissingLowercase_ReturnsFalse(string input)
    {
        var result = _inputValidator.IsMatch(input);

        Assert.That(result, Is.False);
    }

    [TestCase("NoSpecialChar1")]
    public void IsMatch_MissingSpecialChar_ReturnsFalse(string input)
    {
        var result = _inputValidator.IsMatch(input);

        Assert.That(result, Is.False);
    }

    [TestCase("NoDigit@")]
    public void IsMatch_MissingDigit_ReturnsFalse(string input)
    {
        var result = _inputValidator.IsMatch(input);

        Assert.That(result, Is.False);
    }

    [TestCase(" TooManySpaces ")]
    [TestCase("Too Many Spaces")]
    public void IsMatch_ExcessWhitespace_ReturnsFalse(string input)
    {
        var result = _inputValidator.IsMatch(input);

        Assert.That(result, Is.False);
    }
}