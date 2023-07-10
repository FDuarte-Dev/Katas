using FluentAssertions;
using Katalyst.RandomNumber;
using Katalyst.Test.RandomNumber.TestDoubles;

namespace Katalyst.Test.RandomNumber;

[Collection("RandomNumber")]
public class GuessingNumberGameShould
{
    [Fact]
    public void NotifyPlayerOfWinWhenGuessingCorrectly()
    {
        // Arrange
        const int correctGuess = 2;
        var generator = new TestableRandomNumberGenerator(correctGuess);
        var game = new GuessingNumberGame(generator);
        const int guess = 2;

        // Act
        var play = game.GuessNumber(guess);

        // Assert
        play.Should().Be(Responses.CORRECT_GUESS);
    }

    [Fact]
    public void NotifyPlayerWhenGuessingUnder()
    {
        // Arrange
        const int correctGuess = 2;
        var generator = new TestableRandomNumberGenerator(correctGuess);
        var game = new GuessingNumberGame(generator);
        const int guess = 1;

        // Act
        var play = game.GuessNumber(guess);

        // Assert
        play.Should().Be(Responses.CORRECT_HIGHER_THAN_GUESS);
    }
    
    [Fact]
    public void NotifyPlayerWhenGuessingHigher()
    {
        // Arrange
        const int correctGuess = 2;
        var generator = new TestableRandomNumberGenerator(correctGuess);
        var game = new GuessingNumberGame(generator);
        const int guess = 3;

        // Act
        var play = game.GuessNumber(guess);

        // Assert
        play.Should().Be(Responses.CORRECT_LOWER_THAN_GUESS);
    }

    [Fact]
    public void NotifyPlayerOfLostGameAfterFailingThirdTime()
    {
        // Arrange
        const int correctGuess = 4;
        var generator = new TestableRandomNumberGenerator(correctGuess);
        var game = new GuessingNumberGame(generator);
        
        const int firstGuess = 1;
        _ = game.GuessNumber(firstGuess);
        const int secondGuess = 2;
        _ = game.GuessNumber(secondGuess);

        // Act
        const int thirdGuess = 3;
        var play = game.GuessNumber(thirdGuess);

        // Assert
        play.Should().Be(Responses.YOU_LOSE);
    }
}