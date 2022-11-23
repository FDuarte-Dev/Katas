using FluentAssertions;
using Katas.RandomNumber;
using Katas.Test.RandomNumber.TestDoubles;

namespace Katas.Test.RandomNumber.UseCase;

[Collection("RandomNumber")]
public class GuessingNumberGameAT
{
    [Fact]
    public void CompleteWiningGame()
    {
        // Arrange
        const int correctGuess = 5;
        var generator = new TestableRandomNumberGenerator(correctGuess);
        var game = new GuessingNumberGame(generator);

        // Act
        const int firstGuess = 10;
        var firstPlay = game.GuessNumber(firstGuess);
        const int secondGuess = 3;
        var secondPlay = game.GuessNumber(secondGuess);
        const int thirdGuess = 5;
        var thirdPlay = game.GuessNumber(thirdGuess);

        // Assert
        firstPlay.Should().Be(Responses.CORRECT_LOWER_THAN_GUESS);
        secondPlay.Should().Be(Responses.CORRECT_HIGHER_THAN_GUESS);
        thirdPlay.Should().Be(Responses.CORRECT_GUESS);
    }
    
    [Fact]
    public void CompleteLosingGame()
    {
        // Arrange
        const int correctGuess = 4;
        var generator = new TestableRandomNumberGenerator(correctGuess);
        var game = new GuessingNumberGame(generator);

        // Act
        const int firstGuess = 10;
        var firstPlay = game.GuessNumber(firstGuess);
        const int secondGuess = 3;
        var secondPlay = game.GuessNumber(secondGuess);
        const int thirdGuess = 5;
        var thirdPlay = game.GuessNumber(thirdGuess);

        // Assert
        firstPlay.Should().Be(Responses.CORRECT_LOWER_THAN_GUESS);
        secondPlay.Should().Be(Responses.CORRECT_HIGHER_THAN_GUESS);
        thirdPlay.Should().Be(Responses.YOU_LOSE);
    }
}