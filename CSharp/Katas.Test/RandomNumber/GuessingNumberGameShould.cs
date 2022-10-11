using FluentAssertions;
using Katas.RandomNumber;
using Katas.Test.RandomNumber.TestDoubles;

namespace Katas.Test.RandomNumber;

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
        play.Should().Be(Responses.GUESS_LOWER_THAN_CORRECT);
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
        play.Should().Be(Responses.GUESS_HIGHER_THAN_CORRECT);
    }
}