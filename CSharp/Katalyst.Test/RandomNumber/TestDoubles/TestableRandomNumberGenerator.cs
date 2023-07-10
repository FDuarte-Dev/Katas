using Katalyst.RandomNumber;

namespace Katalyst.Test.RandomNumber.TestDoubles;

[Collection("RandomNumber")]
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