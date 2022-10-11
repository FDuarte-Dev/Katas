using Katas.RandomNumber;

namespace Katas.Test.RandomNumber.TestDoubles;

public class TestableRandomNumberGenerator: RandomNumberGenerator
{
    private int CorrectGuess { get; }

    public TestableRandomNumberGenerator(int correctGuess)
    {
        CorrectGuess = correctGuess;
    }

    public override int GetInt()
    {
        return CorrectGuess;
    }
}