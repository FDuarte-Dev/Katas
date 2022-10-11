using FluentAssertions;
using Katas.RandomNumber;

namespace Katas.Test.RandomNumber;

public class RandomNumberGeneratorShould
{
    [Fact]
    public void GenerateRandomInteger()
    {
        // Arrange
        var generator = new RandomNumberGenerator();
        var firstGeneration = generator.GetInt();

        // Act
        int result;
        do
        {
            result = generator.GetInt();
        } while (firstGeneration == result);

        // Assert
        result.Should().NotBe(firstGeneration);
    }
}